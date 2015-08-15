#include <SPI.h>

#include <Ethernet.h>

#include <LinearActuator.h>

#include <RotaryEncoderReader.h>
#include <GearMotor.h>

const int drawingLinacFeedback = 2;
const int drawingLinacEnable   = 3;
const int drawingLinacDir      = 5;

const int verticalFeedback     = 5;
const int verticalLinacEnable  = 6;
const int verticalLinacDir     = 8;

const int motorEnablePin  = 9;
const int motorDirPin     = 12;
const int pinA            = 21;
const int pinB            = 20;

const int fOptic          = 30;
const int rOptic          = 32;

const int fireSolenoid    = 38;


// ------- Ethernet Server Settings and Variables
byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };  
byte ip[] = { 169, 254, 211, 1 };    
byte gateway[] = { 129, 21, 249, 254 };
byte subnet[] = { 255, 255, 255, 0 };


EthernetServer server = EthernetServer(2300);
EthernetClient tcpClient;
boolean hasConnected = false;
char buf[128];
int bufferSize = 0;
boolean hasArrow = false;

const int MOTOR_DISABLED = 0;

LinearActuator drawingLinac = LinearActuator();
LinearActuator verticalLinac = LinearActuator();
GearMotor motor = GearMotor();

int drawingLinacPos = 0;
int verticalLinacPos = 0;
int motorPos = 0;

int motorTarget = 0;
int drawingLinacTarget = 400;
int verticalLinacTarget = 400;

boolean xMovementRequested = false;
boolean yMovementRequested = false;
boolean zMovementRequested = false;

boolean xMovementCompleted = true;
boolean yMovementCompleted = true;
boolean zMovementCompleted = true;


int zRetractedPosition = 0;

long startMovementTime;
boolean fireSerialIn = false;


void setup() {
    Serial.begin(9600);
    Serial1.end();
    Serial2.end();
    Serial3.end();
    
    // Mandatory ethernet pins
    // Disable DS card select.
    pinMode(4, OUTPUT);
    digitalWrite(4, HIGH);
    pinMode(10, OUTPUT);
    pinMode(53, OUTPUT);
    
    pinMode(fOptic, INPUT);
    pinMode(rOptic, INPUT);
    
    
    // Set up the pins for the motors
    pinMode(drawingLinacDir, OUTPUT);
    pinMode(drawingLinacEnable, OUTPUT);
    
    pinMode(verticalLinacDir, OUTPUT);
    pinMode(verticalLinacEnable, OUTPUT);
    
    pinMode(motorEnablePin, OUTPUT);
    pinMode(motorDirPin, OUTPUT);
    pinMode(pinA, INPUT);
    pinMode(pinB, INPUT);
  
    // Initialize all three of the motors.
    drawingLinac.init(drawingLinacDir, drawingLinacEnable, drawingLinacFeedback);
    verticalLinac.init(verticalLinacDir, verticalLinacEnable, verticalFeedback);
    motor.init(motorDirPin, motorEnablePin, pinA, pinB);
  
    // Take position samples and run them through the filter so our starting values are accurate
    for(int i = 0; i<100; i++)
    {
        drawingLinac.samplePosition();
        verticalLinac.samplePosition();
    }
  
    pinMode(fireSolenoid, OUTPUT);
    
    attachInterrupt(2, doPinA, CHANGE);
    attachInterrupt(3, doPinB, CHANGE);
    Ethernet.begin(mac, ip, gateway, subnet);
}

void loop()
{
    motorPos = motor.getPosition();
    verticalLinacPos = verticalLinac.getPosition();
    drawingLinacPos = drawingLinac.getPosition();
    checkEthernetInput();
    
    if ( xMovementRequested )
    {
        motor.moveTo( motorTarget );
    }
    else if (yMovementRequested)
    {
        verticalLinac.moveTo( verticalLinacTarget );
    }
    else if (zMovementRequested)
    {
        drawingLinac.moveTo( drawingLinacTarget );
    }
    
    digitalWrite(fireSolenoid, fireSerialIn);
}

void doPinA()
{
    motor.doPinA();
}

void doPinB()
{
    motor.doPinB();
}


//=========================================
void check_movement_time()
//=========================================
{
    if ( startMovementTime == 0 )
    {
        startMovementTime = millis();
    } 
    else if ( ( millis() - startMovementTime ) > 15000 )
    {
        eStopInterrupt();
    }
}

