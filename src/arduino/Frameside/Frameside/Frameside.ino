#include <LinearActuator.h>
#include <GearMotor.h>

const int drawingLinacFeedback = 2;
const int drawingLinacEnable   = 3;
const int drawingLinacDir      = 4;

const int verticalFeedback    = 5;
const int verticalLinacEnable = 6;
const int verticalLinacDir    = 8;

const int motorEnablePin  = 10;
const int motorDirPin     = 12;
const int pinA            = 21;
const int pinB            = 20;

const int fOptic          = 30;
const int rOptic          = 32;

const int fireSolenoid    = 38;

//-------- STATE const declarations -------------
const int STATE_IDLE        = 1;
const int STATE_ARMED       = 2;
const int STATE_AIMING      = 3;
const int STATE_DRAWING     = 4;
const int STATE_DRAWN       = 5;
const int STATE_RETRACTING  = 6;
const int STATE_FIRING      = 7;
const int STATE_FIRED       = 8;
const int STATE_HALT        = 9;
String stateNames[10] = {"STATE_IDLE", "STATE_ARMED", "STATE_AIMING", "STATE_DRAWING", "STATE_DRAWN", "STATE_RETRACTING", "STATE_FIRING", "STATE_FIRED", "STATE_HALT"};

int currentState = STATE_IDLE;



const int MOTOR_DISABLED = 1;



int startMovementTime = 0;
int fireDelay = -1;

LinearActuator drawingLinac = LinearActuator();
LinearActuator verticalLinac = LinearActuator();
GearMotor motor = GearMotor();

int drawingLinacPos = 0;
int verticalLinacPos = 0;
int motorPos = 0;

int motorTarget = 0;
int drawingLinacTarget = 400;
int verticalLinacTarget = 400;


// Serial booleans, set when valid commands are read from the Serial connection.

boolean armingChainSerialIn = false;
boolean drawSerialIn = false;
boolean retractSerialIn = false;
boolean fireSerialIn = false;

boolean movementRequested = false;
boolean xMovementCompleted = true;
boolean yMovementCompleted = true;
boolean zMovementCompleted = true;

const long zDrawnPosition = 400;
const long zRetractedPosition = 3600;

void setup() {
  Serial.begin(115200);
  Serial1.end();
  Serial2.end();
  Serial3.end();
  
  
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
}

