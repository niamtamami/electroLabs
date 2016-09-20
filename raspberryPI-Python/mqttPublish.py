import paho.mqtt.client as paho
import time 

def onMessage(client, userdata, msg):
	print msg.topic, msg.payload

client = paho.Client()
client.on_message = onMessage
client.connect("192.168.80.173",1883)
client.subscribe("#")
client.loop_start()

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