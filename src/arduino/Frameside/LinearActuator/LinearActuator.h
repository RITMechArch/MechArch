#ifndef LinearActuator_h
#define LinearActuator_h

#include "Arduino.h"
#include "LinkedList.h"

class LinearActuator 
{
    private:
        int _dirPin;
        int _enablePin;
        int _feedbackPin;
        
        long position;
        
        bool direction;
        bool isEnabled;
        
        const int frequency = 100;
        const int samples = 150;
        long timeBetweenSamples = 1000000L/(samples*frequency); 
        long lastSampleTime;
        int samplesTaken;
        LinkedList sampleList;
    
        const int minPower = 64;
        const int maxPower = 255;
        const int propDist = 100;
        
    public:
        LinearActuator( int dirPin, int enablePin, int feedbackPin );
        void moveTo( long target );
        void samplePosition();
        long getPosition();
        int calculatePower(int duty);
};
#endif