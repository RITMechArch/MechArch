#include <LinearActuator.h>
#include <GearMotor.h>

const int pinA         = 2;
const int pinB         = 3;

const int linacDirPin      = 7;
const int linacEnablePin   = 8;
const int linacFeedbackPin = 1;

const int linac2EnablePin   = 4;
const int linac2DirPin      = 5;
const int linac2FeedbackPin = 6;

const int motorEnablePin  = 12;
const int motorDirPin     = 14;


int motorTarget = 0;
int linac1Target = 26;
int linac2Target = 26;

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
  
  Serial.begin(9600);
  linac.init(linacDirPin, linacEnablePin, linacFeedbackPin);
  linac2.init(linac2DirPin, linac2EnablePin, linac2FeedbackPin);
  motor.init(motorDirPin, motorEnablePin, pinA, pinB);
  
  attachInterrupt(0, doPinA, CHANGE);
  attachInterrupt(1, doPinB, CHANGE);
}

void loop() {
  int linac1Pos = linac.getPosition();
  int linac2Pos = linac2.getPosition();
  int motorPos = motor.getPosition();
  
  linac.moveTo(linac1Target);
  linac2.moveTo(linac2Target);
  motor.moveTo(motorTarget);
  
  long curTime = millis();
  if ( (curTime - lastReportTime) >= 15000 )
  {
    lastReportTime = curTime;
    Serial.println("Linac 1 Position: ");
    Serial.println(linac1Pos);
    Serial.println("Linac 1 target: ");
    Serial.println(linac1Target);
    Serial.println();
    
    Serial.println("Linac 2 Position: ");
    Serial.println(linac2Pos);
    Serial.println("Linac 2 target: ");
    Serial.println(linac2Target);
    Serial.println();
    
    Serial.println("Motor Position: ");
    Serial.println(motorPos);
    Serial.println("Motor target: ");
    Serial.println(motorTarget);
    Serial.println();
    Serial.println();
  }
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
    if(Serial.peek() == 'm') {
      Serial.read();
      in2 = Serial.parseInt();
      motorTarget = in2;
      if(motorTarget != -1) {
        Serial.print("Motor Target position is ");
        Serial.println(motorTarget);
      }
    }
    
    int in3;
    if(Serial.peek() == 'p') {
      Serial.read();
      in3 = Serial.parseInt();
      linac1Target = in3;
      if(linac1Target != -1) {
        Serial.print("Target position is ");
        Serial.println(linac1Target);
      } 
    }
    
    int in4;
    if(Serial.peek() == 'q') {
      Serial.read();
      in4 = Serial.parseInt();
      linac2Target = in4;
      if(linac2Target != -1) {
        Serial.print("Target position is ");
        Serial.println(linac2Target);
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
