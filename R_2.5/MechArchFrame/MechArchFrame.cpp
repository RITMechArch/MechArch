#include <iostream>
#include <string>

#include "MechArchFrame.h"

MechArchFrame::MechArchFrame( NetworkClient &client )
    : _client( client )
{}

void MechArchFrame::moveToXTarget( int xPos )
{
    // TODO Find appropriate limits
    if ( xPos > 100 && xPos < 4100 )
    {
        std::string command = "X" + std::to_string(xPos) + "\n";
        _client.sendMessage( command );
    }
}

void MechArchFrame::moveToYTarget( int yPos )
{
    // TODO Find appropriate limits
    if ( yPos > 100 && yPos < 4100 )
    {
        std::string command = "Y" + std::to_string(yPos) + "\n";
        _client.sendMessage( command );
    }
}

void MechArchFrame::setDrawnPosition( int pos )
{
    if ( pos > 100 && pos < 3800 )
    {
        _drawnPos = pos;
    }
}

void MechArchFrame::draw()
{
    moveToZTarget( _drawnPos );
}

void MechArchFrame::setRetractedPos( int pos )
{
    _drawnPos = pos;
}

void MechArchFrame::retract()
{
    moveToZTarget( _retractedPos );
}

void MechArchFrame::moveToZTarget( int zPos )
{
    // TODO Find appropriate limits
    if ( zPos > 100 && zPos < 4100 )
    {
        std::string command = "Z" + std::to_string( zPos ) + "\n";
        _client.sendMessage( command );
    }
}

/*
 * By setting an explicit Z target ddthrough this object instead of on the arduino,
 * we can more easily test individual components and adjust the drawn distance
 * through configuration on the UI. This will also reduce the amount of work the
 * the arduino is reposonsible for. 
 *
 * This method of sending draw and retract commands will be preserved pending a more
 * complete discussion with the team.
 *
void MechArchFrame::draw()
{
    _client.sendMessage( "D\n" );
} 

void MechArchFrame::retract()
{
    _client.sendMessage( "R\n" );
} */

void MechArchFrame::fire()
{
    _client.sendMessage( "F\n" );
}

void MechArchFrame::eStop()
{
    _client.sendMessage( "E\n" );
}

MachineStatus MechArchFrame::getStatus()
{
    _client.sendMessage( "G\n" );
    std::string statusStr = _client.receiveMessage();
    return parseInput( statusStr );
}

int main( int argc, char** argv )
{
    std::cout << "It compiled." << std::endl;
}
