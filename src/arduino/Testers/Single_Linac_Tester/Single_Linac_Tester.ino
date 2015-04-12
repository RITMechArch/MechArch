#include <LinearActuator.h>

const int dirPin      = 2;
const int enablePin   = 4;
const int feedBackPin = 1;

// Default target value determined experimentally
int target = 26;
long lastReportTime = 0;
int counter = 0;

LinearActuator linac = LinearActuator();

void setup() 
{
    // put your setup code here, to run once:
    pinMode(dirPin, OUTPUT);
    pinMode(enablePin, OUTPUT);

    Serial.begin(9600);
    linac.init(dirPin, enablePin, feedBackPin);
}

void loop() {
    int pos = linac.getPosition();
    linac.moveTo(target);

    long curTime = millis();
    if ( (curTime - lastReportTime) >= 1000 )
    {
        lastReportTime = curTime;
        Serial.println("CURPOS: ");
        Serial.println(pos);
        Serial.println("TARGET: ");
        Serial.println(target);
    }  
}

void serialEvent() 
{
    /*
    This whole block interprets the serial port inputs into commands for the system.
    Each command is a single letter followed directly by an integer argument.  Spaces between commands are optional.
    The commands are as follows:
      p        Sets the target position of the linear actuator.  Valid values are approximately from 8 to 995.
    */
    while(Serial.available()) 
    {    
        int in1;
        if(Serial.peek() == 'p') 
        {
            Serial.read();
            in1 = Serial.parseInt();
            target = in1;
            if(target != -1) 
            {
                Serial.print("Target position is ");
                Serial.println(target);
            } 
        }
    }
}
