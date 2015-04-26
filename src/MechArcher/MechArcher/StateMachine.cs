using System;

public class StateMachine
{
    private State current_state, new_state;

    private boolean arming_chain, r_optic, f_optic, draw_input, retract_input, fire_input;

    public enum State { IDLE = 1, ARMED = 2, AIMING = 3, DRAWING = 4, DRAWN = 5, RETRACTING = 6, FIRING = 7, FIRED = 8, HALT = 9 };
    
	public StateMachine()
	{
        current_state = state.IDLE;
	}

    public State getState()
    {
        return current_state;
    }

    public boolean transitionTo(State newState)
    {
        switch(new_state)
        {
            case State.IDLE:
                
                break;
            case State.ARMED:
                
                break;
            case State.AIMING: 

                break;
            case State.DRAWING:

                break;
            case State.DRAWN:

                break;
            case State.RETRACTING:

                break;
            case State.FIRING:

                break;
            case State.FIRED:

                break;
            case State.HALT:

                break;
        }
    }

}
