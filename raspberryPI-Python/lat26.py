#SOCKET PROGRAMMING: UDP server
#connect to GPIO

import RPi.GPIO as GPIO
import smbus
import socket
import time
import threading

def decToBCD(dec):
  return ((dec//10)*16) + (dec % 10)  

def BCDToDec(bcd):
  return ((bcd//16)*10) + (bcd % 16)

def FlipFlop():
  while True:
    data,addr = UDPSock.recvfrom(1024)
#    print data.strip().upper(),addr
    if data.strip().upper() == 'LED ON':
      GPIO.output(18,GPIO.LOW) #Merah ON
      UDPSock.sendto("Merah ON = OK\n",addr)
    elif data.strip().upper() == 'LED OFF':
      GPIO.output(18,GPIO.HIGH) #Merah OFF
      UDPSock.sendto("Merah OFF = OK\n",addr)
      
def KirimTemp():
  while True:
    if GPIO.input(27) == GPIO.LOW:
      UDPSock.sendto("suhu",("192.168.80.208",5559))
      data_temp,addr = UDPSock.recvfrom(100)
      print data_temp.strip(),addr
      while GPIO.input(27) == GPIO.LOW:
        time.sleep(0.01)
    else:
      time.sleep(0.01)

def KirimToggle():
  state_toggle = 0
  while True:
    if state_toggle == 0 and GPIO.input(23) == GPIO.LOW:
      state_toggle = 1
      print "Toggle 1 - taufiq"
      UDPSock.sendto("toggle1\n",("192.168.80.208",5559))
      time.sleep(0.25)
      while GPIO.input(23) == GPIO.LOW:
        time.sleep(0.01)
    elif state_toggle == 1 and GPIO.input(23) == GPIO.LOW:
      state_toggle = 0
      print "Toggle 0 - taufiq"
      UDPSock.sendto("toggle0\n",("192.168.80.208",5559))
      time.sleep(0.25)
      while GPIO.input(23) == GPIO.LOW:
        time.sleep(0.01)      
    else:
      time.sleep(0.01)

GPIO.setmode(GPIO.BCM)
GPIO.setup(18,GPIO.OUT)   #LED Merah
GPIO.setup(17,GPIO.OUT)   #LED Kuning
GPIO.setup(22,GPIO.OUT)   #LED Hijau
GPIO.output(18,GPIO.HIGH) #Merah OFF
GPIO.output(17,GPIO.HIGH) #Kuning OFF
GPIO.output(22,GPIO.HIGH) #Hijau OFF
GPIO.setup(27,GPIO.IN)    #Push Button 0
GPIO.setup(23,GPIO.IN)    #Push Button 1

bus = smbus.SMBus(1) #menunjuk bus I2C 1

UDPSock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)

#listen on port 5559
#(to all IP Addresses on this system)
listen_addr = ("",5559)
UDPSock.bind(listen_addr)

thread1 = threading.Thread(target=FlipFlop)
thread1.daemon = True
thread1.start()
thread2 = threading.Thread(target=KirimTemp)
thread2.daemon = True
thread2.start()
thread3 = threading.Thread(target=KirimToggle)
thread3.daemon = True
thread3.start()

try:
  while True:
    time.sleep(0.01)
except KeyboardInterrupt:
  UDPSock.close()
  GPIO.cleanup()
  print "Selesai"
