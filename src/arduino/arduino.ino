#define DEBUG

#ifdef DEBUG
#include <WProgram.h>
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
#define LCDRegSelect        (37)
#define LCDEnable           (39)
#define LCDData4            (41)
#define LCDData5            (43)
#define LCDData6            (45)
#define LCDData7            (47)
LiquidCrystal lcd( LCDRegSelect, LCDEnable, LCDData4, LCDData5, LCDData6, LCDData7 );

//-------- INPUT PIN settings -------------

#define eStopRemoteIn       (18)
#define eStopMainIn         (19)

#define armingChain         (40)

#define laptopModeIn        (42)

#define drawIn              (44)
#define fireIn              (46)

#define fBump               (20)
#define rBump               (21)

#define fOptic              (24)
#define rOptic              (26)

#define resetInput          (48)

//--------- OUTPUT PIN settings -----------

#define motorEnable         (34)
#define motorDirection      (36)
#define fireSolenoid        (38)

//-------- STATE const declarations -------------

int currentState;
#define STATE_idle          (1)
#define STATE_ready         (2)
#define STATE_drawing       (3)
#define STATE_drawn         (4)
#define STATE_firing        (5)
#define STATE_fired         (6)
#define STATE_HALT          (7)

#define STATE_retracting    (8)

//-------- Motor Controller const declarations -------------

unsigned long startMovementTime = 0;
#define MOTOR_ENABLED       (0)
#define MOTOR_DISABLED      (1)
#define DIRECTION_BACK      (0)
#define DIRECTION_FWD       (1)


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

    pinMode(fBump, INPUT);
    pinMode(rBump, INPUT);
    pinMode(fOptic, INPUT);
    pinMode(rOptic, INPUT);

    pinMode(motorEnable, OUTPUT);
    pinMode(motorDirection, OUTPUT);
    pinMode(fireSolenoid, OUTPUT);

    attachInterrupt(2, fBumpInterrupt, RISING);
    attachInterrupt(3, rBumpInterrupt, RISING);
    attachInterrupt(4, eStopInterrupt, LOW);
    attachInterrupt(5, eStopInterrupt, LOW);

    currentState = STATE_idle;
    lcd.begin( 20, 4 );
}

