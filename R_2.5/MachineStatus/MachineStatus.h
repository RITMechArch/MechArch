#ifndef MACHINE_STATUS_H_
#define MACHINE_STATUS_H_

class MachineStatus
{
    public:
        enum State { IDLE = 1, ARMED = 2, AIMING = 3, DRAWING = 4, DRAWN = 5, RETRACTING = 6, FIRING = 7, FIRED = 8, HALT = 9 };

    private:
        State currentState;
        bool armingChain;
        bool fOptic;
        bool rOptic;
        bool isMoving;
        int  xPosition;
        int xTarget;
        int yPosition;
        int yTarget;

        bool drawIn;
        bool retractIn;
        bool fireIn;

        void checkStateTransitions();

    public:
        MachineStatus();

        State getCurrentState();
        bool  getArmingChain();
        bool  getFOptic();
        bool  getROptic();
        bool  getIsMoving();
        int   getXPosition();
        int   getXTarget();
        int   getYPosition();
        int   getYTarget();

        // TODO add appropriate parameters for status update.
        // One alternative is to add setters and provide the network object a reference to the
        // MachineStatus instead of using this update method.
        void updateStatus();
};
#endif
