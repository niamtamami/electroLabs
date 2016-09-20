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

port = serial.Serial("/dev/ttyUSB0",9600)

workQueue = Queue.Queue(10)	
suhuQueue = Queue.Queue(10)
buzzerQueue = Queue.Queue(10)
disBuzzerQueue = Queue.Queue(10)


bus = smbus.SMBus(1)
address = 0x68

enableBuzzer=0
getBuzzer=0

def decToBCD(dec):
	return ((dec//10)*16) + (dec % 10)

def BCDToDec(bcd):
	return ((bcd//16)*10) + (bcd % 16)

def task1():	
	setSuhu = 0 #input data batas suhu OKE
	print "Batas Suhu :"
	print setSuhu
	setSuhu = raw_input("Masukan Batas Suhu: ")	#mengambil masukan variabel pada terminal menjadi teks
	while True:
		setSuhu = float(setSuhu)
		temp = suhuQueue.get()
		temp = float(temp)
		print temp
		print setSuhu
		if temp > setSuhu:
			global getBuzzer
			getBuzzer = 1
		else:
			global getBuzzer
			getBuzzer = 0
		time.sleep(1)			#kasih sedikit jeda buat program lain selesai

def task2():						#terima Data OKE
	while True:
		recv = port.read()
		if recv == "a":
			ch=workQueue.get()
			workQueue.empty()
			port.write(ch)
		time.sleep(0.01)

def	task3():
	while True:
		global enableBuzzer
		if enableBuzzer == 1:				#disable 
			print "buzzer off"
			GPIO.output(BUZZER,GPIO.LOW)
			GPIO.output(MERAH,GPIO.LOW)	
			time.sleep(0.1)
			GPIO.output(MERAH,GPIO.HIGH)
			time.sleep(1)
		else:
			global getBuzzer
			if getBuzzer == 1:
				print "buzzer on"
				GPIO.output(BUZZER,GPIO.HIGH)
				GPIO.output(MERAH,GPIO.LOW)	
				time.sleep(0.1)
				GPIO.output(BUZZER,GPIO.LOW)
				GPIO.output(MERAH,GPIO.HIGH)
				time.sleep(1)
		time.sleep(0.1)

def	task4():						#tampilkan suhu tiap 3 detik OKE
	while True:
		temp = bus.read_byte_data(address,0x11) + (bus.read_byte_data(address,0x12)>>6)*0.25
		suhuQueue.put(temp)
		m = ("Suhu %.2f C \r\n" % (temp))
		port.write(m)
		workQueue.put(m)
		time.sleep(3)

def	task5():						#baca Button OKE
	while True:
		time.sleep(0.01)	#membuat utilitas CPU lebih turun
		if GPIO.input(BUTTON0) == GPIO.LOW:				#reset
			global enableBuzzer
			enableBuzzer=1
			time.sleep(2)
			while GPIO.input(BUTTON0) == GPIO.LOW:
				time.sleep(0.01)

		

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

thread5 = threading.Thread(target = task5)
thread5.daemon = True
thread5.start()


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