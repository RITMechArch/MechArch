/*
 * Simple test of sending output to the LCD screen on the MechArch control box.
 *
 * @author Angel Lomeli (axl5646@rit.edu)
 */
 
 /* Library includes. */
 #include <LiquidCrystal.h>
 
 //-------- LCD Output Pins ---------------
#define LCDRegSelect        (37)
#define LCDEnable           (39)
#define LCDData4            (41)
#define LCDData5            (43)
#define LCDData6            (45)
#define LCDData7            (47)
LiquidCrystal lcd( LCDRegSelect, LCDEnable, LCDData4, LCDData5, LCDData6, LCDData7 );

/*
 * Sets up the LCD screen to accept input.
 */
void setup() 
{
  /* Set LCD screen dimensions as width, height */
  lcd.begin(20,4);
}

/*
 * Main control loop. Prints "Testof LCD output" onto the first row.
 */
void loop()
{
  lcd.setCursor(0,0);
  lcd.print("LCD output test");
  lcd.setCursor(0,1);
  lcd.print(strcat("strcat ", "test"));
}
