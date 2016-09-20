import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)			#BCM > (standart GPIO6)
					#BOARD > (standart PIN31)
GPIO.setup(18,GPIO.OUT)
GPIO.setup(17,GPIO.OUT)

try:
	while True:
		GPIO.output(17,GPIO.LOW)
		GPIO.output(18,GPIO.HIGH)
		time.sleep(1)			#sleep 1 detik
		GPIO.output(17,GPIO.HIGH)
		GPIO.output(18,GPIO.LOW)
		time.sleep(1)
except KeyboardInterrupt:
	GPIO.cleanup()			#mereset GPIO menjadi floating point
	print "Selesai"