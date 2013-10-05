/*
 * H-Bridge switching mode test program.
 * Tests bridge configuration 2.
 *
 * Author:  Bryan Blakeslee
 */

// Transistor definitions
#define LEFT 2
#define RIGHT 4
#define EN 3

// Constants
#define OFF 255

void setup(){
  // Configure outputs
  pinMode(LEFT,OUTPUT);
  pinMode(RIGHT,OUTPUT);
  pinMode(EN,OUTPUT);
  
  // Set initial state, bottom gates on, top off
  digitalWrite(LEFT,LOW);
  digitalWrite(RIGHT,LOW);
  analogWrite(EN,OFF);
}

void loop(){
  // M1 on,  M2 off
  // M3 off, M4 on
  analogWrite(EN,OFF);
  digitalWrite(LEFT,HIGH);
  digitalWrite(RIGHT,LOW);
  for(int i = OFF; i >=0; i-=15){
    // Ramp up PWM
    analogWrite(EN,i);
    delay(100);  // 100ms delay 
  }
  delay(5000);  // 5s delay
  
  // M1 off, M2 on
  // M3 on,  M4 off
  analogWrite(EN,OFF);
  digitalWrite(LEFT,LOW);
  digitalWrite(RIGHT,HIGH);
  for(int i = OFF; i >=0; i-=15){
    // Ramp up PWM
    analogWrite(EN,i);
    delay(100);  // 100ms delay 
  }
  delay(5000);  // 5s delay
}
