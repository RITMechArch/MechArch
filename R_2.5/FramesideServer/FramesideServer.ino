#include <LinearActuator.h>

#include <RotaryEncoderReader.h>
#include <GearMotor.h>

#include <SPI.h>
#include <Ethernet.h>

// network configuration.  gateway and subnet are optional.
// the media access control (ethernet hardware) address for the shield:
byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };  
//the IP address for the shield:
byte ip[] = { 192, 168, 1, 177 };    
// the router's gateway address:
byte gateway[] = { 192, 168, 1, 1 };
// the subnet:
byte subnet[] = { 255, 255, 0, 0 };

char buf[128];
int bufSize = 0;

// -------------- PINS ---------------
// DO NOT USE DIGITAL PIN 5
// Digital Pin 5 has been found to be defective on the arduino 
// being used for this project. To avoid the cost of buying 
// another arduino, we are avoiding the pin.

const int drawingLinacFeedback = 2; // ANALOG 2
const int drawingLinacEnable   = 3;
const int drawingLinacDir      = 30;

const int verticalLinacFeedback = 5; // ANALOG 5
const int verticalLinacEnable  = 6;
const int verticalLinacDir     = 8;

const int motorEnablePin  = 9;
const int motorDirPin     = 12;
const int pinA            = 21;
const int pinB            = 20;

const int fireSolenoid    = 38;

//------------ Motors ------------
LinearActuator drawingLinac = LinearActuator();
LinearActuator verticalLinac = LinearActuator();
GearMotor motor = GearMotor();

long drawingLinacPos = 0;
long verticalLinacPos = 0;
long motorPos = 0;

int motorTarget = 0;
int drawingLinacTarget = 400;
int verticalLinacTarget = 400;

const int zDrawnPosition = 400;
const int zRetractedPosition = 3500;

unsigned int fireOpen = LOW;

long lastReportTime = -1;

// telnet defaults to port 23
EthernetServer server = EthernetServer(23);
// if an incoming client connects, there will be bytes available to read:
EthernetClient client;

boolean hasConnected = false;

// TODO Remove these variables and figure out a better moovement scheme
boolean xMoveRequested = false;
boolean yMoveRequested = false;
boolean zMoveRequested = false;

void setup()
{
  Serial.begin(115200);//begin(115200);
  Serial1.end();
  Serial2.end();
  Serial3.end();
  
  // Serial.begin(9600);
  // Mandatory ethernet pins
  // Disable DS card select.
  pinMode(4, OUTPUT);
  digitalWrite(4, HIGH);
  pinMode(10, OUTPUT);
  pinMode(53, OUTPUT);
  
  // Set up the pins for the motors
  pinMode(drawingLinacDir, OUTPUT);
  pinMode(drawingLinacEnable, OUTPUT);
  pinMode(drawingLinacFeedback, INPUT);

  pinMode(verticalLinacDir, OUTPUT);
  pinMode(verticalLinacEnable, OUTPUT);
  pinMode(verticalLinacFeedback, INPUT);

  pinMode(motorEnablePin, OUTPUT);
  pinMode(motorDirPin, OUTPUT);
  pinMode(pinA, INPUT);
  pinMode(pinB, INPUT);
  
  pinMode(fireSolenoid, OUTPUT);
  
  // Initialize all three of the motors.
  drawingLinac.init(drawingLinacDir, drawingLinacEnable, drawingLinacFeedback);
  verticalLinac.init(verticalLinacDir, verticalLinacEnable, verticalLinacFeedback);
  motor.init(motorDirPin, motorEnablePin, pinA, pinB);
  
  // Take position samples and run them through the filter so our starting values are accurate
  for(int i = 0; i<100; i++)
  {
      drawingLinac.samplePosition();
      verticalLinac.samplePosition();
  }

  attachInterrupt(2, doPinA, CHANGE);
  attachInterrupt(3, doPinB, CHANGE);
  
  digitalWrite( motorEnablePin, LOW );
  
  // initialize the ethernet device
  Ethernet.begin(mac, ip, gateway, subnet);
  Serial.print( "Listening from IP " );
  Serial.println( Ethernet.localIP() );

  // start listening for clients
  server.begin();
}

