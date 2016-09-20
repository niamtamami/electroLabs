import paho.mqtt.client as paho	#as paho, kita bisa menyingkat paho.mqtt.client menjadi paho
import time 
import RPi.GPIO as GPIO
import threading

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

def onMessage(client, userdata, msg):
	dataTopik = msg.topic
	dataPayload = msg.payload
	print dataTopik, dataPayload
	if (dataPayload=="PB1"):
		GPIO.output(MERAH,GPIO.LOW)
	elif (dataPayload=="PB0"):
		GPIO.output(MERAH,GPIO.HIGH)
	pass

def onConnect(client, data, rc):
	client.subscribe("pens/elka/niam/tombol/#") 		#pilih topik sesuai dengan yang diinginkan, # = all, niamtamami/# = topik tertentu (topik niamtamami)
	pass

def onPublish(client, userdata, mid):
	print str(mid)
	pass

def onSubscribe(client, userdata, mid, granted_qos): #qos 0 = kirim data saja, #qos 1 = kirim data kemudian konfirmasi data masuk, #qos 2 = kirim data kemudian konfirmasi data masuk lalu verifikasi paket data benar atau tidak 
	print str(mid)
	pass

client = paho.Client()					#atau client = paho.Client(client_id = "101090")
client.on_message = onMessage 			#call back #ketika pesan subscribe di terima, langsung di pindahkan ke fungsi dengan nama onMessage
client.on_connect = onConnect
client.on_publish = onPublish
client.on_subscribe = onSubscribe
client.connect("192.168.1.110",1883)

client.loop_start()						#looping untuk ambil subsscribe

#mosquitto_pub -h 192.168.80.173 -t "led/merah" -m "om"

def task1():						#point 1 oke
	while True:
		if GPIO.input(BUTTON0) == GPIO.LOW:				#reset
			client.publish("pens/elka/taufiq","PB0")
			time.sleep(0.05)
			while GPIO.input(BUTTON0) == GPIO.LOW:
				time.sleep(0.01)
		elif GPIO.input(BUTTON1) == GPIO.LOW:				#reset
			client.publish("pens/elka/taufiq","PB1")
			time.sleep(0.05)
			while GPIO.input(BUTTON1) == GPIO.LOW:
				time.sleep(0.01)
		else:
			time.sleep(0.01)	#membuat utilitas CPU lebih turun

def task2():						#point 2.1 2.2 dan 2.3 oke #point 3.1 3.2 dan 3.3 oke
	while True:
		time.sleep(1)	

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
		time.sleep(0.01)
		pass

except KeyboardInterrupt:
	client.disconnect()
	print "selesai"