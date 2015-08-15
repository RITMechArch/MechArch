#ifndef MECH_ARCH_FRAME_H_
#define MECH_ARCH_FRAME_H_

#include "MachineStatus.h"
#include "NetworkClient.h"

/*
 * This class acts as a network proxy to represent the mechanical archer frame.
 * Events intended for the frame will be translated into network commands and
 * status messages from the frame will be translated into MachineStatus objects.
 */

class MechArchFrame 
{
    public:
        MechArchFrame( NetworkClient &client );

        void moveToXTarget( int xPos );
        void moveToYTarget( int yPos );

        void setDrawnPosition( int pos );
        void draw();
        void setRetractedPosition( int pos );
        void retract();
        void fire();
        void eStop();
        MachineStatus getStatus();
    private:
        int _drawnPos;
        int _retractedPos;
        void moveToZTarget( int zPos );
        MachineStatus parseInput( std::string inStr );
        NetworkClient _client;
};
#endif
