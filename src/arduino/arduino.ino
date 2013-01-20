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

//-------- ANALOG Read Constants ----------
#define analogHighMin       (950)
#define analogLowMax        (200)

//-------- INPUT PIN settings -------------

#define eStopRemoteIn       (18)
#define eStopMainIn         (19)

#define armingChain         (40)

#define laptopModeIn        (42)

#define drawIn              (44)
#define fireIn              (46)

#define fBump               (20)
#define rBump               (21)

#define resetInput          (48)

//--------- OUTPUT PIN settings -----------

#define drawRelay           (34)
#define resetRelay          (36)
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

//-------- ANALOG PIN settings ------------

#define fOptic              (A10)
#define rOptic              (A9)

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

    pinMode(drawRelay, OUTPUT);
    pinMode(resetRelay, OUTPUT);
    pinMode(fireSolenoid, OUTPUT);

    attachInterrupt(2, fBumpInterrupt, RISING);
    attachInterrupt(3, rBumpInterrupt, RISING);
    attachInterrupt(4, eStopInterrupt, LOW);
    attachInterrupt(5, eStopInterrupt, LOW);

    currentState = STATE_idle;
}

//=========================================
void loop()
//=========================================
{
    switch(currentState)
    {
        case STATE_HALT:
			DEBUG_PRINT("State: STATE_HALT");
            set_halt_outputs();
            test_halt_transitions();
            return;
        case STATE_idle:
			DEBUG_PRINT("State: STATE_idle");
            set_idle_outputs();
            test_idle_transitions();
            break;
        case STATE_ready:
			DEBUG_PRINT("State: STATE_ready");
            set_ready_outputs();
            test_ready_transitions();
            break;
        case STATE_drawing:
			DEBUG_PRINT("State: STATE_drawing");
            set_drawing_outputs();
            test_drawing_transitions();
            break;
        case STATE_drawn:
			DEBUG_PRINT("State: STATE_drawn");
            set_drawn_outputs();
            test_drawn_transitions();
            break;
        case STATE_firing:
			DEBUG_PRINT("State: STATE_firing");
            set_firing_outputs();
            test_firing_transitions();
            break;
        case STATE_fired:
			DEBUG_PRINT("State: STATE_fired");
            set_fired_outputs();
            test_fired_transitions();
            break;
        case STATE_retracting:
			DEBUG_PRINT("State: STATE_retracting");
            set_retracting_outputs();
            test_retracting_transitions();
            break;
        default:
			DEBUG_PRINT("State: Invalid state!");
            break;
    }
	
        #ifdef DEBUG
	  Serial.print("Front Optic: ");
          Serial.println(analogRead(fOptic));
	  Serial.print("Rear Optic: ");
          Serial.println(analogRead(rOptic));
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
    digitalWrite(drawRelay, LOW);
    digitalWrite(resetRelay, LOW);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_idle_outputs()
//=========================================
{
    digitalWrite(drawRelay, LOW);
    digitalWrite(resetRelay, LOW);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_ready_outputs()
//=========================================
{
    digitalWrite(drawRelay, LOW);
    digitalWrite(resetRelay, LOW);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_drawing_outputs()
//=========================================
{
    digitalWrite(drawRelay, HIGH);
    digitalWrite(resetRelay, LOW);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_drawn_outputs()
//=========================================
{
    digitalWrite(drawRelay, LOW);
    digitalWrite(resetRelay, LOW);
    digitalWrite(fireSolenoid, LOW);
}

//=========================================
void set_firing_outputs()
//=========================================
{
    digitalWrite(drawRelay, LOW);
    digitalWrite(resetRelay, LOW);
    digitalWrite(fireSolenoid, HIGH);
}

//=========================================
void set_fired_outputs()
//=========================================
{
    if(digitalRead(rBump) == HIGH)
    {
        digitalWrite(drawRelay, LOW);
        digitalWrite(resetRelay, HIGH);
        digitalWrite(fireSolenoid, LOW);
    }
}

//=========================================
void set_retracting_outputs()
//=========================================
{
    digitalWrite(drawRelay, LOW);
    digitalWrite(resetRelay, HIGH);
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
       	  analogRead(fOptic) <= analogLowMax &&
          analogRead(rOptic) >= analogHighMin)
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
           digitalRead(rBump) == HIGH &&
           analogRead(fOptic) <= analogLowMax &&
           analogRead(rOptic) <= analogLowMax)
     {
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
            analogRead(fOptic) <= analogLowMax &&
            analogRead(rOptic) <= analogLowMax)
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
        analogRead(fOptic) >= analogHighMin &&
        analogRead(rOptic) >= analogHighMin)
    {
        currentState = STATE_fired;
    }
}

//=========================================
void test_fired_transitions()
//=========================================
{
    if ( digitalRead(fBump) == HIGH &&
         digitalRead(rBump) == LOW &&
         analogRead(fOptic) >= analogHighMin &&
         analogRead(rOptic) >= analogHighMin)
    {
        currentState = STATE_idle;
    }
}

//=========================================
void test_retracting_transitions()
//=========================================
{
    if ( digitalRead(fBump) == HIGH &&
         digitalRead(rBump) == LOW &&
         digitalRead(fOptic) <= analogLowMax &&
         digitalRead(rOptic) >= analogHighMin)
    {
        currentState = STATE_ready;
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
    
    double d;
    for (d = 1.0; sqrt(d) < 121.1; d = d + 1)
    {
    	digitalWrite(drawRelay, LOW);
    	digitalWrite(resetRelay, LOW);
    	digitalWrite(fireSolenoid, LOW);
    }
  
    while(true)
    {
        if(digitalRead(fBump) == LOW)
        {
            digitalWrite(drawRelay, LOW);
            digitalWrite(resetRelay, HIGH);
            digitalWrite(fireSolenoid, LOW);
        }
        else 
        {
            digitalWrite(drawRelay, LOW);
            digitalWrite(resetRelay, LOW);
            digitalWrite(fireSolenoid, LOW);
        }
    }
}

//=========================================
void fBumpInterrupt()
//=========================================
{
    digitalWrite(resetRelay, LOW);
}

//=========================================
void rBumpInterrupt()
//=========================================
{
    digitalWrite(drawRelay, LOW);
}