//=========================================
void loop()
//=========================================
{
    //LCD Setup
    Serial.print("Drawn: ");
    Serial.println(digitalRead(rBump));
    Serial.print("Retract: ");
    Serial.println(digitalRead(fBump));
    
    lcd.clear();
    lcd.print( "Status: " );
    
    //Set the second line on the LCD
    lcd.setCursor( 0, 1 );
    if ( digitalRead(fOptic) == HIGH && digitalRead(rOptic) == HIGH )
    {
        lcd.print( "SAFE  " );
    }
    else
    {
        lcd.print( "LOADED" );
    }
    
    //Set the third line on the LCD
    lcd.setCursor( 0, 2 );
    if ( digitalRead(fOptic) == LOW && digitalRead(rOptic) == HIGH )
    {
        lcd.print("Arrow Front");
    }
    else if ( digitalRead(fOptic) == LOW && digitalRead(rOptic) == LOW )
    {
        lcd.print("Arrow Drawn");
    }
    else if ( digitalRead(fOptic) == HIGH && digitalRead(rOptic) == LOW )
    {
        lcd.print("ERROR: CHCK F SENSOR");
    }
    else if ( digitalRead(rOptic) == LOW && digitalRead(fBump) == HIGH )
    {
        lcd.print("ERROR: CHCK R SENSOR");
    }
    else if ( digitalRead(fOptic) == HIGH && digitalRead(rOptic) == HIGH )
    {
        lcd.print("           ");
    }
    else
    {
      lcd.print("ERROR      ");
    }
    //END LCD setup
       
       
    switch(currentState)
    {
        case STATE_HALT:
			DEBUG_PRINT("State: STATE_HALT");
            set_halt_outputs();
            test_halt_transitions();
            return;
        case STATE_idle:
            lcd.setCursor( 8, 0 );
            lcd.print( "IDLE      " );
            		DEBUG_PRINT("State: STATE_idle");
            set_idle_outputs();
            test_idle_transitions();
            break;
        case STATE_ready:
            lcd.setCursor( 8, 0 );
            lcd.print( "Ready     ");
			DEBUG_PRINT("State: STATE_ready");
            set_ready_outputs();
            
            if ( digitalRead(fOptic) == HIGH )
            {
                lcd.setCursor(0, 3);
                lcd.print("ERROR: UNLOADED");
            }
            else if ( fBump == LOW || rBump == HIGH )
            {
                lcd.setCursor(0, 3);
                lcd.print("ERROR: BOW NOT FWD");
            }
            
            test_ready_transitions();
            break;
        case STATE_drawing:
            check_movement_time();
        
            lcd.setCursor(8, 0);
            lcd.print( "Drawing   ");
			DEBUG_PRINT("State: STATE_drawing");
            set_drawing_outputs();
            test_drawing_transitions();
            break;
        case STATE_drawn:
            lcd.setCursor(8, 0);
            lcd.print( "Drawn     ");
			DEBUG_PRINT("State: STATE_drawn");
            set_drawn_outputs();
            
            if ( digitalRead(rBump) == LOW ) 
            {
                lcd.setCursor(0, 3);
                lcd.print("ERROR: INCOMPLT DRAW");
            } 
            else if ( (digitalRead(rOptic) == HIGH ) && ( digitalRead(fOptic) == LOW ) )
            {
                lcd.setCursor(0, 3);
                lcd.print("ERROR: ARROW NOT BCK");
            }
            
            test_drawn_transitions();
            break;
        case STATE_firing:
            lcd.setCursor( 8, 0 );
            lcd.print( "Firing    ");
			DEBUG_PRINT("State: STATE_firing");
            set_firing_outputs();
            test_firing_transitions();
            break;
        case STATE_fired:
            // Fired causes the machine to retract, so make sure the movement doesn't take too long
            check_movement_time();
            
            lcd.setCursor( 8, 0 );
            lcd.print( "Fired     ");
			DEBUG_PRINT("State: STATE_fired");
            set_fired_outputs();
            test_fired_transitions();
            break;
        case STATE_retracting:
            check_movement_time();
        
            lcd.setCursor( 8, 0 );
            lcd.print( "Retracting");
			DEBUG_PRINT("State: STATE_retracting");
            set_retracting_outputs();
            test_retracting_transitions();
            break;
        default:
            lcd.setCursor( 8, 0 );
            lcd.print( "Invalid   ");
			DEBUG_PRINT("State: Invalid state!");
            break;
    }
	
        #ifdef DEBUG
	  Serial.print("Front Optic: ");
          Serial.println(digitalRead(fOptic));
	  Serial.print("Rear Optic: ");
          Serial.println(digitalRead(rOptic));
        #endif
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
void set_ready_outputs()
//=========================================
{
    digitalWrite(motorEnable, MOTOR_DISABLED);
    digitalWrite(motorDirection, DIRECTION_FWD);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_drawing_outputs()
//=========================================
{
    // Always set direction BEFORE enabling the motor (electrical constraint)
    digitalWrite(motorDirection, DIRECTION_BACK);
    digitalWrite(motorEnable, MOTOR_ENABLED);
    digitalWrite(fireSolenoid, LOW);
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
    // Always set direction BEFORE enabling the motor (electrical constraint)
    digitalWrite(motorDirection, DIRECTION_FWD);
    digitalWrite(motorEnable, MOTOR_ENABLED);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_retracting_outputs()
//=========================================
{
    // Always set direction BEFORE enabling the motor (electrical constraint)
    digitalWrite(motorDirection, DIRECTION_FWD);
    digitalWrite(motorEnable, MOTOR_ENABLED);
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

}

//=========================================
void test_idle_transitions()
//=========================================
{
    if ( digitalRead(armingChain) == HIGH)
    {
        currentState = STATE_ready;
    }
}

//=========================================
void test_ready_transitions()
//=========================================
{
    if ( digitalRead(armingChain) == HIGH &&
          digitalRead(drawIn) == HIGH &&
          digitalRead(fBump) == HIGH &&
          digitalRead(rBump) == LOW &&
       	  digitalRead(fOptic) == LOW &&
          digitalRead(rOptic) == HIGH )
    {
		currentState = STATE_drawing;
    }
    else if ( digitalRead(armingChain) == LOW )
    {
        currentState = STATE_idle;
    }
}

//=========================================
void test_drawing_transitions()
//=========================================
{
     if ( digitalRead(fBump) == LOW &&
           digitalRead(rBump) == HIGH)
     {
         startMovementTime = 0;
         currentState = STATE_drawn;
     }
}

//=========================================
void test_drawn_transitions()
//=========================================
{
    if ( digitalRead(armingChain) == HIGH )
    {
        if( digitalRead(fireIn) == HIGH &&
            digitalRead(fBump) == LOW &&
            digitalRead(rBump) == HIGH &&
            digitalRead(fOptic) == LOW &&
            digitalRead(rOptic) == LOW )
        {
            currentState = STATE_firing;
        }
        else if( digitalRead(resetInput) == HIGH )
        {
            currentState = STATE_retracting;
        }
    }
}

//=========================================
void test_firing_transitions()
//=========================================
{
    if (digitalRead(fBump) == LOW &&
        digitalRead(rBump) == HIGH &&
        digitalRead(fOptic) == HIGH &&
        digitalRead(rOptic) == HIGH )
    {
        currentState = STATE_fired;
    }
}

//=========================================
void test_fired_transitions()
//=========================================
{
    if ( digitalRead(fBump) == HIGH &&
         digitalRead(rBump) == LOW )
    {
        startMovementTime = 0;
        currentState = STATE_idle;
    }
}

//=========================================
void test_retracting_transitions()
//=========================================
{
    if ( digitalRead(fBump) == HIGH &&
         digitalRead(rBump) == LOW)
    {
        startMovementTime = 0;
        currentState = STATE_ready;
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
    
    double d;
    for (d = 1.0; sqrt(d) < 121.1; d = d + 1)
    {
        digitalWrite(motorEnable, MOTOR_DISABLED);
    	digitalWrite(motorDirection, DIRECTION_FWD);
    	digitalWrite(fireSolenoid, LOW);
    }
  
    while(true)
    {
        if(digitalRead(fBump) == LOW)
        {
            digitalWrite(motorDirection, DIRECTION_FWD);
            digitalWrite(motorEnable, MOTOR_ENABLED);
            digitalWrite(fireSolenoid, LOW);
        }
        else 
        {
            digitalWrite(motorEnable, MOTOR_DISABLED);
            digitalWrite(motorDirection, DIRECTION_FWD);
            digitalWrite(fireSolenoid, LOW);
        }
    }
}

//=========================================
void fBumpInterrupt()
//=========================================
{
    digitalWrite(motorEnable, MOTOR_DISABLED);
}

//=========================================
void rBumpInterrupt()
//=========================================
{
    digitalWrite(motorEnable, MOTOR_DISABLED);
}

