#ifndef LinearActuator_h
#define LinearActuator_h

#include "Arduino.h"

class LinearActuator 
{
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
        const int minPower = 64;
        const int maxPower = 255;
        const int propDist = 400;
        
        int power = 255;
        
    public:
        LinearActuator();
        void init(int dirPin, int enablePin, int feedbackPin);
        void moveTo( int target );
        void samplePosition();
        long getPosition();
        int calculatePower(int duty);
};
#endif