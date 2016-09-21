//Arduino PWM Speed Control：
int rotari = A0;
int E1 = 5;  
int M1 = 4; 
int E2 = 6;                      
int M2 = 7;                        
int kecMentah,maxRotari;

byte rotPulsa,rotPulsaLama;
unsigned int counterPulsa;
unsigned long loopTime;
char inChar;

byte bPWM,bKec;
float fPWM,fKec;

void setup() 
{ 
  pinMode(M1, OUTPUT);   
  pinMode(M2, OUTPUT); 
  digitalWrite(M1,HIGH);   
  digitalWrite(M2, HIGH); 
  Serial.begin(9600);

  pinMode(A0, INPUT);
  digitalWrite(A0, HIGH);
  pinMode(A1, INPUT);
  digitalWrite(A1, HIGH);
  
  loopTime=millis();
  
  maxRotari=100;  //lihat data osiloskop
} 

void loop() 
{ 
  kecMentah = analogRead(rotari);

  if (kecMentah>500) rotPulsa = 1;
  else rotPulsa = 0;

  if ((rotPulsa-rotPulsaLama)==1) counterPulsa++;
  rotPulsaLama = rotPulsa;

  analogWrite(E1, bPWM);   //PWM Speed Control
  analogWrite(E2, bPWM);   //PWM Speed Control

  if (millis()-loopTime>200)
  {
    if (counterPulsa>maxRotari) maxRotari = counterPulsa;
    fKec = ((float(counterPulsa)/float(maxRotari))*100.0f);
    bKec = byte(fKec);
    Serial.write(bKec);
    counterPulsa=0;
    loopTime=millis();
  }

}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    inChar = (char)Serial.read();
    if (inChar>100) inChar=100;
    fPWM = float(inChar)*2.55f;
    bPWM = byte(fPWM);  
  }
}


