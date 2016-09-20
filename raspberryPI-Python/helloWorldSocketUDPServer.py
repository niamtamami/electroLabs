import socket

UDPSock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)

#listen on port 21567
#to all ip address in this system
listen_addr = ("",5559)
UDPSock.bind(listen_addr)

try:
	while True:
		data, addr = UDPSock.recvfrom(1023)
		print data.strip(), addr
		UDPSock.sendto("OK\n",addr)

except KeyboardInterrupt:
	UDPSock.close()
	print "selesai"
