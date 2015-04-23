#include <GearMotor.h>
#include <LinearActuator.h>

//-------- Controllers --------------------
LinearActuator verticalLinac = LinearActuator();
LinearActuator drawingLinac  = LinearActuator();
GearMotor horizontalMotor    = GearMotor();

//-------- INPUT PIN settings -------------

const int eStopRemoteIn     = 18;
const int eStopMainIn       = 19;

const int fOptic            = 30;
const int rOptic            = 32;

const int armingChain       = 40;

const int laptopModeIn      = 42;

/*  Preserve for control box operation?
const int drawIn            = 44;
const int fireIn            = 46;
const int retractInput      = 48;
*/


//--------- OUTPUT PIN settings -----------

const int drawingLinacFeedback  = 2;
const int drawingLinacEnable    = 3;
const int drawingLinacDir       = 4;

const int verticalLinacFeedback = 5;
const int verticalLinacEnable   = 6;
const int verticalLinacDir      = 8;

const int horizontalMotorEnable = 10;
const int horizontalMotorDir    = 12;

const int fireSolenoid      = 38;

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

//-------- Motor Controller const declarations -------------

unsigned long startMovementTime = 0;
const int MOTOR_ENABLED      = 0;
const int MOTOR_DISABLED     = 1;
const int DIRECTION_BACK     = 0;
const int DIRECTION_FWD      = 1;


// -------- Non-const globals variables --------------------
int currentState;
boolean movementRequested = false;
boolean xMovementCompleted = true;
boolean yMovementCompleted = true;
boolean zMovementCompleted = true;


long fireDelay = 0;
long xTarget = 0;
long yTarget = 0;
const long zDrawnPosition = 0;
const long zRetractedPosition = 4000;
boolean drawSerialIn = false;
boolean retractSerialIn = false;
boolean fireSerialIn = false;


//=========================================
//  Function Declarations
//=========================================

//=========================================
//=========================================
// Arduino methods
//=========================================
//=========================================

//=========================================
void setup()
//=========================================
{
    Serial.begin(9600);
    Serial1.end();
    Serial2.end();
    Serial3.end();

    pinMode(eStopRemoteIn, INPUT);
    pinMode(eStopMainIn, INPUT);

    pinMode(armingChain, INPUT);

    pinMode(laptopModeIn, INPUT);

/*
    pinMode(drawIn, INPUT);
    pinMode(fireIn, INPUT);
*/

    pinMode(fOptic, INPUT);
    pinMode(rOptic, INPUT);

    pinMode(drawingLinacFeedback, INPUT);
    pinMode(drawingLinacEnable, OUTPUT);
    pinMode(drawingLinacDir, OUTPUT);
    
    pinMode(verticalLinacFeedback, INPUT);
    pinMode(verticalLinacEnable, OUTPUT);
    pinMode(verticalLinacDir, OUTPUT);
    
    pinMode(horizontalMotorEnable, OUTPUT);
    pinMode(horizontalMotorDir, OUTPUT);
    
    pinMode(fireSolenoid, OUTPUT);

    //attachInterrupt(4, eStopInterrupt, LOW);
    //attachInterrupt(5, eStopInterrupt, LOW);

    currentState = STATE_IDLE;
}

