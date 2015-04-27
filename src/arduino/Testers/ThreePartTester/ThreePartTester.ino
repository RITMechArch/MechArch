#include <LinearActuator.h>
#include <GearMotor.h>


// D
const int linacFeedbackPin = 2;
const int linacEnablePin   = 3;
const int linacDirPin      = 4;

// Y

const int linac2FeedbackPin = 5;
const int linac2EnablePin   = 6;
const int linac2DirPin      = 8;

const int motorEnablePin  = 10;
const int motorDirPin     = 12;

const int pinA         = 21;
const int pinB         = 20;

int motorTarget = 0;
int linac1Target = -1;
int linac2Target = -1;

long lastReportTime = 0;
int counter = 0;

LinearActuator linac = LinearActuator();
LinearActuator linac2 = LinearActuator();
GearMotor motor = GearMotor();

void setup() {
  
  // put your setup code here, to run once:
  pinMode(linacDirPin, OUTPUT);
  pinMode(linacEnablePin, OUTPUT);
  
  pinMode(linac2DirPin, OUTPUT);
  pinMode(linac2EnablePin, OUTPUT);
  
  pinMode(motorEnablePin, OUTPUT);
  pinMode(motorDirPin, OUTPUT);
  
  pinMode(pinA, INPUT);
  pinMode(pinB, INPUT);
  
  Serial.begin(9600);
  Serial1.end();
  Serial2.end();
  Serial3.end();
  
  linac.init(linacDirPin, linacEnablePin, linacFeedbackPin);
  linac2.init(linac2DirPin, linac2EnablePin, linac2FeedbackPin);
  motor.init(motorDirPin, motorEnablePin, pinA, pinB);
  
  attachInterrupt(2, doPinA, CHANGE);
  attachInterrupt(3, doPinB, CHANGE);
  
  for(int i = 0; i <100; i++)
  {
      linac.samplePosition();
      linac2.samplePosition();
  }
}

void loop() {  
  if (linac1Target != -1)
  {
      linac.moveTo(linac1Target);
  }
  if (linac2Target != -1)
  {
      linac2.moveTo(linac2Target);
  }
  motor.moveTo(motorTarget); 
}

void serialEvent() {
  /*
  This whole block interprets the serial port inputs into commands for the system.
  Each command is a single letter followed directly by an integer argument.  Spaces between commands are optional.
  The commands are as follows:
    p        Sets the target position of the linear actuator.  Valid values are approximately from 8 to 995.
  */
  while(Serial.available()) {
    
    int in2;
    if(Serial.peek() == 'x') {
      Serial.read();
      in2 = Serial.parseInt();
      motorTarget = in2;
      if(motorTarget != -1) {
        Serial.print("Motor Target position is ");
        Serial.println(motorTarget);
      }
    }
    
    int in3;
    if(Serial.peek() == 'z') {
      Serial.read();
      in3 = Serial.parseInt();
      linac1Target = in3;
      if(linac1Target != -1) {
        Serial.print("Target position is ");
        Serial.println(linac1Target);
      } 
    }
    
    int in4;
    if(Serial.peek() == 'y') {
      Serial.read();
      in4 = Serial.parseInt();
      linac2Target = in4;
      if(linac2Target != -1) {
        Serial.print("Target position is ");
        Serial.println(linac2Target);
      } 
    }
    
    if (Serial.peek() == 'p')
    {
        Serial.read();
        {
            Serial.println("Linac Z Position: ");
            Serial.println(analogRead(linacFeedbackPin));
            Serial.println(linac.getPosition());
            Serial.println("Linac Z target: ");
            Serial.println(linac1Target);
            Serial.println();
            
            Serial.println("Linac Y Position: ");
            Serial.println(analogRead(linac2FeedbackPin));
            Serial.println(linac2.getPosition());
            Serial.println("Linac Y target: ");
            Serial.println(linac2Target);
            Serial.println();
            
            Serial.println("Motor Position: ");
            Serial.println(motor.getPosition());
            Serial.println("Motor target: ");
            Serial.println(motorTarget);
            Serial.println();
            Serial.println();
        }
    }
    
    if(Serial.peek() == ' ') {
      Serial.read();
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
