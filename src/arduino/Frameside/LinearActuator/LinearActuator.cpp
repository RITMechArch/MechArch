#include "LinearActuator.h"
 
LinearActuator::LinearActuator( int dirPin, int enablePin, int feedbackPin )
    : _dirPin(dirPin)
    , _enablePin(enablePin)
    , _feedbackPin(feedbackPin)
    , position(0)
{
  //Write initial state values and set their associated flag
  digitalWrite(_dirPin, LOW);
  direction = false;
  analogWrite(enable, 255);
  isEnabled = false;
  sampleList = LinkedList();
  
  position = analogRead( _feedbackPin );
}

void LinearActuator::moveTo( long target )
{
    samplePosition();
    
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
        if(direction) {
            digitalWrite(_dirPin, LOW);
            direction = false;
        }
        analogWrite(enable, 255-power);
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
    else if (isEnable && abs(target - position) > propDist) 
    {
      power = calculatePower(100);
    }   
}

void LinearActuator::samplePosition()
{
    long curTime = micros();
    if (curTime >= (lastSampleTime + timeBetweenSamples * samplesTaken))
    {
        sampleList.add( analogRead(_feedbackPin) );
        if ( list.getSize() >= samples )
        {
            //taken = 0;
            // Get the average of the twenty middle values of the list
            int modeSum   = 0;
            int medianPos = sampleList.getSize() / 2;
            for ( int i = medianPos - 10; i < medianPos + 10; i++ )
            {
                modeSum += sampleList.getValue( i );
            }
            position = ( modeSum / 20 );
            sampleList.clearList();
            lastSampleTime = micros();
        }
    }
    else if(curTime - lastSampleTime < 0) 
    {
        // Account for internal clock reset
        lastSampleTime = curTime;
    }
}

long LinearActuator::getPosition()
{
    return position;
}

int LinearActuator::calculatePower(int duty) 
{
    if(duty == 0) 
    {
        return 0;
    } 
    else if(duty > 0 && duty <= 100) 
    {
        return (duty * (maxPower - minPower)/100 + minpower);
    } 
    else 
    {
        return 0;
    }
}