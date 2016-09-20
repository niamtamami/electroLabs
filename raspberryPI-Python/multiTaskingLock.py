#logitech c270, c310
#wifi nya beli realtek

import RPi.GPIO as GPIO
import threading
import time

MERAH 	= 18
KUNING 	= 17
HIJAU 	= 22
BUTTON0 = 27

GPIO.setmode(GPIO.BCM)			#BCM > (standart penulisan GPIO6)
					#BOARD > (standart penulisan PIN31)
GPIO.setup(MERAH,GPIO.OUT)
GPIO.setup(KUNING,GPIO.OUT)
GPIO.setup(HIJAU,GPIO.OUT)
GPIO.setup(BUTTON0,GPIO.IN)

GPIO.output(HIJAU,GPIO.HIGH)

lock = threading.Lock()

def loopingMerah():
	while True:
		lock.acquire()
		GPIO.output(MERAH,GPIO.HIGH)	#lock > periperal hardware harus dikunci terlebih dahulu untuk dapat digunakan bersama
		time.sleep(1)			#sleep 1 detik
		GPIO.output(MERAH,GPIO.LOW)
		time.sleep(1)
		lock.release()			
		time.sleep(0.03)

def loopingKuning():
	while True:
		lock.acquire()
		GPIO.output(MERAH,GPIO.LOW)
		time.sleep(0.3)			#sleep 0.5 detik
		GPIO.output(MERAH,GPIO.HIGH)
		time.sleep(0.3)
		lock.release()
		

def loopingbutton0():
	while True:
		time.sleep(0.01)	#membuat utilitas CPU lebih turun
		if GPIO.input(BUTTON0) == GPIO.LOW:
			GPIO.output(HIJAU,GPIO.LOW)
			time.sleep(2)
			GPIO.output(HIJAU,GPIO.HIGH)
			while GPIO.input(BUTTON0) == GPIO.LOW:
				time.sleep(0.01)

thread1 = threading.Thread(target = loopingMerah)
thread1.daemon = True				#kalau daemon=True, maka thread (menjadi service) bisa di close jika program utama di close
						#kalau daemon=False, maka thread (menjadi service) tidak bisa di close saat program utama di close
thread1.start()

thread2 = threading.Thread(target = loopingKuning)
thread2.daemon = True
thread2.start()

thread3 = threading.Thread(target = loopingbutton0)
thread3.daemon = True
thread3.start()

try:
	while True:
		time.sleep(0.01)
		#pass				#kalau di C itu NOP = No Operation

except KeyboardInterrupt:
	GPIO.cleanup()				#mereset GPIO menjadi floating point
	print "Selesai"