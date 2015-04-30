#ifndef LinearActuator_h
#define LinearActuator_h

#define EXTEND HIGH
#define RETRACT LOW

#include "Arduino.h"

class LinearActuator 
{
    // Drawing linac max 3758
    private:
        int _dirPin;
        int _enablePin;
        int _feedbackPin;

        long position;

        bool direction;
        bool isEnabled;

        long lastSampleTime;

        const int backlash = 4;
        const int error    = 10;
        const int minPower = 128;
        const int maxPower = 255;
        const int propDist = 400;

        int power = 255;
        int calculatePower(int duty);

        bool movementComplete = true;
        
    public:
        LinearActuator();
        void init(int dirPin, int enablePin, int feedbackPin);
        void moveTo( int target );
        void samplePosition();
        long getPosition();
        
        bool isMovementComplete();
        void setMovementComplete(bool tf );
};
#endif