void loop()
{
    verticalLinac.samplePosition();
    drawingLinac.samplePosition();
    
    motorPos = motor.getPosition();
    verticalLinacPos = verticalLinac.getPosition();
    drawingLinacPos = drawingLinac.getPosition();
  
  //   digitalWrite( fireSolenoid, fireOpen );
  if ( !hasConnected )
  {
    client = server.available();
    if(client)
    {
      Serial.println("Client connected.");
      hasConnected = true;
    }
  }
  if (client && hasConnected && client.available() ) {
    // read bytes from the incoming client and write them back
    // to any clients connected to the server:
    char c = (char) client.read();
    buf[bufSize++] = c;
    if ( c == '\n')
    {
      processMessage(buf);
      memset( buf, 0, sizeof buf );
      bufSize = 0;
    }
  }
  if ( !client.connected() )
  {
    hasConnected = false;
  }
  // */
  // digitalWrite(fireSolenoid, HIGH);
  digitalWrite(fireSolenoid, fireOpen);
  
  // TODO Remove checks and figure out a better movement scheme
  if ( xMoveRequested )
  {
    if ( lastReportTime < 0 )
    {
      lastReportTime = millis();
    }
    if ( (millis() - lastReportTime) > 2000 )
    {
      Serial.print( "Motor pos: ");
      Serial.println( motorPos );
      Serial.print("Motor target: ");
      Serial.println(motorTarget);
      lastReportTime = millis();
    }
    motor.moveTo( motorTarget );
    if ( motor.isMovementComplete() )
    {
      xMoveRequested = false;
    }
  }

  if ( yMoveRequested )
  {
    verticalLinac.moveTo( verticalLinacTarget );
    if ( abs(verticalLinac.getPosition() - verticalLinacTarget) < 3 )
    {
      yMoveRequested = false;
    }
  }

  if ( zMoveRequested )
  {
    drawingLinac.moveTo( drawingLinacTarget );
    if ( abs(drawingLinac.getPosition() - drawingLinacTarget) < 3 )
    {
      zMoveRequested = false;
    }
  }
}

void processMessage( char buf[] )
{
  //Serial.print( "Processing: " );
  //Serial.print(buf);
  switch(buf[0])
  {
    case 'D':
      Serial.println("DRAW");
      draw();
      break;
    case 'E':
      Serial.println("ESTOP");
      eStop();
      break;
    case 'F':
      Serial.println("FIRE");
      fire();
      break;
    case 'X':
      Serial.println("X");
      xMoveRequested = true;
      moveToX();
      break;
    case 'Y':
      Serial.println("Y");
      yMoveRequested = true;
      moveToY();
      break;
    case 'R':
      Serial.println("RETRACT");
      retract();
      break;
    default:
      Serial.println("IDFK");
      unrecognized();
      break;
  }
}

void draw()
{
  zMoveRequested = true;
  drawingLinacTarget = zDrawnPosition;
}

void eStop()
{
  //Serial.println("eStop");
}

void fire()
{
  Serial.println( "Firing" );
  if ( fireOpen == HIGH )
  {
    fireOpen = LOW;
  }
  else
  {
    fireOpen = HIGH;
  }
}

void moveToX()
{
  //Serial.println( "Moving X");
  int target = atoi( &buf[1] );
  motor.setMovementComplete( false );
  motorTarget = target;
}

void moveToY()
{
  //Serial.println( "Moving Y" );
  verticalLinacTarget = atoi( &buf[1] );
//  if ( target > 400 && target < 3600 )
//  {
//    verticalLinac.moveTo( target );
//  }
}

void retract()
{
  zMoveRequested = true;
  drawingLinacTarget = zRetractedPosition;
}

void unrecognized()
{
  //Serial.println("Unrecognized command.");
}

void doPinA()
{
  motor.doPinA();
}

void doPinB()
{
  motor.doPinB();
}
