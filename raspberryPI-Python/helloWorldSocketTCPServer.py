import socket

serverSocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
serverSocket.bind(('',23002))
serverSocket.listen(5)

while True:

	clientSocket, (remoteHost, remotePort) = serverSocket.accept()

	s=clientSocket.recv(100)

	clientSocket.send(s)
	clientSocket.close()
	pass
