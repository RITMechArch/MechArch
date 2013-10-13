/*
 * Input test code for the MechArch control box.
 * Reads signals from the data port that represent
 *   input from the machine and interrupts.
 *
 * @author Angel Lomeli (axl5646@rit.edu)
 */
 
 /* Library Includes */
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
#define eStopMainIn         (19)
#define fBump               (20)
#define rBump               (21)
#define fOptic              (24)
#define rOptic              (26)

/*
 * Performs first time setup of the LCD and input pins.
 */
void setup()
{
    pinMode(eStopMainIn, INPUT);
    pinMode(fBump, INPUT);
    pinMode(rBump, INPUT);
    pinMode(fOptic, INPUT);
    pinMode(rOptic, INPUT);

    lcd.begin(20,4);
}

/*
 * Main control loop. Samples the inputs and displays all values
 *   on the LCD.
 */
void loop()
{
    // Print fOptic's value
    lcd.setCursor(0,0);
    lcd.print("fOptic: ");
    delay(50);
    lcd.print(digitalRead(fOptic) ? "H" : "L");
    delay(50);
    
    // Print rOptic's value
    lcd.print("  rOptic: ");
    delay(50);
    lcd.print(digitalRead(rOptic) ? "H" : "L");
    delay(50);
    
    //Print fBump's value
    lcd.setCursor(0,1);
    lcd.print("fBump: ");
    delay(50);
    lcd.print(digitalRead(fBump) ? "H" : "L");
    delay(50);
    
    // Print rBump's value
    lcd.print("    rBump: ");
    delay(50);
    lcd.print(digitalRead(rBump) ? "H" : "L");
    delay(50);
    
    // Print eStop's value
    lcd.setCursor(0,2);
    lcd.print("eStop: ");
    delay(50);
    lcd.print(digitalRead(eStopMainIn) ? "H" : "L");
    delay(50);
}
