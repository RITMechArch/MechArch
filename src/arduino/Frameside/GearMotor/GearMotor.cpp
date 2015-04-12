#include "GearMotor.h"
#include "RotaryEncoderReader.h"
 
GearMotor::GearMotor() {}
 
void GearMotor::init(int dirPin, int enablePin, int pinA, int pinB)
{
    _dirPin = dirPin;
    _enablePin = enablePin;
    reader = RotaryEncoderReader(pinA, pinB);

    digitalWrite(_dirPin, LOW);
    direction = false;
    analogWrite(_enablePin, 255);
    isEnabled = false;
    position = reader.getPosition();
}

void GearMotor::moveTo( int target )
{
    
    if (abs(target) > minMax) {
        // TODO: Report back an error
        return;
    }
    
    position = reader.getPosition();
    if(target > position && abs(target - position) > error) 
    {
        if(!direction) 
        {
            digitalWrite(_dirPin, HIGH);
            direction = true;
        }
        analogWrite(_enablePin, 255-power);
        isEnabled = true;
    } 
    else if (target < position && abs(target - position ) > error) 
    {
        if(direction) 
        {
            digitalWrite(_dirPin, LOW);
            direction = false;
        }
        analogWrite(_enablePin, 255-power);
        isEnabled = true;
    } 
    else if (isEnabled && abs(target - position) <= backlash) 
    {
        analogWrite(_enablePin, 255);
        isEnabled = false;      
    }
    
    if (isEnabled && abs(target - position) <= propDist) 
    {
      power = calculatePower(abs(target - position) * 100 / propDist);
    } 
    else if (isEnabled && abs(target - position) > propDist) 
    {
      power = calculatePower(100);
    }   
}

long GearMotor::getPosition()
{
    return position;
}

int GearMotor::calculatePower(int duty) 
{
    int ret = 0;
    if(duty > 0 && duty <= 100) 
    {
        ret = (duty * (maxPower - minPower)/100 + minPower);
    } 
    return ret;
}

void GearMotor::doPinA()
{
    reader.doEncoderA();
}

void GearMotor::doPinB()
{
    reader.doEncoderB();
}