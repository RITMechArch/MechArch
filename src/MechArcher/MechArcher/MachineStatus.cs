using System;

public class MachineStatus
{
    private States currentState, newState;

    // For the purposes of the state machine, fOptic and rOptic will return true if there is an arrow present.
    // This is the opposite of the convention in the Arduino.
    private bool armingChain, fOptic, rOptic, drawInput, retractInput, fireInput, movementRequested = false;

    private int xPosition, yPosition, xTarget, yTarget = 0;

    public enum States { IDLE = 1, ARMED = 2, AIMING = 3, DRAWING = 4, DRAWN = 5, RETRACTING = 6, FIRING = 7, FIRED = 8, HALT = 9 };
    
	public MachineStatus()
	{
        currentState = States.IDLE;
	}

    private void checkStateTransitions()
    {
        switch(currentState)
        {
            case States.IDLE:
            {
                if (armingChain)
                {
                    currentState = States.ARMED;
                }
                break;
            }
            case States.ARMED:
            {
                if (!armingChain)
                {
                    currentState = States.ARMED;
                }
                break;
            }
            case States.AIMING:
            {
                break;
            }
            case States.DRAWING:
            {
                break;
            }
            case States.DRAWN:
            {
                break;
            }
            case States.RETRACTING:
            {
                break;
            }
            case States.FIRING:
            {
                break;
            }
            case States.FIRED:
            {
                break;
            }
            case States.HALT:
            {
                break;
            }
        }
    }

    public States getState()
    {
        return currentState;
    }

    public bool getArmingChain()
    {
        return armingChain;
    }

    public bool getDrawInput()
    {
        return drawInput;
    }

    public bool getFireInput()
    {
        return fireInput;
    }

    public bool getFOptic()
    {
        return fOptic;
    }

    public bool getRetractInput()
    {
        return retractInput;
    }

    public bool getROptic()
    {
        return rOptic;
    }

    public int getXPosition()
    {
        return xPosition;
    }

    public int getXTarget()
    {
        return xTarget;
    }

    public int getYTarget()
    {
        return yTarget;
    }

    public int getYPosition()
    {
        return yPosition;
    }

    public void setArmingChain(bool arm)
    {
        armingChain = arm;
        checkStateTransitions();
    }

    public void setDrawInput(bool draw)
    {
        drawInput = draw;
        checkStateTransitions();
    }

    public void setFireInput(bool fire)
    {
        fireInput = fire;
        checkStateTransitions();
    }

    public void setFOptic(bool fOpt)
    {
        fOptic = fOpt;
        checkStateTransitions();
    }

    public void setROptic(bool rOpt)
    {
        rOptic = rOpt;
        checkStateTransitions();
    }

    public void setXTarget(int x)
    {
        xTarget = x;
    }

    public void setYTarget(int y)
    {
        yTarget = y;
    }

}
