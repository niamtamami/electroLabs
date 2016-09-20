import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)			#BCM > (standart GPIO6)
					#BOARD > (standart PIN31)
GPIO.setup(18,GPIO.OUT)
GPIO.output(18,GPIO.HIGH)
GPIO.setup(27,GPIO.IN)

try:
	while True:
		time.sleep(0.01)	#membuat utilitas CPU lebih turun
		if GPIO.input(27) == GPIO.LOW:
			GPIO.output(18,GPIO.LOW)
			time.sleep(2)
			GPIO.output(18,GPIO.HIGH)
			while GPIO.input(27) == GPIO.LOW:
				time.sleep(0.01)
except KeyboardInterrupt:
	GPIO.cleanup()			#mereset GPIO menjadi floating point
	print "Selesai"