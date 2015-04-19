#include "LinearActuator.h"
 
LinearActuator::LinearActuator() {}

void LinearActuator::init(int dirPin, int enablePin, int feedbackPin)
{
    _dirPin = dirPin;
    _enablePin = enablePin;
    _feedbackPin = feedbackPin;
    digitalWrite(_dirPin, LOW);
    direction = false;
    analogWrite(_enablePin, 255);
    isEnabled = false;
    position = analogRead( _feedbackPin ) << 20;
}

void LinearActuator::moveTo( int target )
{
    long position = getPosition();
    samplePosition();
    if(target > position && abs(target - position) > error) 
    {
        if(!direction) 
        {
            digitalWrite(_dirPin, EXTEND);
            direction = true;
        }
        analogWrite(_enablePin, 255-power);
        isEnabled = true;
    } 
    else if (target < position && abs(target - position ) > error) 
    {
        if(direction) 
        {
            digitalWrite(_dirPin, RETRACT);
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
      power = calculatePower(abs(target - position) * 255 / propDist);
    } 
    else if (isEnabled && abs(target - position) > propDist) 
    {
      power = calculatePower(255);
    }   
}

void LinearActuator::samplePosition()
{
    long curTime = micros();
    long dt = curTime - lastSampleTime;
    long input = ((long)analogRead(_feedbackPin)) << 20;
    long result = (((input  - (position))/10000)*dt);
    position = position + result;
    lastSampleTime= curTime;
}

long LinearActuator::getPosition()
{
    return position >> 18;
}

int LinearActuator::calculatePower(int duty) 
{
    int ret = 0;
    if(duty > 0 && duty <= 255) 
    {
        ret = (duty * (maxPower - minPower)/255 + minPower);
    } 
    return ret;
}