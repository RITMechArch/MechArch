//-------- DIGITAL PIN settings -----------

//-------- INPUT PIN settings -------------

int eStopRemoteIn  = 18;
int eStopMainIn    = 19;

int armingChain    = 40;

int laptopModeIn   = 42;

int drawIn         = 44;
int fireIn         = 46;

int fBump	   = 20;
int rBump       = 21;

//--------- OUTPUT PIN settings -----------

int drawRelay	   = 34;
int resetRelay   = 36;
int fireSolenoid   = 38;

//-------- STATE variable settings -------------

int currentState;
int STATE_idle    = 1;
int STATE_armed   = 2;
int STATE_drawing = 3;
int STATE_drawn   = 4;
int STATE_firing  = 5;
int STATE_fired  = 6;
int STATE_HALT  = 7;

//-------- ANALOG PIN settings ------------

int fOptic = 8;
int rOptic = 9;

//=========================================
//  Function Declarations
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

	attachInterrupt(2, drawn, RISING);
	attachInterrupt(3, armed, RISING);
	attachInterrupt(4, eStop, RISING);
	attachInterrupt(5, eStop, RISING);

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
            return;
        case STATE_idle:
            set_idle_outputs();
            break;
        case STATE_armed:
            set_armed_outputs();
            break;
        case STATE_drawing:
            set_drawing_outputs();
            break;
        case STATE_drawn:
            set_drawn_outputs();
            break;
        case STATE_firing:
            set_firing_outputs();
            break;
        case STATE_fired:
            set_fired_outputs();
            break;
        default:
            break;
    }
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
void eStop()
//=========================================
{
	Serial.println("eSTOP");
	currentState = STATE_HALT;
}

void set_halt_outputs()
{
    digitalWrite(drawRelay, LOW);
	digitalWrite(resetRelay, LOW);
	digitalWrite(fireSolenoid, LOW);
}

//Pass in true if you want to draw the winch
//false causes it to release
//
//=========================================
void winchActive(bool draw)
//=========================================
{
	int drawState = LOW;
	if(draw)
		drawState = HIGH;
	digitalWrite(drawRelay, drawState);
	digitalWrite(resetRelay, 1 - drawState);
}
