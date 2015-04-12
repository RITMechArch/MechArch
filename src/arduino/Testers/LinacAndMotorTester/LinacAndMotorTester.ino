#include <LinearActuator.h>
#include <GearMotor.h>

const int encoderPinA = 2;
const int encoderPinB = 3;
const int motorEnable = 4;
const int motorDir    = 5;

const int linacDir      = 6;
const int linacEnable   = 8;
const int linacFeedback = 10;

int motorTarget     = 0;
int linacTarget     = 26;
long lastReportTime = 0;

LinearActuator linac = LinearActuator();
GearMotor motor = GearMotor();

void setup() 
{  
    pinMode(motorDir, OUTPUT);
    pinMode(motorEnable, OUTPUT);

    pinMode(linacDir, OUTPUT);
    pinMode(linacEnable, OUTPUT);

    Serial.begin(9600);
    linac.init(linacDir, linacEnable, linacFeedback);
    motor.init(motorDir, motorEnable, encoderPinA, encoderPinB);

    attachInterrupt(0, doPinA, CHANGE);
    attachInterrupt(1, doPinB, CHANGE);
}

void loop() 
{
    int linacPos = linac.getPosition();
    int motorPos = motor.getPosition();

    linac.moveTo(linacTarget);
    motor.moveTo(motorTarget);

    long curTime = millis();
    if ( (curTime - lastReportTime) >= 15000 )
    {
        lastReportTime = curTime;
        Serial.println("Linac P Position: ");
        Serial.println(motorPos);
        Serial.println("Linac P target: ");
        Serial.println(motorTarget);
        Serial.println();

        Serial.println("Linac Q Position: ");
        Serial.println(linacPos);
        Serial.println("Linac Q target: ");
        Serial.println(linacTarget);
        Serial.println();
        Serial.println();
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
            motorTarget = in1;
            if(motorTarget != -1)
            {
                Serial.print("Target position is ");
                Serial.println(motorTarget);
            } 
        }

        int in2;
        if(Serial.peek() == 'q') 
        {
            Serial.read();
            in2 = Serial.parseInt();
            linacTarget = in2;
            if(linacTarget != -1) 
            {
                Serial.print("Target position is ");
                Serial.println(linacTarget);
            } 
        }    
    }
}

void doPinA()
{
    motor.doPinA();
}

void doPinB()
{
    motor.doPinB();
}
