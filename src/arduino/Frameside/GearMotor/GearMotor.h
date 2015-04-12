#ifndef GEAR_MOTOR_H_
#define GEAR_MOTOR_H_

#include "RotaryEncoderReader.h"
class GearMotor 
{
    private:
        RotaryEncoderReader reader;
        int _dirPin;
        int _enablePin;
    
        long position;
        int power = 255;
        
        bool direction;
        bool isEnabled;
        
        long lastSampleTime;
        
        const int backlash = 3;
        const int error    = 10;
        const int minPower = 64;
        const int maxPower = 255;
        const int propDist = 400;
        const int minMax = 4000;
        int calculatePower(int duty);
        
    public:
        GearMotor();
        void init(int dirPin, int enablePin, int pinA, int pinB);
        void moveTo( int target );
        long getPosition();
        
        void doPinA();
        void doPinB();
};
#endif