import RPi.GPIO as GPIO
import threading
import time
import Queue
import serial
import smbus

MERAH 	= 18
KUNING 	= 17
HIJAU 	= 22
BUTTON1 = 23
BUTTON0 = 27

GPIO.setmode(GPIO.BCM)			#BCM > (standart penulisan GPIO6)
								#BOARD > (standart penulisan PIN31)
GPIO.setup(MERAH,GPIO.OUT)
GPIO.setup(KUNING,GPIO.OUT)
GPIO.setup(HIJAU,GPIO.OUT)

GPIO.setup(BUTTON0,GPIO.IN)
GPIO.setup(BUTTON1,GPIO.IN)

GPIO.output(HIJAU,GPIO.HIGH)

port = serial.Serial("/dev/ttyUSB0",9600)

bus = smbus.SMBus(1)
address = 0x68

def decToBCD(dec):
	return ((dec//10)*16) + (dec % 10)

def BCDToDec(bcd):
	return ((bcd//16)*10) + (bcd % 16)

def task1():						#kirim Data
	count=0
	while True:
		port.write("Hello Niam %d \r\n" % (count))
		count += 1
		time.sleep(2)

def task2():						#terima Data
	while True:
		recv = port.readline()
		print recv

def	task3():
	while True:
		GPIO.output(MERAH,GPIO.LOW)
		time.sleep(0.5)
		GPIO.output(MERAH,GPIO.HIGH)
		time.sleep(0.5)

def	task4():
	while True:
		sec = bus.read_byte_data(address,0x00)
		sec = BCDToDec(sec)
		minute = bus.read_byte_data(address,0x01)
		minute = BCDToDec(minute)
		hour = bus.read_byte_data(address,0x02)
		hour = BCDToDec(hour)
		temp = bus.read_byte_data(address,0x11) + (bus.read_byte_data(address,0x12)>>6)*0.25
		print "Time %02d:%02d:%02d" % (hour,minute,sec)
		print "Temp %.2f" % temp + unichr(176) + "C"
		time.sleep(1)
		

#buat multitasking		
#kalau daemon=True, maka thread (menjadi service) bisa di close jika program utama di close
#kalau daemon=False, maka thread (menjadi service) tidak bisa di close saat program utama di close

thread1 = threading.Thread(target = task1)
thread1.daemon = True				
thread1.start()

thread2 = threading.Thread(target = task2)
thread2.daemon = True
thread2.start()

thread3 = threading.Thread(target = task3)
thread3.daemon = True
thread3.start()

thread4 = threading.Thread(target = task4)
thread4.daemon = True
thread4.start()


#pengaturan jam
#hour=11
#minute=38

#hour=decToBCD(hour)
#bus.write_byte_data(address,0x02,hour)
#minute=decToBCD(minute)
#bus.write_byte_data(address,0x01,minute)

try:
	while True:
		time.sleep(0.01)
		
except KeyboardInterrupt:
	port.close()
	print "selesai"