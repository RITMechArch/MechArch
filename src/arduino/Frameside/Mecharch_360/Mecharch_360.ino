#define PIN_DRAWING_ENABLE 3
#define PIN_DRAWING_DIREC 5
#define PIN_AIMX_ENABLE 9
#define PIN_AIMX_DIREC 12
#define PIN_AIMY_ENABLE 6
#define PIN_AIMY_DIREC 8
#define PIN_SOLENOID 38

void setup() {
  
  pinMode(PIN_DRAWING_ENABLE, OUTPUT);
  pinMode(PIN_DRAWING_DIREC, OUTPUT);
  pinMode(PIN_AIMX_ENABLE, OUTPUT);
  pinMode(PIN_AIMX_DIREC, OUTPUT);
  pinMode(PIN_AIMY_ENABLE, OUTPUT);
  pinMode(PIN_AIMY_DIREC, OUTPUT);
  pinMode(PIN_SOLENOID, OUTPUT);
  
  Serial.begin(115200);
}

void loop() {
  if(Serial.available()) {
    ParseSerial();
  }
}

void ParseSerial() {
  
  while(Serial.available()) {
    
    if(Serial.peek() == 'X') {
      Serial.read();
      int in = Serial.parseInt();
      in -= 256;
      if(in > 0) {
        digitalWrite(PIN_AIMX_DIREC, HIGH);
        analogWrite(PIN_AIMX_ENABLE, in);
      } else if(in < 0) {
        digitalWrite(PIN_AIMX_DIREC, LOW);
        analogWrite(PIN_AIMX_ENABLE, abs(in));
      } else {
        analogWrite(PIN_AIMX_ENABLE, 0);
      }
     }
     
     if(Serial.peek() == 'Y') {
      Serial.read();
      int in = Serial.parseInt();
      in -= 256;
      if(in > 0) {
        digitalWrite(PIN_AIMY_DIREC, HIGH);
        analogWrite(PIN_AIMY_ENABLE, in);
      } else if(in < 0) {
        digitalWrite(PIN_AIMY_DIREC, LOW);
        analogWrite(PIN_AIMY_ENABLE, abs(in));
      } else {
        analogWrite(PIN_AIMY_ENABLE, 0);
      }
     }
     
     if(Serial.peek() == 'D') {
      Serial.read();
      int in = Serial.parseInt();
      in -= 256;
      if(in > 0) {
        digitalWrite(PIN_DRAWING_DIREC, HIGH);
        analogWrite(PIN_DRAWING_ENABLE, in);
      } else if(in < 0) {
        digitalWrite(PIN_DRAWING_DIREC, LOW);
        analogWrite(PIN_DRAWING_ENABLE, abs(in));
      } else {
        analogWrite(PIN_DRAWING_ENABLE, 0);
      }
     }
     
     if(Serial.peek() == 'F') {
       Serial.read();
       int in = Serial.parseInt();
       if(in == 0) {
         digitalWrite(PIN_SOLENOID, LOW);
       }else{
         digitalWrite(PIN_SOLENOID, HIGH);
       }
     }
     
    Serial.read(); 
    
  }
  
}
