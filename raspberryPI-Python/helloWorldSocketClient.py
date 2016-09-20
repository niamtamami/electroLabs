import socket

clientSocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
clientSocket.connect(('192.168.0.80',23000))
clientSocket.send("Hello World\n")

print clientSocket.recv(100)
clientSocket.close()