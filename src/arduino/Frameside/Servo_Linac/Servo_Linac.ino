int dir = 2;                                            //Direction control pin
int enable = 3;                                         //Motor on/off and PWM control
int feedback = 0;                                       //Linear actuator potentiometer input
long samples = 90;                                     //Number of analog samples to average to reduce noise
long taken = 0;                                         //Variable to track the number of samples taken so far
long frequency = 100; //hz                              //Frequency with which the position is updated
long del = 1000000L/(samples*frequency);                //Time between individual samples based on above
int target = -1;                                        //Position that the system is trying to achieve
                                                        //-1 disables position based control
int pos;                                                //Linear actuator position averaged over one period
long val = 0;                                           //Variable used in the averaging of samples
int stopval;                                            //The pos value at which the motor was turned off; mostly for debug
int proportional = 100;                                 //Distance at which proportional control is enabled
int maxpower = 255;                                     //Maximum duty cycle for the analogWrite funciton
int minpower = 64;                                      //Minimum duty cycle for the analogWrite function
int power = 255;                                        //PWM duty cycle, where 255 is all on and 0 is all off
int backlash = 1;                                       //Amount by which the motor will stop early to account for momentum
int error = 5;                                          //Any position closer than this to the current position
                                                        //won't trigger a move
unsigned long sample1;                                  //Time at which the last sample was taken
unsigned long serial1;                                  //Time at which the position was last written to the Serial port
boolean direc;                                          //Flag to indicate the state of pin 'dir'
boolean on;                                             //Flag to indicate the state of pin 'enable'
boolean serial = true;                                  //Whether position data should be output to the Serial port continuously


void setup() {
  //Set pins to proper modes
  pinMode(dir, OUTPUT);
  pinMode(enable, OUTPUT);
  
  //Write initial state values and set their associated flag
  digitalWrite(dir, LOW);
  direc = false;
  analogWrite(enable, 255);
  on = false;
  
  //Open the Serial Port
  Serial.begin(115200);
  
  //Assign values to the time variables
  serial1 = millis();
  sample1 = micros();
  
  //Assign an initial value to pos
  pos = analogRead(feedback);
}

void loop() {
  /*
  This if statement performs the rapid sampling and averaging of the positional feedback, outputting
  the value to pos every time a sufficient number of samples have been taken.
  The else if is in place to handle the overflow of micros(), which occurs about 70 minutes after 
  the arduino powers on.
  */
  if(micros()-sample1 >= del) {
    
    val += analogRead(feedback);
    taken++;
    sample1 = micros();
    
    if(taken >= samples) {
      taken = 0;
      pos = val/samples;
      val = 0;
    }
    
  } else if(micros()-sample1 < 0) {
    
    sample1 = micros();
    
  }
  
  /*
  This section performs rudamentry servo control of the linear actuator by checking the difference
  between the target position and the current position and setting the direction and enabling the
  output as necessary to bring the two closer together.
  */
  if(target != -1) {   
    
    if(target > pos && abs(target-pos) > error) {
      
      if(!direc) {
        
        digitalWrite(dir, HIGH);
        direc = true;
        
      }
      
      analogWrite(enable, 255-power);
      on = true;
      
    } else if (target < pos && abs(target-pos) > error) {
      
      if(direc) {
        
        digitalWrite(dir, LOW);
        direc = false;
        
      }
      
      analogWrite(enable, 255-power);
      on = true;
      
    } else if (on && abs(target-pos) < backlash) {
      
      stopval = pos;
      analogWrite(enable, 255);
      on = false;
      
      Serial.print("Stopped at position ");
      Serial.println(stopval);
      
    }
    
    if (on && abs(target-pos) <= proportional) {
      
      power = Power(abs(target-pos)*100/proportional);
      
    } else if (on && abs(target-pos) > proportional) {
      
      power = Power(100);
      
    }
  }
  
  /*
  Sends the current position out to the serial port every 500 ms
  */
  if(millis()-serial1 >= 500 && serial) {
    
    Serial.print("Position: ");
    Serial.println(pos);
    serial1 = millis();
    
  }
}

void serialEvent() {
  /*
  This whole block interprets the serial port inputs into commands for the system.
  Each command is a single letter followed directly by an integer argument.  Spaces between commands are optional.
  The commands are as follows:
    s        Sets the number of samples to average in order to smooth the analog input.
    c        Controls whether the arduino constantly reports position over the serial port.  1 enables, 0 disables
    d        Sets the maximum duty cycle of the PWM output.  Valid values are from 0 to 255 inclusive.
    l        Sets the minimum duty cycle of the PWM output.  Same valid values as above.
    p        Sets the target position of the linear actuator.  Valid values are approximately from 5 to 995.
    e        Sets the minimum difference between the target and the current position needed to trigger a move.
    b        Sets the distance by which the motor will be stopped early to account for momentum in the motor.
    
  For example, to set the number of samples to 100 and max duty cycle to 50%, acceptable commands would be:
    s100 d128
    d128 s100
    s100d128
    d128s100
  
  Any number of different commands can be given in a single line.
  Sending the same command twice in the same line will have the effect of only the second.  For example: "p400 p300"
  is identical to "p300".  Superfluous commands and spaces only increase the time it takes to process inputs.
  */
  while(Serial.available()) {
    int in0;
    if(Serial.peek() == 's') {
      Serial.read();
      in0 = Serial.parseInt();
      samples = in0;
      del = 1000000L/(samples*frequency);
      Serial.print("Number of samples changed to ");
      Serial.println(samples);
    }
    
    int in1;
    if(Serial.peek() == 'c') {
      Serial.read();
      in1 = Serial.parseInt();
      if(in1 == 0) {
        serial = false;
        Serial.println("Position output is now disabled");
      } else if (in1 ==1) {
        serial = true;
        Serial.println("Position output is now enabled");
      }
    }
    
    int in2;
    if(Serial.peek() == 'd') {
      Serial.read();
      in2 = Serial.parseInt();
      maxpower = in2;
      Serial.print("Maximum power is now ");
      Serial.print(maxpower*100/255);
      Serial.println("%");
    }
    
    int in3;
    if(Serial.peek() == 'p') {
      Serial.read();
      in3 = Serial.parseInt();
      target = in3;
      if(target != -1) {
        Serial.print("Target position is ");
        Serial.println(target);
      } else if(target == -1) {
        analogWrite(enable, 255);
        Serial.println("Servo control is disabled");
      }
    }
    
    int in4;
    if(Serial.peek() == 'e') {
      Serial.read();
      in4 = Serial.parseInt();
      error = in4;
      Serial.print("Acceptable positioning error is now +/-");
      Serial.println(error);
    }
    
    int in5;
    if(Serial.peek() == 'b') {
      Serial.read();
      in5 = Serial.parseInt();
      backlash = in5;
      Serial.print("Backlash compensation is now ");
      Serial.println(backlash);
    }
    
    int in6;
    if(Serial.peek() == 'l') {
      Serial.read();
      in6 = Serial.parseInt();
      minpower = in6;
      Serial.print("Minimum power is now ");
      Serial.print(minpower*100/255);
      Serial.println("%");
    }
    
    if(Serial.peek() == ' ') {
      Serial.read();
    }
  }
}

int Power(int duty) {
  if(duty == 0) {
    return 0;
  } else if(duty > 0 && duty <= 100) {
    return (duty*(maxpower-minpower)/100 + minpower);
  } else {
    return 0;
  }
}