//=========================================
void loop()
//=========================================
{
    if(digitalRead(eStopRemoteIn) == LOW || digitalRead(eStopMainIn) == LOW)
    {
      eStopInterrupt();
    }

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
            check_movement_time();
            set_aiming_outputs();
            test_aiming_transitions();
            break;
        case STATE_DRAWING:
            check_movement_time();
            set_drawing_outputs();
            test_drawing_transitions();
            break;
        case STATE_DRAWN:
            set_drawn_outputs();
            test_drawn_transitions();
            break;
        case STATE_RETRACTING:
            check_movement_time();        
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

//=========================================
//=========================================
// State Outputs
//=========================================
//=========================================

//=========================================
void set_halt_outputs()
//=========================================
{
    // Prevent the motors from moving by setting their targets to their current positions.
    drawingLinac.moveTo(drawingLinac.getPosition());
    verticalLinac.moveTo(verticalLinac.getPosition());
    horizontalMotor.moveTo(horizontalMotor.getPosition());
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_idle_outputs()
//=========================================
{
    // Prevent the motors from moving by setting their targets to their current positions.
    drawingLinac.moveTo(drawingLinac.getPosition());
    verticalLinac.moveTo(verticalLinac.getPosition());
    horizontalMotor.moveTo(horizontalMotor.getPosition());
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_armed_outputs()
//=========================================
{
    // Prevent the motors from moving by setting their targets to their current positions.
    drawingLinac.moveTo(drawingLinac.getPosition());
    verticalLinac.moveTo(verticalLinac.getPosition());
    horizontalMotor.moveTo(horizontalMotor.getPosition());
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
        verticalLinac.moveTo(yTarget);
        if( verticalLinac.isMovementComplete() )
        {
            yMovementCompleted = true;
            startMovementTime = 0;
        }
    }
    // Move to the horizontal target position when the vertical movement is done.
    else if ( !xMovementCompleted )
    {
        horizontalMotor.moveTo(xTarget);
        if( horizontalMotor.isMovementComplete() )
        {
            xMovementCompleted = true;
            startMovementTime = 0;
        }
    }

    // Prevent drawing drawing linac movement.
    drawingLinac.moveTo(horizontalMotor.getPosition());
    digitalWrite(fireSolenoid, LOW);
}


//=========================================
void set_drawing_outputs()
//=========================================
{
    // TODO get drawn amount from EEPROM, use it.
    if (!zMovementCompleted)
    {
        drawingLinac.moveTo(zDrawnPosition);
        if ( drawingLinac.isMovementComplete() )
        {
            zMovementCompleted = true;
            startMovementTime = 0;
        }
    }
    
    // Prevent vertical and horizontal movement
    verticalLinac.moveTo(verticalLinac.getPosition());
    horizontalMotor.moveTo(horizontalMotor.getPosition());
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_drawn_outputs()
//=========================================
{
    // Prevent the motors from moving by setting their targets to their current positions.
    drawingLinac.moveTo(drawingLinac.getPosition());
    verticalLinac.moveTo(verticalLinac.getPosition());
    horizontalMotor.moveTo(horizontalMotor.getPosition());
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
            zMovementCompleted = true;
            startMovementTime = 0;
        }
    }
    
    // Prevent vertical and horizontal movement
    verticalLinac.moveTo(verticalLinac.getPosition());
    horizontalMotor.moveTo(horizontalMotor.getPosition());
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_firing_outputs()
//=========================================
{
    // Prevent the motors from moving by setting their targets to their current positions.
    drawingLinac.moveTo(drawingLinac.getPosition());
    verticalLinac.moveTo(verticalLinac.getPosition());
    horizontalMotor.moveTo(horizontalMotor.getPosition());
    digitalWrite(fireSolenoid, HIGH);
}

//=========================================
void set_fired_outputs()
//=========================================
{
    // Prevent the motors from moving by setting their targets to their current positions.
    drawingLinac.moveTo(drawingLinac.getPosition());
    verticalLinac.moveTo(verticalLinac.getPosition());
    horizontalMotor.moveTo(horizontalMotor.getPosition());
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
    else if ( digitalRead(armingChain) == HIGH )
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
    else if ( digitalRead(armingChain) == HIGH 
         && drawSerialIn // && digitalRead(drawIn) == HIGH
         && digitalRead(fOptic) == LOW
         && digitalRead(rOptic) == HIGH )
    {
        currentState = STATE_DRAWING;
    }
    else if ( digitalRead(armingChain) == LOW )
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
            eStopInterrupt();
        }
    }
    
}

//=========================================
void test_drawn_transitions()
//=========================================
{
    if ( digitalRead(fOptic) == LOW && digitalRead(rOptic) == LOW )
    {
        if ( digitalRead(armingChain) == HIGH )
        {
            if( fireSerialIn /*digitalRead(fireIn) == HIGH */)
            {
                currentState = STATE_FIRING; 
                fireSerialIn = false;
            }
            else if( retractSerialIn /*digitalRead(retractInput) == HIGH*/ )
            {
                currentState = STATE_RETRACTING;
                retractSerialIn = false;
            }
        }
        // Do nothing if the arming chain is inactive.
    }
    else
    {
        // The machine is in the drawn position, 
        // but an arrow isn't present in both the front and back.
        eStopInterrupt();
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
            eStopInterrupt();
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
    if ( fireDelay == 0 ) 
    {
        fireDelay = millis();
    }
    // Wait one second after firing to start retracting.
    else if ((millis() - fireDelay) >= 1000)
    {
        currentState = STATE_RETRACTING;
        fireDelay = 0;
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
    else if ( ( millis() - startMovementTime ) > 11000 )
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
      digitalWrite(verticalLinacEnable, MOTOR_DISABLED);
      digitalWrite(horizontalMotorEnable, MOTOR_DISABLED);
      digitalWrite(fireSolenoid, LOW);
    } while( ( currentTime - startWaitTime ) < 1000 );
   
    while(true)
    {
        // Allow nothing to happen until hardware reset.
        noInterrupts();
    }
}

//=========================================
//=========================================
// Serial Communication
//=========================================
//=========================================

String getPaddedIntString(int i)
{
  String iStr = String(i);
  String ret = "";
  for(int i = 0; i < 4-iStr.length(); i++ )
  {
    ret += "0";
  }
  ret += iStr;
  return ret;
}
