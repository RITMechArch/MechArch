#include "MachineStatus.h"
MachineStatus::MachineStatus()
    : armingChain ( false )
    , fOptic      ( true )
    , rOptic      ( true )
    , xPosition   ( 0 )
    , xTarget     ( 0 )
    , yPosition   ( 0 )
    , yTarget     ( 0 )
    , drawIn      ( false )
    , retractIn   ( false )
    , fireIn      ( false )
{}

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
