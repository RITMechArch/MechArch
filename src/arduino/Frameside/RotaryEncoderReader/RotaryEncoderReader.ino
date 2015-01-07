#include <RotaryEncoderReader.h>

const int encoderPinA = 2;
const int encoderPinB = 3;

long lastTime = 0;

RotaryEncoderReader reader(encoderPinA, encoderPinB);

void setup() 
{
    pinMode(encoderPinA, INPUT); 
    pinMode(encoderPinB, INPUT); 

// encoder pin on interrupt 0 (pin 2)
  attachInterrupt(0, doEncoderA, CHANGE);

// encoder pin on interrupt 1 (pin 3)
  attachInterrupt(1, doEncoderB, CHANGE);  

  Serial.begin (115200);

}

void loop()
{
    // Report the current position of the encoder for debugging
    long time = millis();
    if (time - lastTime > 1000)
    {
        lastTime = time;
        Serial.println(reader.getPosition(), DEC);
    }
}

void doEncoderA()
{
    reader.doEncoderA();  
}

void doEncoderB()
{
    reader.doEncoderB();
} 
