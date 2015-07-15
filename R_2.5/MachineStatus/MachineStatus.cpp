#include "MachineStatus.h"
MachineStatus::MachineStatus()
    : currentState( IDLE )
    , armingChain ( false )
    , fOptic      ( true )
    , rOptic      ( true )
    , isMoving    ( false )
    , xPosition   ( 0 )
    , xTarget     ( 0 )
    , yPosition   ( 0 )
    , yTarget     ( 0 )
    , drawIn      ( false )
    , retractIn   ( false )
    , fireIn      ( false )
{}

void MachineStatus::checkStateTransitions()
{
    switch (currentState)
    {
        case IDLE:
        {
            if (armingChain)
            {
                currentState = ARMED;
            }
            // TODO Change this so we aren't effectively replicating the minimum move from Arduino.
            //      Probably just use a newX/Y target flag from UI signal and let the Arduino signal
            //      that movement is complete. If the requested target is less than the minimum, the
            //      Arduino will not move, and will immediately set the movement complete signal. 
            else if ( !isMoving && (( xPosition > (xTarget+10) || xPosition < (xTarget-10))
                                   || yPosition > (yTarget+10) || yPosition < (yTarget-10)) ) 
            {
                isMoving = true;
                currentState = AIMING;
            }
            break;
        }
        case ARMED:
        {
            if (!armingChain)
            {
                currentState = IDLE;
            } 
            else if ( !isMoving && (( xPosition > (xTarget+10) || xPosition < (xTarget-10))
                                   || yPosition > (yTarget+10) || yPosition < (yTarget-10)) ) 
            {
                isMoving = true;
                currentState = AIMING;
            }
            else if ( armingChain && !fOptic && rOptic && drawIn )
            {
                drawIn = false;
                isMoving = true;
                currentState = DRAWING;
            }
            break;
        }
        case AIMING:
        {
            if ( !isMoving ) 
            {
                currentState = IDLE;
            }
            break;
        }
        case DRAWING:
        {
            if ( !fOptic && !rOptic && !isMoving )
            {
                currentState = DRAWN;
            }
            break;
        }
        case DRAWN:
        {
            if (armingChain && retractIn)
            {
                isMoving = true;
                retractIn = false;
                currentState = RETRACTING;
            }
            else if ( armingChain && !rOptic && !fOptic && fireIn )
            {
                fireIn = false;
                currentState = FIRING;
            }
            break;
        }
        case RETRACTING:
        {
            if ( !isMoving && rOptic)
            {
                currentState = ARMED:
            }
            break;
        } 
        case FIRING:
        {
            if (rOptic && fOptic)
            {
                currentState = FIRED;
            }
            break;
        }
        case FIRED:
        {
            // TODO delay here?
            isMoving = true;
            currentState = RETRACTING;
            break;
        }
    }
    // TODO
}
       
        
MachineStatus::State MachineStatus::getCurrentState()
{
    return currentState;
}

bool MachineStatus::getArmingChain()
{
    return armingChain;
}

bool MachineStatus::getFOptic()
{
    return fOptic;
}
bool MachineStatus::getROptic()
{
    return rOptic;
}
    
bool MachineStatus::getIsMoving()
{
    return isMoving;
}

int MachineStatus::getXPosition()
{
    return xPosition;
}
    
int MachineStatus::getXTarget()
{
    return xTarget;
}

int MachineStatus::getYPosition()
{
    return yPosition;
}

int MachineStatus::getYTarget()
{
    return yTarget;
}


void MachineStatus::setArmingChain( bool armingChainActive )
{
    armingChain = armingChainActive;
}

void MachineStatus::setFOptic( bool fOpticClear )
{
    fOptic = fOpticClear;
}

void MachineStatus::setROptic( bool rOpticClear )
{
    rOptic = rOpticClear;
}

void MachineStatus::setIsMoving( bool machineMoving )
{
    isMoving = machineMoving;
}

void MachineStatus::setXPosition( int currentXPosition )
{
    xPosition = currentXPosition;
}

void MachineStatus::setXTarget( int newTarget )
{
    xTarget = newTarget;
}

void MachineStatus::setYPosition( int currentYPosition )
{
    yPosition = currentYPosition;
}

void MachineStatus::setYTarget( int newTarget )
{
    yTarget = newTarget;
}

void MachineStatus::draw()
{
    if ( !drawIn && !retractIn && !fireIn )
    {
        drawIn = true;
    }
}

void MachineStatus::retract()
{
    if ( !drawIn && !retractIn && !fireIn )
    {
        retractIn = true;
    }
}

void MachineStatus::fire()
{
    if ( !drawIn && !retractIn && !fireIn )
    {
        fireIn = true;
    }
}

int main( int argc, char** argv)
{
}
