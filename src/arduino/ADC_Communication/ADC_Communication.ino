#include <SPI.h>
byte setup_byte = B01000110;
byte clock_byte = B00001110;
byte setup_comm = B00010000;
byte clock_comm = B00100000;
byte data1_comm = B00111000;
int ADCSS = 5;
volatile unsigned int pos;
unsigned long t1 = millis();

void setup() {
  Serial.begin(9600);
  pinMode(10, OUTPUT);
  pinMode(ADCSS, OUTPUT);
  digitalWrite(ADCSS, HIGH);
}

void loop() {
  if(millis() - t1 >= 500) {
    Serial.println(pos);
    pos = 0;
    t1 = millis();
  }
}

void readData() {
  digitalWrite(ADCSS, LOW);
  SPI.transfer(data1_comm);
  unsigned int in1 = (int)SPI.transfer(0);
  byte in2 = SPI.transfer(0);
  pos = (in1 << 8) ^ in2;
  digitalWrite(ADCSS, HIGH);
}

void serialEvent() {
    Serial.println("Serial recieved, starting SPI bus");
    setupSPI();
  while(Serial.available()) {
    Serial.read();
  }
}

void setupSPI() {
  SPI.begin();
  Serial.println("SPI has started");
  delay(10);
  SPI.setBitOrder(MSBFIRST);
  Serial.println("SPI bit order set");
  delay(10);
  SPI.setDataMode(SPI_MODE3);
  Serial.println("SPI data mode set");
  delay(10);
  digitalWrite(ADCSS, LOW);
  Serial.println("Slave select set LOW");
  delay(10);
  SPI.transfer(clock_comm);
  Serial.println("Clock register selected");
  delay(10);
  SPI.transfer(clock_byte);
  Serial.println("Clock register configured");
  delay(10);
  SPI.transfer(setup_comm);
  Serial.println("Setup register selected");
  delay(10);
  SPI.transfer(setup_byte);
  Serial.println("Setup register configured");
  delay(10);
  digitalWrite(ADCSS, HIGH);
  Serial.println("Slave slect set HIGH");
  delay(10);
  attachInterrupt(0, readData, FALLING);
  Serial.println("Interrupt set");
  delay(10);
}
