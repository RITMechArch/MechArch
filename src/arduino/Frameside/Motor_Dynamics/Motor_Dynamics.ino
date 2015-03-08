#include <SPI.h>

byte setup_byte = B01000110;
byte clock_byte = B00001110;
byte setup_comm = B00010000;
byte clock_comm = B00100000;
byte data1_comm = B00111000;

int ADCSS = 5;

volatile unsigned int pos;
unsigned long t1 = millis();
int drdy = 2;
int dir = 4;
int enable = 5;
int data[250];
int output = 0;
boolean direc;
boolean on;
boolean serial = true;
int error1 = 0;
int error2 = 0;
int index = 0;

int DL_MinPower = 64;
int DL_MaxPower = 255;
int DL_MinPosition = 20;
int DL_MaxPosition = 4000;
int DL_FineControlDist = 400;
int DL_Overshoot = 4;
int DL_MinMovement = 8;
int DL_ProportionalConst = 1;
//int DL_IntegralConst = 1;

void setup() {
  Serial.begin(115200);
  pinMode(drdy, INPUT);
  pinMode(10, OUTPUT);
  pinMode(ADCSS, OUTPUT);
  pinMode(dir, OUTPUT);
  pinMode(enable, OUTPUT);
  digitalWrite(enable, HIGH);
  digitalWrite(ADCSS, HIGH);
}

void loop() {
  delay(1);
}

void readData() {
  digitalWrite(ADCSS, LOW);
  SPI.transfer(data1_comm);
  unsigned int in1 = (int)SPI.transfer(0);
  byte in2 = SPI.transfer(0);
  pos = (in1 << 4) ^ (in2 >> 4);
  digitalWrite(ADCSS, HIGH);
  if(index < 250) {
    data[index] = pos;
    index++;
  } else {
    detachInterrupt(0);
    digitalWrite(enable, HIGH);
    for(int i = 0; i < 250; i++) {
      Serial.println(data[i]);
    }
  }
}

void serialEvent() {
  if(Serial.peek() == 's') {
    Serial.println("Serial recieved, starting SPI bus");
    setupSPI();
  }
  if(Serial.peek() == '1') {
    attachInterrupt(0, readData, FALLING);
    digitalWrite(dir, HIGH);
    digitalWrite(enable, LOW);
  }
  if(Serial.peek() == '0') {
    attachInterrupt(0, readData, FALLING);
    digitalWrite(dir, LOW);
    digitalWrite(enable, LOW);
  }
  while(Serial.available()) {
    Serial.read();
  }
}

void setupSPI() {
  SPI.begin();
  delay(10);
  SPI.setBitOrder(MSBFIRST);
  delay(10);
  SPI.setDataMode(SPI_MODE3);
  delay(10);
  digitalWrite(ADCSS, LOW);
  delay(10);
  SPI.transfer(clock_comm);
  delay(10);
  SPI.transfer(clock_byte);
  delay(10);
  SPI.transfer(setup_comm);
  delay(10);
  SPI.transfer(setup_byte);
  delay(10);
  digitalWrite(ADCSS, HIGH);
  delay(10);

  Serial.println("SPI is ready");
}
