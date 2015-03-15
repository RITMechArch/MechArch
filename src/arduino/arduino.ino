#define DEBUG

#ifdef DEBUG
#include <Arduino.h>
#define DEBUG_PRINT(str)    \
    Serial.print(millis());     \
    Serial.print(": ");    \
    Serial.print(__PRETTY_FUNCTION__); \
    Serial.print(':');      \
    Serial.print(__LINE__);     \
    Serial.print(' ');      \
    Serial.println(str);
#else
#define DEBUG_PRINT(str)
#endif
#include <LiquidCrystal.h>
//-------- LCD Output Pins ---------------
const int LCDRegSelect      = 37;
const int LCDEnable         = 39;
const int LCDData4          = 41;
const int LCDData5          = 43;
const int LCDData6          = 45;
const int LCDData7          = 47;
LiquidCrystal lcd( LCDRegSelect, LCDEnable, LCDData4, LCDData5, LCDData6, LCDData7 );

//-------- INPUT PIN settings -------------

const int eStopRemoteIn     = 18;
const int eStopMainIn       = 19;

const int armingChain       = 40;

const int laptopModeIn      = 42;

const int drawIn            = 44;
const int fireIn            = 46;

const int fOptic            = 24;
const int rOptic            = 26;

const int resetInput        = 48;

//--------- OUTPUT PIN settings -----------

const int motorEnable       = 34;
const int motorDirection    = 36;
const int fireSolenoid      = 38;

//-------- STATE const declarations -------------

int currentState;
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

    pinMode(drawIn, INPUT);
    pinMode(fireIn, INPUT);

    pinMode(fOptic, INPUT);
    pinMode(rOptic, INPUT);

    pinMode(motorEnable, OUTPUT);
    pinMode(motorDirection, OUTPUT);
    pinMode(fireSolenoid, OUTPUT);

    //attachInterrupt(4, eStopInterrupt, LOW);
    //attachInterrupt(5, eStopInterrupt, LOW);

    currentState = STATE_IDLE;
    lcd.begin( 20, 4 );
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
			DEBUG_PRINT("State: STATE_HALT");
            set_halt_outputs();
            test_halt_transitions();
            return;
        case STATE_IDLE:
            lcd.setCursor( 8, 0 );
            lcd.print( "IDLE      " );
            		DEBUG_PRINT("State: STATE_idle");
            set_idle_outputs();
            test_idle_transitions();
            break;
        case STATE_ARMED:
            lcd.setCursor( 8, 0 );
            lcd.print( "Ready     ");
			DEBUG_PRINT("State: STATE_ready");
            set_armed_outputs();
            test_armed_transitions();
            break;
        case STATE_AIMING:
            set_aiming_outputs();
            test_aiming_transitions();
            break;
        case STATE_DRAWING:
            check_movement_time();
        
            lcd.setCursor(8, 0);
            lcd.print( "Drawing   ");
			DEBUG_PRINT("State: STATE_drawing");
            set_drawing_outputs();
            test_drawing_transitions();
            break;
        case STATE_DRAWN:
            lcd.setCursor(8, 0);
            lcd.print( "Drawn     ");
			DEBUG_PRINT("State: STATE_drawn");
            set_drawn_outputs();
            
            test_drawn_transitions();
            break;
        case STATE_RETRACTING:
            check_movement_time();
        
            lcd.setCursor( 8, 0 );
            lcd.print( "Retracting");
			DEBUG_PRINT("State: STATE_retracting");
            set_retracting_outputs();
            test_retracting_transitions();
            break;
        case STATE_FIRING:
            lcd.setCursor( 8, 0 );
            lcd.print( "Firing    ");
			DEBUG_PRINT("State: STATE_firing");
            set_firing_outputs();
            test_firing_transitions();
            break;
        case STATE_FIRED:
            // Fired causes the machine to retract, so make sure the movement doesn't take too long
            check_movement_time();
            
            lcd.setCursor( 8, 0 );
            lcd.print( "Fired     ");
			DEBUG_PRINT("State: STATE_fired");
            set_fired_outputs();
            test_fired_transitions();
            break;
        default:
            lcd.setCursor( 8, 0 );
            lcd.print( "Invalid   ");
			DEBUG_PRINT("State: Invalid state!");
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
    digitalWrite(motorEnable, MOTOR_DISABLED);
    digitalWrite(motorDirection, DIRECTION_FWD);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_idle_outputs()
//=========================================
{
    digitalWrite(motorEnable, MOTOR_DISABLED);
    digitalWrite(motorDirection, DIRECTION_FWD);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_armed_outputs()
//=========================================
{
    digitalWrite(motorEnable, MOTOR_DISABLED);
    digitalWrite(motorDirection, DIRECTION_FWD);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_aiming_outputs()
//=========================================
{


}


//=========================================
void set_drawing_outputs()
//=========================================
{


}

//=========================================
void set_drawn_outputs()
//=========================================
{
    // If disabling the motor, do so before setting direction
    digitalWrite(motorEnable, MOTOR_DISABLED);
    digitalWrite(motorDirection, DIRECTION_FWD);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_retracting_outputs()
//=========================================
{

}

//=========================================
void set_firing_outputs()
//=========================================
{
    // If disabling the motor, do so before setting direction
    digitalWrite(motorEnable, MOTOR_DISABLED);
    digitalWrite(motorDirection, DIRECTION_FWD);
    digitalWrite(fireSolenoid, HIGH);
}

//=========================================
void set_fired_outputs()
//=========================================
{

 
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

}

//=========================================
void test_idle_transitions()
//=========================================
{
    if ( digitalRead(armingChain) == HIGH)
    {
        currentState = STATE_ARMED;
    }
}

//=========================================
void test_armed_transitions()
//=========================================
{
    if ( digitalRead(armingChain) == HIGH &&
          digitalRead(drawIn) == HIGH )
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

}

//=========================================
void test_drawing_transitions()
//=========================================
{

}

//=========================================
void test_drawn_transitions()
//=========================================
{
    if ( digitalRead(armingChain) == HIGH )
    {
        if( digitalRead(fireIn) == HIGH  )

        {
            currentState = STATE_FIRING;        
            startMovementTime = millis();
        }
        else if( digitalRead(resetInput) == HIGH )
        {
            currentState = STATE_RETRACTING;
        }
    }
}

//=========================================
void test_retracting_transitions()
//=========================================
{

}

//=========================================
void test_firing_transitions()
//=========================================
{
    
}

//=========================================
void test_fired_transitions()
//=========================================
{
   
}

//=========================================
void check_movement_time()
//=========================================
{
    if ( startMovementTime == 0 )
    {
        startMovementTime = millis();
    } 
    else
    {
        unsigned long currentTime = millis();
        if ( ( currentTime - startMovementTime ) > 11000 )
        {
            eStopInterrupt();
        }
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
    lcd.setCursor(0,0);
    lcd.print("--------------------");
    lcd.setCursor(0,1);
    lcd.print("---EMERGENCY HALT---");
    lcd.setCursor(0,2);
    lcd.print("--------------------");
    lcd.setCursor(0,3);
    lcd.print("RESET H/W TO PROCEED");
    
    unsigned long currentTime = millis();
    unsigned long startWaitTime = millis();  
    do
    {
      currentTime = millis();
      digitalWrite(motorEnable, MOTOR_DISABLED);
      digitalWrite(fireSolenoid, LOW);
    } while( ( currentTime - startWaitTime ) < 1000 );
   
    while(true)
    {
        
    }
}
