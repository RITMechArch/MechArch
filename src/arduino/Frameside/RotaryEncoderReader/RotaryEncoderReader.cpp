#include "RotaryEncoderReader.h"
 
RotaryEncoderReader::RotaryEncoderReader( int pinA, int pinB )
    : _pinA(pinA)
    , _pinB(pinB)
    , encoderPos(0)
{
}

void RotaryEncoderReader::doEncoderA()
{
     // look for a low-to-high on channel A
    if ( digitalRead(_pinA) == HIGH ) 
    { 
        // check channel B to see which way encoder is turning
        if (digitalRead(_pinB) == LOW) 
        {  
            encoderPos = encoderPos + 1;         // CW
        } 
        else 
        {
            encoderPos = encoderPos - 1;         // CCW
        }
    }
    else   // must be a high-to-low edge on channel A                                       
    { 
        // check channel B to see which way encoder is turning  
        if (digitalRead(_pinB) == HIGH) 
        {   
            encoderPos = encoderPos + 1;          // CW
        } 
        else 
        {
            encoderPos = encoderPos - 1;          // CCW
        }
    }
    //Serial.println (encoderPos, DEC);          
    // use for debugging - remember to comment out
}

void RotaryEncoderReader::doEncoderB()
{

    // look for a low-to-high on channel B
    if (digitalRead(_pinB) == HIGH) 
    {    
       // check channel A to see which way encoder is turning
        if (digitalRead(_pinA) == HIGH) 
        {  
            encoderPos = encoderPos + 1;         // CW
        } 
        else 
        {
            encoderPos = encoderPos - 1;         // CCW
        }
    }
    // Look for a high-to-low on channel B
    else 
    { 
        // check channel B to see which way encoder is turning  
        if (digitalRead(_pinA) == LOW) 
        {   
            encoderPos = encoderPos + 1;          // CW
        } 
        else 
        {
            encoderPos = encoderPos - 1;          // CCW
        }
    }
} 
   
long RotaryEncoderReader::getPosition()
{
    return encoderPos;
}
