#ifndef GAMEPAD_H
#define	GAMEPAD_H

#include <Windows.h>
#include <Xinput.h>
#include <cmath>

// XInput Button values
static const WORD XINPUT_Buttons[] = {
	XINPUT_GAMEPAD_A,
	XINPUT_GAMEPAD_B,
	XINPUT_GAMEPAD_X,
	XINPUT_GAMEPAD_Y,
	XINPUT_GAMEPAD_DPAD_UP,
	XINPUT_GAMEPAD_DPAD_DOWN,
	XINPUT_GAMEPAD_DPAD_LEFT,
	XINPUT_GAMEPAD_DPAD_RIGHT,
	XINPUT_GAMEPAD_LEFT_SHOULDER,
	XINPUT_GAMEPAD_RIGHT_SHOULDER,
	XINPUT_GAMEPAD_LEFT_THUMB,
	XINPUT_GAMEPAD_RIGHT_THUMB,
	XINPUT_GAMEPAD_START,
	XINPUT_GAMEPAD_BACK
};

// XInput Button IDs
struct XButtonIDs
{
	// Function prototypes
	//---------------------//

	XButtonIDs(); // Default constructor

	// Member variables
	//---------------------//

	int A, B, X, Y; // 'Action' buttons

	// Directional Pad (D-Pad)
	int DPad_Up, DPad_Down, DPad_Left, DPad_Right;

	// Shoulder ('Bumper') buttons
	int L_Shoulder, R_Shoulder;

	// Thumbstick buttons
	int L_Thumbstick, R_Thumbstick;

	int Start; // 'START' button
	int Back;  // 'BACK' button
};

class Gamepad {

	XINPUT_STATE m_State;   // Current gamepad state
	int m_iGamepadIndex;    // Gamepad index (eg. 1,2,3,4)

	// When abs(analog value) < deadzone, 0 is returned
	short LXDeadzone = 6000;
	short LYDeadzone = 6000;
	short RXDeadzone = 6000;
	short RYDeadzone = 6000;

	// Stick values are mapped so that 1 is next to the deadzone
	// and the Scale value is at the extreme
	int LXScale = 255;
	int LYScale = 255;
	int RXScale = 255;
	int RYScale = 255;

	// Triggers are treated digitally.  Deadzone is where they switch.
	BYTE LTDeadzone = 128;
	BYTE RTDeadzone = 128;

	// Maximum absolute value of raw analog stick data
	const int stickMax = 1 << 15;

	// Returns the sign of the number, -1 for negative, 0 for 0, 1 for positive
	int Signum(int);
	
	// Variables for frame specific button presses
	static const int ButtonCount = 14;
	bool bPrev_ButtonStates[ButtonCount];
	bool bButtonStates[ButtonCount];

	bool bGamepad_ButtonsDown[ButtonCount];

public:

	// Constructors

	Gamepad();
	Gamepad(int a_iIndex);

	// Thumbstick functions

	int LeftStick_X();
	int	LeftStick_Y();
	int RightStick_X();
	int RightStick_Y();

	void SetLXScale(int);
	void SetLYScale(int);
	void SetRXScale(int);
	void SetRYScale(int);

	// Trigger functions

	bool LeftTrigger();
	bool RightTrigger();

	// Button functions

	bool GetButtonPressed(int iButton);	// Returns true if pressed THIS FRAME
	bool GetButtonDown(int iButton);	// Returns true if CURRENTLY depressed

	// Vibration 0.0f = off, 1.0f = full

	void Rumble(float leftmotor = 0.0f, float rightmotor = 0.0f);

	// Utility Functions

	XINPUT_STATE GetState();	// Pole gamepad

	// Call at the beginning of input parsing for the loop
	void Update();				// Pole gamepad and update frame specific button list


	int GetIndex();				// Return controller number (0-3)
	bool Connected();			// Return true if controller conected

	// Call after input parsing is complete for the loop
	void RefreshState();		// Clear frame specific button list

};

#endif	/* GAMEPAD_H */

extern XButtonIDs XButtons;

