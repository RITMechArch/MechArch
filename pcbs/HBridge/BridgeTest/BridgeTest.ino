/*
 * Switching pattern test code for breadboard H-Bridge.
 *
 * Author:  Bryan Blakeslee
 */
 
// Input pins
#define FWD (5)
#define REV (6)

// Output pins
// M1, M2 = PMOS
// M3, M4 = NMOS
#define M1 (8)
#define M2 (9)
#define M3 (10)
#define M4 (11)

// Constants
#define delayFactor (100)

setup(){
  // Configure serial communications
  Serial.begin(9600);
  
  // Set pin directions
  pinMode(FWD, INPUT);
  pinMode(REV, INPUT);
  pinMode(M1, OUTPUT);
  pinMode(M2, OUTPUT);
  pinMode(M3, OUTPUT);
  pinMode(M4, OUTPUT);
}

loop(){
  if(digitalRead(FWD) == digitalRead(REV)){
    // Do braking
    // Turn off both PMOS
    digitalWrite(M1, HIGH);
    digitalWrite(M2, HIGH);
    // Delay
    delayMicroseconds(delayFactor);
    // Turn on both NMOS
    digitalWrite(M3, HIGH);
    digitalWrite(M4, HIGH);
  }else if(digitalRead(FWD) == HIGH){
    // Go forward on binary switching
    // Turn off both NMOS
    digitalWrite(M3, LOW);
    digitalWrite(M4, LOW);
    // Delay
    delayMicroseconds(delayFactor);
    // Turn on M2 PMOS
    digitalWrite(M2, LOW);
    // Delay
    delayMicroseconds(delayFactor);
    // Turn on opposite NMOS
    digitalWrite();
    busyWait();
  }else if(digitalRead(REV) == HIGH){
    // Go reverse on binary switching
    // Turn off both NMOS
    digitalWrite(M3, LOW);
    digitalWrite(M4, LOW);
    // Delay
    delayMicroseconds(delayFactor);
    // Turn on M1 PMOS
    digitalWrite(M1);
    // Delay
    delayMicroseconds(delayFactor);
    // Turn on opposite NMOS
    digitalWrite();
    busyWait();
  }
}

void busyWait(){
  while(digitalRead(FWD) != digitalRead(REV));
}
