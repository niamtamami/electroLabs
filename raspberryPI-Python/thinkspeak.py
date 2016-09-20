import time
import urllib2

baseURL = "https://api.thinkspeak.com/update?key=SQEM9ESBXBITCJWT&field4=77"
f = urllib2.urlopen(baseURL)
print f.read()
f.close()
