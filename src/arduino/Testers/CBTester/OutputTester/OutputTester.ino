/*
 * Output pin test code for the MechArch control box.
 * Sends a signal that can be physically detected
 *  to the data port.
 *
 * @author Angel Lomeli (axl5646@rit.edu)
 */

/* Library includes */
#include <LiquidCrystal.h>

//-------- LCD Output Pins ---------------
#define LCDRegSelect        (37)
#define LCDEnable           (39)
#define LCDData4            (41)
#define LCDData5            (43)
#define LCDData6            (45)
#define LCDData7            (47)
LiquidCrystal lcd( LCDRegSelect, LCDEnable, LCDData4, LCDData5, LCDData6, LCDData7 );

//--------- INPUT PIN settings -----------
#define fireIn              (46)

//--------- OUTPUT PIN settings -----------

#define drawRelay           (34)
#define resetRelay          (36)
#define fireSolenoid        (38)

//-------- STATE const declarations -------------
int currentState;
#define STATE_testingDraw    (1)
#define STATE_testingReset   (2)
#define STATE_testingFire    (3)


//-------- Edge Detection declarations -------------
boolean currentSwitchVal;
boolean previousSwitchVal;

/* 
 * Performs first time setup of the LCD, output
 *   pins, input pin, and edge detection booleans
 */
void setup()
{
  pinMode(drawRelay, OUTPUT);
  pinMode(resetRelay, OUTPUT);
  pinMode(fireSolenoid, OUTPUT);
  
  pinMode(fireIn, INPUT);
  
  currentState = STATE_testingDraw;
  currentSwitchVal = LOW;
  previousSwitchVal = LOW;
  
  /* Set LCD screen dimensions as width, height. */
  lcd.begin(20,4);
}

/* 
 * Main control loop. Sends an output signal based on
 *   which ouput pin is being tested.
 */
void loop()
{
  /* Set the edge detection values */
  previousSwitchVal = currentSwitchVal;
  currentSwitchVal = digitalRead(fireIn);
  
  switch(currentState)
  {
    case STATE_testingDraw:
      if (currentSwitchVal == HIGH && previousSwitchVal == LOW)
      {
        lcd.clear();
        currentState = STATE_testingReset;
        digitalWrite(drawRelay, LOW);
      }
      else
      {
        lcd.setCursor(0,0);
        lcd.print("Cur: Draw Output");
        digitalWrite(drawRelay, HIGH);
      }
      break;
      
    case STATE_testingReset:
      if (currentSwitchVal == HIGH && previousSwitchVal == LOW)
      {
        lcd.clear();
        currentState = STATE_testingFire;
        digitalWrite(resetRelay, LOW);
      }
      else
      {
        lcd.setCursor(0,0);
        lcd.print("Cur: Reset Output");
        digitalWrite(resetRelay, HIGH);
      }
      break;

    case STATE_testingFire:
      if (currentSwitchVal == HIGH && previousSwitchVal == LOW)
      {
        lcd.clear();
        currentState = STATE_testingDraw;
        digitalWrite(fireSolenoid, LOW);
      }
      else
      {
        lcd.setCursor(0,0);
        lcd.print("Cur: Fire Output");
        digitalWrite(fireSolenoid, HIGH);
      }
      break;
      
    default:
    lcd.clear();
      lcd.setCursor(0,0);
      lcd.print("Error");
      break;
  }// End switch
}
