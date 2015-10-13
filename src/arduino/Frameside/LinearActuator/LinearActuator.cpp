#include "LinearActuator.h"
 
LinearActuator::LinearActuator() {}

void LinearActuator::init(int dirPin, int enablePin, int feedbackPin)
{
    _dirPin = dirPin;
    _enablePin = enablePin;
    _feedbackPin = feedbackPin;
    digitalWrite(_dirPin, LOW);
    direction = false;
    analogWrite(_enablePin, 0);
    isEnabled = false;
    position = analogRead( _feedbackPin ) << 20;
}

void LinearActuator::moveTo( int target )
{
    long position = getPosition();
    samplePosition();
    if(target > position && abs(target - position) > backlash) 
    {
        if(!direction) 
        {
            digitalWrite(_dirPin, EXTEND);
            direction = true;
        }
        analogWrite(_enablePin, power);
        isEnabled = true;
    } 
    else if (target < position && abs(target - position) > backlash)
    {
        if(direction) 
        {
            digitalWrite(_dirPin, RETRACT);
            direction = false;
        }
        analogWrite(_enablePin, power);
        isEnabled = true;
    }

    if (isEnabled && abs(target - position) <= backlash)
    {
        analogWrite(_enablePin, 0);
        isEnabled = false;  
        movementComplete = true;
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
    if(duty > 0 && duty <= 100) 
    {
        ret = (duty * (maxPower - minPower)/100 + minPower);
    } 
    return ret;
}

bool LinearActuator::isMovementComplete()
{
    return movementComplete;
}

void LinearActuator::setMovementComplete(bool tf)
{
    movementComplete = tf;
}
