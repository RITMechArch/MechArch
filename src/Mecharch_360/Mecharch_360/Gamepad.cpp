#include "Gamepad.h"

#pragma comment(lib, "Xinput9_1_0.lib")

XButtonIDs XButtons;

// 'XButtonIDs' - Default constructor
XButtonIDs::XButtonIDs()
{
	// These values are used to index the XINPUT_Buttons array,
	// accessing the matching XINPUT button value

	A = 0;
	B = 1;
	X = 2;
	Y = 3;

	DPad_Up = 4;
	DPad_Down = 5;
	DPad_Left = 6;
	DPad_Right = 7;

	L_Shoulder = 8;
	R_Shoulder = 9;

	L_Thumbstick = 10;
	R_Thumbstick = 11;

	Start = 12;
	Back = 13;
}

Gamepad::Gamepad() {}

Gamepad::Gamepad(int a_iIndex) {

	m_iGamepadIndex = a_iIndex - 1;

	for (int i = 0; i < ButtonCount; i++) {
		bPrev_ButtonStates[i] = false;
		bButtonStates[i] = false;
		bGamepad_ButtonsDown[i] = false;
	}

}

XINPUT_STATE Gamepad::GetState() {

	XINPUT_STATE GamepadState;

	ZeroMemory(&GamepadState, sizeof(XINPUT_STATE));

	XInputGetState(m_iGamepadIndex, &GamepadState);

	return GamepadState;
}

int Gamepad::GetIndex() {

	return m_iGamepadIndex;
}

bool Gamepad::Connected() {

	ZeroMemory(&m_State, sizeof(XINPUT_STATE));

	DWORD Result = XInputGetState(m_iGamepadIndex, &m_State);

	if (Result == ERROR_SUCCESS) {
		return true;
	}
	else {
		return false;
	}
}

void Gamepad::Update() {

	m_State = GetState();

	for (int i = 0; i < ButtonCount; i++) {
		bButtonStates[i] = (m_State.Gamepad.wButtons & XINPUT_Buttons[i]) == XINPUT_Buttons[i];

		bGamepad_ButtonsDown[i] = !bPrev_ButtonStates[i] && bButtonStates[i];
	}

}

void Gamepad::RefreshState() {

	memcpy(bPrev_ButtonStates, bButtonStates, sizeof(bPrev_ButtonStates));
}

int Gamepad::Signum(int in) {

	if (in > 0) return 1;
	if (in < 0) return -1;
	return 0;
}

int Gamepad::LeftStick_X() {

	int raw = (int)m_State.Gamepad.sThumbLX;

	if (abs(raw) - LXDeadzone <= 0) {
		return 0;
	}
	else {
		return Signum(raw)*(abs(raw)-LXDeadzone)*LXScale/(stickMax-LXDeadzone);
	}

}

int Gamepad::LeftStick_Y() {

	int raw = (int)m_State.Gamepad.sThumbLY;

	if (abs(raw) - LYDeadzone <= 0) {
		return 0;
	}
	else {
		return Signum(raw)*(abs(raw) - LYDeadzone)*LYScale / (stickMax - LYDeadzone);
	}

}

int Gamepad::RightStick_X() {

	int raw = (int)m_State.Gamepad.sThumbRX;

	if (abs(raw) - RXDeadzone <= 0) {
		return 0;
	}
	else {
		return Signum(raw)*(abs(raw) - RXDeadzone)*RXScale / (stickMax - RXDeadzone);
	}

}

int Gamepad::RightStick_Y() {

	int raw = (int)m_State.Gamepad.sThumbRY;

	if (abs(raw) - RYDeadzone <= 0) {
		return 0;
	}
	else {
		return Signum(raw)*(abs(raw) - RYDeadzone)*RYScale / (stickMax - RYDeadzone);
	}

}

bool Gamepad::LeftTrigger() {

	BYTE raw = m_State.Gamepad.bLeftTrigger;

	if (raw > LTDeadzone) {
		return true;
	}
	else {
		return false;
	}

}

bool Gamepad::RightTrigger() {

	BYTE raw = m_State.Gamepad.bRightTrigger;

	if (raw > RTDeadzone) {
		return true;
	}
	else {
		return false;
	}
	

}

void Gamepad::Rumble(float leftmotor, float rightmotor) {

	XINPUT_VIBRATION VibrationState;

	ZeroMemory(&VibrationState, sizeof(XINPUT_VIBRATION));

	int ileftmotor = int(leftmotor*65535.0f);
	int irightmotor = int(rightmotor*65535.0f);

	VibrationState.wLeftMotorSpeed = ileftmotor;
	VibrationState.wRightMotorSpeed = irightmotor;

	XInputSetState(m_iGamepadIndex, &VibrationState);

}

bool Gamepad::GetButtonDown(int iButton) {

	if (m_State.Gamepad.wButtons & XINPUT_Buttons[iButton]) {
		return true;
	}
	return false;

}

bool Gamepad::GetButtonPressed(int iButton) {

	return bGamepad_ButtonsDown[iButton];

}

void Gamepad::SetLXScale(int in) {
	LXScale = in;
}

void Gamepad::SetLYScale(int in) {
	LYScale = in;
}

void Gamepad::SetRXScale(int in) {
	RXScale = in;
}

void Gamepad::SetRYScale(int in) {
	RYScale = in;
}