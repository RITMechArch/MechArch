/*
 * H-Bridge switching mode test program.
 * Tests bridge configuration 1.
 *
 * Author:  Bryan Blakeslee
 */
 
// Transistor definitions
#define M1 2
#define M2 4
#define M3 3
#define M4 5

// Constants
#define OFF 255

void setup(){
  // Configure outputs
  pinMode(M1,OUTPUT);
  pinMode(M2,OUTPUT);
  pinMode(M3,OUTPUT);
  pinMode(M4,OUTPUT);
  
  // Set initial state, all gates off
  digitalWrite(M1,LOW);
  digitalWrite(M2,LOW);
  analogWrite(M3,OFF);
  analogWrite(M4,OFF);
}

void loop(){
  // M1 on,  M2 off
  // M3 off, M4 on
  digitalWrite(M2,LOW);
  analogWrite(M3,OFF);
  digitalWrite(M1,HIGH);
  for(int i = OFF; i >= 0; i-=15){
    // Ramp up PWM 
    analogWrite(M4,i);
    delay(100);  // 100ms delay
  }
  delay(5000);  // 5s delay
  
  // M1 off, M2 on
  // M3 on,  M4 off
  digitalWrite(M1,LOW);
  analogWrite(M4,OFF);
  digitalWrite(M2,HIGH);
  for(int i = OFF; i >= 0; i-=15){
    // Ramp up PWM 
    analogWrite(M3,i);
    delay(100);  // 100ms delay
  }
  delay(5000);  // 5s delay
}
