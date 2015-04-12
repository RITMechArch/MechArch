#include <LinearActuator.h>
#include <GearMotor.h>

const int pinA         = 2;
const int pinB         = 3;
const int enablePin2   = 4;
const int dirPin2      = 5;

const int dirPin      = 6;
const int enablePin   = 8;
const int feedBackPin = 10;

int target = 26;
int target2 = 26;
long lastReportTime = 0;
int counter = 0;

LinearActuator linac = LinearActuator();
//LinearActuator linac2 = LinearActuator();
GearMotor motor = GearMotor();

void setup() {
  
  // put your setup code here, to run once:
  pinMode(dirPin, OUTPUT);
  pinMode(enablePin, OUTPUT);
  //pinMode(feedBackPin, INPUT);
  
  pinMode(dirPin2, OUTPUT);
  pinMode(enablePin2, OUTPUT);
  //pinMode(feedBackPin2, INPUT);
  
  Serial.begin(9600);
  linac.init(dirPin, enablePin, feedBackPin);
  motor.init(dirPin2, enablePin2, pinA, pinB);
  
  attachInterrupt(0, doPinA, CHANGE);
  attachInterrupt(1, doPinB, CHANGE);
}

void loop() {
  int pos = linac.getPosition();
  int pos2 = motor.getPosition();
  //linac.samplePosition();
  
  /*if ( (pos >= target+5) || (pos <= target-5) ) 
  {
  }*/
  linac.moveTo(target);
  motor.moveTo(target2);
  
  long curTime = millis();
  if ( (curTime - lastReportTime) >= 15000 )
  {
    lastReportTime = curTime;
    Serial.println("Linac P Position: ");
    Serial.println(pos);
    Serial.println("Linac P target: ");
    Serial.println(target);
    Serial.println();
    
    Serial.println("Linac Q Position: ");
    Serial.println(pos2);
    Serial.println("Linac Q target: ");
    Serial.println(target2);
    Serial.println();
    Serial.println();
  }
}

/*
void logData() {
  long positions[1000];
  long times[1000];
  for (int i = 0; i < 500; i++ ) 
  {
    times[i] = linac.samplePosition();
    positions[i] = linac.getPosition();
  }
  
  for(int i = 0; i < 500; i++)
  {
    Serial.print(positions[i]);
    Serial.print(' ');
    Serial.println(times[i]);
  }
} */

void serialEvent() {
  /*
  This whole block interprets the serial port inputs into commands for the system.
  Each command is a single letter followed directly by an integer argument.  Spaces between commands are optional.
  The commands are as follows:
    p        Sets the target position of the linear actuator.  Valid values are approximately from 8 to 995.
  */
  while(Serial.available()) {
    
    int in2;
    if(Serial.peek() == 's') {
      Serial.read();
      // logData();
    }
    
    int in3;
    if(Serial.peek() == 'p') {
      Serial.read();
      in3 = Serial.parseInt();
      target = in3;
      if(target != -1) {
        Serial.print("Target position is ");
        Serial.println(target);
      } 
    }
    
    int in4;
    if(Serial.peek() == 'q') {
      Serial.read();
      in4 = Serial.parseInt();
      target2 = in4;
      if(target2 != -1) {
        Serial.print("Target position is ");
        Serial.println(target2);
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
