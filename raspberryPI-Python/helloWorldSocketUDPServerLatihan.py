import socket
import time

UDPSock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
listen_addr = ("",5558)
UDPSock.bind(listen_addr)

try:
	while True:
		UDPSock.sendto("led on",('192.168.80.184',5559))
		time.sleep(1)
		UDPSock.sendto("led off",('192.168.80.184',5559))
		time.sleep(1)


except KeyboardInterrupt:
	UDPSock.close()
	print "selesai"
