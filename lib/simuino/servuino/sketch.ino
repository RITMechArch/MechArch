//================================================
//  Example HelloWorld
//================================================
// SKETCH_NAME: HelloWorld_MEGA
// BOARD_TYPE   MEGA
// SCENSIMLEN   660
//================================================
//  Scenario
//================================================
//
// SCENDIGPIN 10    1    0
// SCENDIGPIN 10   50    1
// SCENDIGPIN 10  100    0
// SCENDIGPIN 10  200    1
// SCENDIGPIN  9    1    0
// SCENDIGPIN  9   40    1
// SCENDIGPIN  9  130    0
//
// SCENANAPIN  4    1    5
// SCENANAPIN  5    1    8 
// SCENANAPIN  4   80   12
// SCENANAPIN  5  120   18 
//
//================================================
// Simuino log text customization
//================================================

// PINMODE_OUT: 11  "PIN: Led Urgent"
// PINMODE_OUT: 12  "PIN: Led Blink"

// DIGITALWRITE_LOW:  11  "Waiting"
// DIGITALWRITE_HIGH: 11  "Urgent"
// DIGITALWRITE_LOW:  12  "Led is off"
// DIGITALWRITE_HIGH: 12  "Led is on"

// DIGITALREAD:  9  "Read from nine"
// DIGITALREAD: 10  "Read from ten"


// ANALOGREAD: 4  "read analog four"
// ANALOGREAD: 5  "read analog five"


//-------- DIGITAL PIN settings ------------------

// Leds
int URGENTLED    = 31;
int BLINKLED     = 32;
int IN_PIN       = 52;
int CONTROL      = 53;
 
//-------- ANALOGUE PIN settings
int SENSOR1  = 4;
int SENSOR2  = 5;

//================================================
//  Function Declarations
//================================================

void blinkLed(int n);

//================================================
void urgent0()
//================================================
{
      digitalWriteX(66,URGENTLED, HIGH); 
      delayX(67,400);
      digitalWriteX(68,URGENTLED, LOW); 
}
//================================================
void urgent1()
//================================================
{
      digitalWriteX(74,URGENTLED, HIGH); 
      delayX(75,401);
      digitalWriteX(76,URGENTLED, LOW); 
}
//================================================
void urgent2()
//================================================
{
      digitalWriteX(82,URGENTLED, HIGH); 
      delayX(83,402);
      digitalWriteX(84,URGENTLED, LOW); 
}
//================================================
void urgent3()
//================================================
{
      digitalWriteX(90,URGENTLED, HIGH); 
      delayX(91,403);
      digitalWriteX(92,URGENTLED, LOW); 
}
//================================================
void urgent4()
//================================================
{
      digitalWriteX(98,URGENTLED, HIGH); 
      delayX(99,404);
      digitalWriteX(100,URGENTLED, LOW); 
}
//================================================
void urgent5()
//================================================
{
      digitalWriteX(106,URGENTLED, HIGH); 
      delayX(107,405);
      digitalWriteX(108,URGENTLED, LOW); 
}
//================================================
void setup()
//================================================
{
  Serial.beginX(114,9600); 
  
  pinModeX(116,BLINKLED,OUTPUT);   
  pinModeX(117,URGENTLED,OUTPUT);   
  pinModeX(118,IN_PIN,INPUT);
  pinModeX(119,CONTROL,INPUT);
  pinModeX(120,15,OUTPUT);
  pinModeX(121,44,INPUT);
  pinModeX(122,45,OUTPUT);
  pinModeX(123,46,OUTPUT);
  pinModeX(124,47,INPUT);
  attachInterruptX(125,0,urgent0, CHANGE);
  attachInterruptX(126,1,urgent1, RISING);
  attachInterruptX(127,2,urgent2, FALLING);
  attachInterruptX(128,3,urgent3, LOW);
  attachInterruptX(129,4,urgent4, CHANGE);
  attachInterruptX(130,5,urgent5, RISING);
}
	 
//================================================ 
void loop()
//================================================
{
  int value1,value2,i;

  Serial.printlnX(139,"Hello Simuino!");
  value1 = analogReadX(140,SENSOR1);
  value2 = analogReadX(141,SENSOR2);
  Serial.printX(142,"Analog 1 value read: ");
  Serial.printlnX(143,value1);
  Serial.printX(144,"Analog 2 value read: ");
  Serial.printlnX(145,value2);
  blinkLed(value1);
  value1 = digitalReadX(147,IN_PIN);
  value2 = digitalReadX(148,CONTROL);
  Serial.printX(149,"Digital IN_PIN read: ");
  Serial.printlnX(150,value1);
  Serial.printX(151,"Digital CONTROL read: ");
  Serial.printlnX(152,value2);

  analogWriteX(154,10,123);
  analogWriteX(155,11,167);

  analogWriteX(157,3,127);
  analogWriteX(158,4,147);
  
  delayX(160,1000); 
}

//================================================
void blinkLed(int n)
//================================================
{
  int i;
  for(i=1;i<=2;i++)
    {
      digitalWriteX(170,BLINKLED, HIGH); 
      delayX(171,500);
      digitalWriteX(172,BLINKLED, LOW); 
    }
}
//================================================
// End of Sketch
//================================================
