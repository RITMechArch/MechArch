#ifndef MACHINE_STATUS_H_
#define MACHINE_STATUS_H_

class MachineStatus
{
    public:

    private:
        bool armingChain;
        bool fOptic;
        bool rOptic;
        int  xPosition;
        int xTarget;
        int yPosition;
        int yTarget;

        bool drawIn;
        bool retractIn;
        bool fireIn;

    public:
        MachineStatus();

        bool getArmingChain();
        bool getFOptic();
        bool getROptic();
        int  getXPosition();
        int  getXTarget();
        int  getYPosition();
        int  getYTarget();
        void setArmingChain ( bool armingChainActive );
        void setFOptic      ( bool fOpticClear );
        void setROptic      ( bool rOpticClear );
        void setXPosition   ( int currentXPosition );
        void setXTarget     ( int newTarget );
        void setYPosition   ( int currentYPosition );
        void setYTarget     ( int newTarget );
};
#endif