void loop() { 
    motorPos = motor.getPosition();
    verticalLinacPos = verticalLinac.getPosition();
    drawingLinacPos = drawingLinac.getPosition();
  
    switch(currentState)
    {
        case STATE_HALT:
            set_halt_outputs();
            test_halt_transitions();
            return;
        case STATE_IDLE:
            set_idle_outputs();
            test_idle_transitions();
            break;
        case STATE_ARMED:
            set_armed_outputs();
            test_armed_transitions();
            break;
        case STATE_AIMING:
            // check_movement_time();
            set_aiming_outputs();
            test_aiming_transitions();
            break;
        case STATE_DRAWING:
            // check_movement_time();
            set_drawing_outputs();
            test_drawing_transitions();
            break;
        case STATE_DRAWN:
            set_drawn_outputs();
            test_drawn_transitions();
            break;
        case STATE_RETRACTING:
            // check_movement_time();        
            set_retracting_outputs();
            test_retracting_transitions();
            break;
        case STATE_FIRING:
            set_firing_outputs();
            test_firing_transitions();
            break;
        case STATE_FIRED:
            set_fired_outputs();
            test_fired_transitions();
            break;
        default:
            break;
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
    
    if(Serial.peek() == 'a')
    {
        Serial.read();
        armingChainSerialIn = 1-armingChainSerialIn;
    }
    
    int in2;
    if(Serial.peek() == 'x') {
      Serial.read();
      in2 = Serial.parseInt();
      motorTarget = in2;
      movementRequested = true;
      xMovementCompleted = false;
      motor.setMovementComplete(false);
      
      if(motorTarget != -1) {
        Serial.print("Motor Target position is ");
        Serial.println(motorTarget);
      }
    }
    
    int in4;
    if(Serial.peek() == 'y') {
      Serial.read();
      in4 = Serial.parseInt();
      verticalLinacTarget = in4;
      movementRequested = true;
      yMovementCompleted = false;
      verticalLinac.setMovementComplete(false);
      if(verticalLinacTarget != -1) {
          Serial.print("Target position is ");
          Serial.println(verticalLinacTarget);
      } 
    }
    
    if(Serial.peek() == 'd')
    {
        Serial.read();
        zMovementCompleted = false;
        drawingLinacTarget = zDrawnPosition; 
        drawingLinac.setMovementComplete(false);
        drawSerialIn = true;
    }
    
    if(Serial.peek() == 'f')
    {
        Serial.read();
        fireSerialIn = true;
    }
    
    if(Serial.peek() == 'r')
    {
        Serial.read();
        drawingLinacTarget = zRetractedPosition;
        zMovementCompleted = false;
        drawingLinac.setMovementComplete(false);
        retractSerialIn = true;
    }
    
    if(Serial.peek() == 'p')
    {
        Serial.read();
        Serial.println(stateNames[currentState-1]);
        
        Serial.println("Linac Z Position: ");
        Serial.println(drawingLinacPos);
        Serial.println("Linac Z target: ");
        Serial.println(drawingLinacTarget);
        Serial.println();
    
        Serial.println("Linac Y Position: ");
        Serial.println(verticalLinacPos);
        Serial.println("Linac Y target: ");
        Serial.println(verticalLinacTarget);
        Serial.println();
    
        Serial.println("Motor Position: ");
        Serial.println(motorPos);
        Serial.println("Motor target: ");
        Serial.println(motorTarget);
        Serial.println();
        Serial.println();
    }
    
    if(Serial.peek() == 'e')
    {
        Serial.read();
        eStopInterrupt();
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


//=========================================
//=========================================
// State Outputs
//=========================================
//=========================================

//=========================================
void set_halt_outputs()
//=========================================
{
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_idle_outputs()
//=========================================
{
    // Prevent the motors from moving by setting their targets to their current positions.
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_armed_outputs()
//=========================================
{
    // Prevent the motors from moving by setting their targets to their current positions.
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_aiming_outputs()
//=========================================
{
    // TODO: In Serial, set movementCompleted to false
   
    // Move to the vertical target position first.
    if ( !yMovementCompleted )
    {
        verticalLinac.moveTo(verticalLinacTarget);
        if( verticalLinac.isMovementComplete() )
        {
            movementRequested = false;
            yMovementCompleted = true;
            startMovementTime = 0;
        }
    }
    // Move to the horizontal target position when the vertical movement is done.
    else if ( !xMovementCompleted )
    {
        motor.moveTo(motorTarget);
        if( motor.isMovementComplete() )
        {
            movementRequested = false;
            xMovementCompleted = true;
            startMovementTime = 0;
        }
    }

    digitalWrite(fireSolenoid, LOW);
}


//=========================================
void set_drawing_outputs()
//=========================================
{
    // TODO get drawn amount from EEPROM, use it.
    if (!zMovementCompleted)
    {
        drawingLinac.moveTo(drawingLinacTarget);
        if ( drawingLinac.isMovementComplete() )
        {
            drawSerialIn = false;
            zMovementCompleted = true;
            startMovementTime = 0;
        }
    }
    
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_drawn_outputs()
//=========================================
{
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_retracting_outputs()
//=========================================
{
    // TODO get drawn amount from EEPROM, use it.
    if (!zMovementCompleted)
    {
        drawingLinac.moveTo(zRetractedPosition);
        if ( drawingLinac.isMovementComplete() )
        {
            retractSerialIn = false;
            zMovementCompleted = true;
            startMovementTime = 0;
        }
    }
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_firing_outputs()
//=========================================
{
    digitalWrite(fireSolenoid, HIGH);
}

//=========================================
void set_fired_outputs()
//=========================================
{
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
//=========================================
// Transition Tests
//=========================================
//=========================================

//=========================================
void test_halt_transitions()
//=========================================
{
    // Never transition from halt.
}

//=========================================
void test_idle_transitions()
//=========================================
{
    if (movementRequested)
    {
        currentState = STATE_AIMING;
    }
    else if ( armingChainSerialIn ) // digitalRead(armingChain) == HIGH )
    {
        currentState = STATE_ARMED;
    }
}

//=========================================
void test_armed_transitions()
//=========================================
{
    if (movementRequested)
    {
        currentState = STATE_AIMING;
    }
    else if ( armingChainSerialIn // digitalRead(armingChain) == HIGH 
         && drawSerialIn // && digitalRead(drawIn) == HIGH
         && digitalRead(fOptic) == LOW
         && digitalRead(rOptic) == HIGH )
    {
        currentState = STATE_DRAWING;
        startMovementTime = 0;
    }
    else if ( !armingChainSerialIn) // digitalRead(armingChain) == LOW )
    {
        currentState = STATE_IDLE;
    }
}

//=========================================
void test_aiming_transitions()
//=========================================
{
    // Done when movement stops.
    if ( xMovementCompleted && yMovementCompleted )
    {
        currentState = STATE_IDLE;
    }
}

//=========================================
void test_drawing_transitions()
//=========================================
{
    if( zMovementCompleted )
    {
        if ( digitalRead(fOptic) == LOW 
             && digitalRead(rOptic) == LOW )
        {
            currentState = STATE_DRAWN;
        }
        else
        {
            // The drawing linac reports being at the drawn position, 
            // but there is not an arrow present in the front and back.
            
            //eStopInterrupt();
        }
    }
    
}

//=========================================
void test_drawn_transitions()
//=========================================
{
    if ( digitalRead(fOptic) == LOW && digitalRead(rOptic) == LOW )
    {
        if ( armingChainSerialIn )// digitalRead(armingChain) == HIGH )
        {
            if( fireSerialIn) //digitalRead(fireIn) == HIGH */)
            {
                currentState = STATE_FIRING; 
                fireSerialIn = false;
            }
            else if( retractSerialIn /*digitalRead(retractInput) == HIGH*/ )
            {
                currentState = STATE_RETRACTING;
                retractSerialIn = false;
                drawingLinacTarget = zRetractedPosition;
            }
        }
        // Do nothing if the arming chain is inactive.
    }
    else
    {
        // The machine is in the drawn position, 
        // but an arrow isn't present in both the front and back.
        // eStopInterrupt();
    }
}

//=========================================
void test_retracting_transitions()
//=========================================
{
    if ( zMovementCompleted )
    {
        if (digitalRead(rOptic) == HIGH )
        {
            currentState = STATE_ARMED;
        }
        else 
        {
            // The drawing linac reports being at the retracted position, 
            // but there is something blocking the rear sensor.
            
            // eStopInterrupt();
        }
    }
}

//=========================================
void test_firing_transitions()
//=========================================
{
   
    if ( digitalRead(fOptic) == HIGH
         && digitalRead(rOptic) == HIGH )
    {
        currentState = STATE_FIRED;
    }
}

//=========================================
void test_fired_transitions()
//=========================================
{
    if ( fireDelay == -1 ) 
    {
        fireDelay = millis();
    }
    // Wait one second after firing to start retracting.
    else if ((millis() - fireDelay) >= 5000)
    {
        currentState = STATE_RETRACTING;
        zMovementCompleted = false;
        drawingLinac.setMovementComplete(false);
        fireDelay = -1;
    }
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
//=========================================
// Interrupt Handlers
//=========================================
//=========================================

//=========================================
void eStopInterrupt()
//=========================================
{
    // Nothing should ever interrupt an eStop
    //noInterrupts();
    Serial.println("eSTOP");
    currentState = STATE_HALT;
    
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

