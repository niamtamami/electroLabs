import socket
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
BUTTON0 = 27	#reset
BUZZER	= 24

portNiam = 5559
ipTujuan = '192.168.80.184'

GPIO.setmode(GPIO.BCM)			#BCM > (standart penulisan GPIO6)
								#BOARD > (standart penulisan PIN31)
GPIO.setup(MERAH,GPIO.OUT)
GPIO.setup(KUNING,GPIO.OUT)
GPIO.setup(HIJAU,GPIO.OUT)
GPIO.setup(BUZZER,GPIO.OUT)

GPIO.setup(BUTTON0,GPIO.IN)
GPIO.setup(BUTTON1,GPIO.IN)

GPIO.output(HIJAU,GPIO.HIGH)
GPIO.output(BUZZER,GPIO.LOW)

UDPSock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
listen_addr = ("",portNiam)
UDPSock.bind(listen_addr)

bus = smbus.SMBus(1)
address = 0x68

def decToBCD(dec):
	return ((dec//10)*16) + (dec % 10)

def BCDToDec(bcd):
	return ((bcd//16)*10) + (bcd % 16)

def task1():						#point 1 oke
	while True:
		UDPSock.sendto("led on",(ipTujuan,portNiam))
		GPIO.output(HIJAU,GPIO.LOW)
		time.sleep(1)
		UDPSock.sendto("led off",(ipTujuan,portNiam))
		GPIO.output(HIJAU,GPIO.HIGH)
		time.sleep(1)	

def task2():						#point 2.1 2.2 dan 2.3 oke #point 3.1 3.2 dan 3.3 oke
	while True:
		data, addr = UDPSock.recvfrom(100)
		dataterima = data.strip()
		print dataterima, addr
		if dataterima == "suhu":
			temp = bus.read_byte_data(address,0x11) + (bus.read_byte_data(address,0x12)>>6)*0.25
			time.sleep(1.5)
			m = "Suhu %.2f C" % (temp)
			print m
			UDPSock.sendto(m,(ipTujuan,portNiam))
		elif dataterima == "toggle0":
			UDPSock.sendto("led off",(ipTujuan,portNiam))
			GPIO.output(MERAH,GPIO.HIGH)
		elif dataterima == "toggle1":
			UDPSock.sendto("led on",(ipTujuan,portNiam))
			GPIO.output(MERAH,GPIO.LOW)		

def	task3():						#point 3.2 dan 3.3 oke
	while True:
		time.sleep(1)
		
def	task4():						
	while True:
		time.sleep(1)

def	task5():						#baca Button OKE
	while True:
		time.sleep(1)

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

thread5 = threading.Thread(target = task5)
thread5.daemon = True
thread5.start()

try:
	while True:
		time.sleep(1)

except KeyboardInterrupt:
	UDPSock.close()
	print "selesai"
