//-------- INPUT PIN settings -------------

const int eStopRemoteIn  = 18;
const int eStopMainIn    = 19;

const int armingChain    = 40;

const int laptopModeIn   = 42;

const int drawIn         = 44;
const int fireIn         = 46;

const int fBump	      = 20;
const int rBump       = 21;

//--------- OUTPUT PIN settings -----------

const int drawRelay	   = 34;
const int resetRelay   = 36;
const int fireSolenoid   = 38;

//-------- STATE const declarations -------------

int currentState;
const int STATE_idle    = 1;
const int STATE_armed   = 2;
const int STATE_drawing = 3;
const int STATE_drawn   = 4;
const int STATE_firing  = 5;
const int STATE_fired   = 6;
const int STATE_HALT    = 7;

//-------- ANALOG PIN settings ------------

int fOptic = 8;
int rOptic = 9;

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
	attachInterrupt(4, eStopInterrupt, RISING);
	attachInterrupt(5, eStopInterrupt, RISING);

	currentState = STATE_idle;
}

//=========================================
void loop()
//=========================================
{
    switch(currentState)
    {
        case STATE_HALT:
            set_halt_outputs();
            test_halt_transitions();
            return;
        case STATE_idle:
            set_idle_outputs();
            test_idle_transitions();
            break;
        case STATE_armed:
            set_armed_outputs();
            test_armed_transitions();
            break;
        case STATE_drawing:
            set_drawing_outputs();
            test_drawing_transitions();
            break;
        case STATE_drawn:
            set_drawn_outputs();
            test_drawn_transitions();
            break;
        case STATE_firing:
            set_firing_outputs();
            test_firing_transitions();
            break;
        case STATE_fired:
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
void set_armed_outputs()
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
    if ( digitalRead(armingChain) == HIGH &&
         analogRead(fOptic) == HIGH )
    {
        currentState = STATE_armed;
    }
}

//=========================================
void test_armed_transitions()
//=========================================
{
    if ( digitalRead(armingChain) == HIGH &&
          analogRead(fOptic) == HIGH &&
          digitalRead(drawIn) == HIGH )
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
    if ( digitalRead(rBump) == HIGH )
    {
        currentState = STATE_drawn;
    }
}

//=========================================
void test_drawn_transitions()
//=========================================
{
    if ( digitalRead(armingChain) == HIGH &&
          analogRead(rOptic) == HIGH &&
          digitalRead(fireIn) == HIGH )
        {
            currentState = STATE_firing;
        }
}

//=========================================
void test_firing_transitions()
//=========================================
{
    if ( analogRead(rOptic) == LOW )
    {
        currentState = STATE_fired;
    }
}

//=========================================
void test_fired_transitions()
//=========================================
{
    if ( analogRead(fOptic) == LOW &&
          digitalRead(fBump) == HIGH )
          {
              currentState = STATE_idle;
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
}

//=========================================
void fBumpInterrupt()
//=========================================
{

}

//=========================================
void rBumpInterrupt()
//=========================================
{

}
