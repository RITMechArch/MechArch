#ifndef RotaryEncoderReader_h
#define RotaryEncoderReader_h

#include "Arduino.h"
class RotaryEncoderReader {
    private:
        int _pinA;
        int _pinB;
        volatile long encoderPos;
  
    public:
        RotaryEncoderReader();
        RotaryEncoderReader( int newPinA, int newPinB );
        void doEncoderA();
        void doEncoderB();
        long getPosition();
};
#endif