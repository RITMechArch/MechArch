#define PIN_DRAWING_ENABLE 3
#define PIN_DRAWING_DIREC 5
#define PIN_AIMX_ENABLE 9
#define PIN_AIMX_DIREC 12
#define PIN_AIMY_ENABLE 6
#define PIN_AIMY_DIREC 8
#define PIN_SOLENOID 38
#define ZERO_OFFSET 255

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
  
  int in;
  
  while(Serial.available()) {
  
    if(Serial.peek() == 'D') {
      Serial.read();
      in = Serial.parseInt();
      if(in < 4096) {
        Draw(in);
        while(Serial.available()) {
          Serial.read();
        }
        return;
        }
    }
  
    if(Serial.peek() == 'X') {
      Serial.read();
      in = Serial.parseInt() - ZERO_OFFSET;
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
      in = Serial.parseInt() - ZERO_OFFSET;
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
      
    if(Serial.peek() == 'd') {
      Serial.read();
      in = Serial.parseInt() - ZERO_OFFSET;
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
      in = Serial.parseInt();
      if(in == 0) {
        digitalWrite(PIN_SOLENOID, LOW);
      } else {
        digitalWrite(PIN_SOLENOID, HIGH);
      }
    }
      
    if(Serial.peek() == 'R') {
      Serial.read();
      in = Serial.parseInt();
      if(in == 0) {
        return;
      } else {
        Serial.print("0000000000000000000000");
      }
    }
  
  Serial.read();
  
  }
  
}

void Draw(int in) {
  // do nothing
}
