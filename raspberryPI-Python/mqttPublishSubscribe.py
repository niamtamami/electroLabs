import paho.mqtt.client as paho	#as paho, kita bisa menyingkat paho.mqtt.client menjadi paho
import time 

def onMessage(client, userdata, msg):
	print msg.topic, msg.payload

client = paho.Client()					#atau client = paho.Client(client_id = "101090")
client.on_message = onMessage 			#ketika pesan subscribe di terima, langsung di pindahkan ke fungsi dengan nama onMessage
client.connect("192.168.80.173",1883)
client.subscribe("#") 		#pilih topik sesuai dengan yang diinginkan, # = all, niamtamami/# = topik tertentu (topik niamtamami)
client.loop_start()						#looping untuk ambil subsscribe

#mosquitto_pub -h 192.168.80.173 -t "led/merah" -m "om"

try:
	while True:
		client.publish("niamtamami/led/merah","ON")
		time.sleep(3)
		client.publish("niamtamami/led/merah","OFF")
		time.sleep(3)
		pass
except KeyboardInterrupt:
	client.disconnect()
	print "selesai"