//=========================================
void eStopInterrupt()
//=========================================
{
    // Nothing should ever interrupt an eStop
    // noInterrupts();
    // Serial.println("eSTOP");
    // currentState = STATE_HALT;
    
    unsigned long currentTime = millis();
    unsigned long startWaitTime = millis();  
    do
    {
      currentTime = millis();
      // Manually disable the linacs and motor by pin.
      digitalWrite(verticalLinacEnable, MOTOR_DISABLED);
      digitalWrite(drawingLinacEnable, MOTOR_DISABLED);
      digitalWrite(motorEnablePin, MOTOR_DISABLED);
      digitalWrite(fireSolenoid, LOW);
    } while( ( currentTime - startWaitTime ) < 2000 );
    
    drawingLinac.setMovementComplete(false);
    while( !drawingLinac.isMovementComplete() )
    {
        drawingLinac.moveTo(zRetractedPosition);
    }
    
    while(true)
    {
        // Allow nothing to happen until hardware reset.
        noInterrupts();
    }
}

void checkEthernetInput()
{
    if(!hasConnected)
    {
        tcpClient = server.available();
        if(tcpClient)
        {
            Serial.println("Client connected.");
            hasConnected = true;
        }
    }
    
    if(tcpClient && hasConnected && tcpClient.available())
    {
        char c = tcpClient.read();
        // Serial.println(c);
        if(c=='e' || c=='E')
        {
            eStopInterrupt();
        }
        else if(c == '~')
        {
            parseEthernetBuffer();
            clearEthernetBuffer();
        }
        else if (c != '\n')
        {
            buf[bufferSize++] = c;
        }
    }
    if (!tcpClient.connected())
    {
        hasConnected=false;
    }
}

void parseEthernetBuffer()
{
  if (bufferSize > 0)
  {
      char first = (char) buf[0];
      switch(first)
      {
          case 'e':
          case 'E':
          {
              eStopInterrupt();
              break;
          }
          case 'f':
          case 'F':
          {
              if ( digitalRead(fOptic) == LOW && digitalRead(rOptic) == LOW)
              {
                  fireSerialIn = true;
              }
          }
          case'g':
          case 'G':
          {
              String ret = String(digitalRead(fOptic));
              ret += "_" + String(digitalRead(rOptic));
              ret += "_" + String(!(xMovementCompleted && yMovementCompleted && zMovementCompleted));
              ret += "_" + String(motor.getPosition());
              ret += "_" + String(verticalLinac.getPosition());
              tcpClient.print(ret);
              break;
          }
          case 'x':
          case 'X':
          {
              char* substr = &buf[1];
              int requestedTarget = atoi(substr);
              if ( requestedTarget > -4096 && requestedTarget < 4096 )
              {
                  motorTarget = requestedTarget;
                  xMovementRequested = true;
                  xMovementCompleted = false;
                  motor.setMovementComplete(false);
              }
              else
              {
                  tcpClient.write("ERR~");
              }
              break;
          }
          case 'y':
          case 'Y':
          {
              char* substr = &buf[1];
              int requestedTarget = atoi(substr);
              if ( requestedTarget >= 0 && requestedTarget < 4096 )
              {
                  verticalLinacTarget = requestedTarget;
                  yMovementRequested = true;
                  yMovementCompleted = false;
                  verticalLinac.setMovementComplete(false);
              }
              else
              {
                  tcpClient.write("ERR~");
              }
              break;
          }
          case 'z':
          case 'Z':
          {
              char* substr = &buf[1];
              int requestedTarget = atoi(substr);
              if ( requestedTarget >= 0 && requestedTarget < 4096 )
              {
              
                  if (digitalRead(fOptic) != LOW)
                  {
                      tcpClient.print("ERR~");
                      // Serial.println("fOptic should be LOW");
                  }
                  else if (digitalRead(rOptic) != HIGH )
                  {
                      tcpClient.print("ERR~");
                      // Serial.println("rOptic should be HIGH");
                  }
                  else
                  {
                      drawingLinacTarget = requestedTarget;
                      zMovementRequested = true;
                      zMovementCompleted = false;
                      drawingLinac.setMovementComplete(false);
                  }
                  break;
              }
          }
          default:
          {
              // Unrecognized command
              // Serial.print("ERR~~~~~");
          }
      }
  }
}

void clearEthernetBuffer()
{
    for(int i = 0; i < bufferSize; i++)
    {
        buf[i] = 0;
    }
    bufferSize = 0;
}
