/* 
 * Wiring test code for MechArch control box.
 * Currently only tests control box buttons.
 * Need to add sensors from data port.
 *
 * @author Bryan Blakeslee (bmb8610@rit.edu)
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

/* 
 * Performs first time setup on MCU. 
 */
void setup(){
   /* Pin mode configuration. */
   pinMode(eStopMainIn, INPUT);
   pinMode(armingChain, INPUT);
   pinMode(drawIn, INPUT);
   pinMode(letDownIn, INPUT);
   pinMode(fireIn, INPUT);
   
   /* Set LCD screen dimensions as width, height. */
   lcd.begin(20, 4);
}

/*
 * Main control loop.  Polls all buttons and prints
 * button status to LCD screen.
 */
void loop(){
   /* Perform scan of buttons and print status. */
   lcd.setCursor(0, 0);
   lcd.print("AC: ");
   delay(50);
   lcd.print((digitalRead(armingChain) ? "H" : "L"));
   delay(50);
   lcd.print("   Fire: ");
   delay(50);
   lcd.print((digitalRead(fireIn) ? "H" : "L"));
   delay(50);
   //lcd.print(strcat(strcat("AC: ", (digitalRead(armingChain) ? "H" : "L")), strcat("   Fire: ", (digitalRead(fireIn) ? "H" : "L"))));
   
   
   lcd.setCursor(0, 1);
   lcd.print("E-stop: ");
   delay(50);
   lcd.print("N/A");
   //lcd.print(strcat("E-Stop: ", (digitalRead(eStopMainIn) ? "H" : "L")));
   
   lcd.setCursor(0, 2);
   lcd.print("Draw: ");
   delay(50);
   lcd.print((digitalRead(drawIn) ? "H" : "L"));
   delay(50);
   //lcd.print(strcat("Draw: ", (digitalRead(drawIn) ? "H" : "L")));
   
   lcd.setCursor(0, 3);
   lcd.print("letDown: ");
   delay(50);
   lcd.print((digitalRead(resetInput) ? "H" : "L"));
   //lcd.print(strcat("letDown: ", (digitalRead(letDownIn) ? "H" : "L")));
}
