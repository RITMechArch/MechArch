#include "MechanicalArcher.h"

MechanicalArcher::MechanicalArcher(char * comport, bool debug) {

	arduino = new Serial(comport);

	ZeroMemory(send_buffer, sizeof(send_buffer));
	ZeroMemory(receive_buffer, sizeof(send_buffer));

	debug_mode = debug;

}

void MechanicalArcher::Update(Gamepad * pad) {

	if (!arduino->IsConnected() || !pad->Connected()) {
		return;
	}

	if (debug_mode) {

		draw_pos_out = 4100;

		if (pad->GetButtonDown(XButtons.L_Shoulder)) {
			int low = 128;
			pad->SetLXScale(low);
			pad->SetLYScale(low);
			pad->SetRXScale(low);
			pad->SetRYScale(low);
		}
		else {
			int high = 255;
			pad->SetLXScale(high);
			pad->SetLYScale(high);
			pad->SetRXScale(high);
			pad->SetRYScale(high);
		}

		aim_x_out = pad->RightStick_X() + zero_offset;
		aim_y_out = pad->RightStick_Y() + zero_offset;
		draw_pow_out = pad->LeftStick_Y() + zero_offset;
		if (pad->RightTrigger()) {
			trigger_out = 1;
		}
		else {
			trigger_out = 0;
		}

	}

	Update_Arduino();

}

bool MechanicalArcher::Draw() {

	// drawing sequence

}

void MechanicalArcher::Update_Arduino() {

	int feedback = 0;

	sprintf_s(send_buffer, "D%d X%d Y%d d%d F%d R%d", draw_pos_out, aim_x_out, aim_y_out, draw_pow_out, trigger_out, feedback);

	arduino->WriteData(send_buffer, sizeof(send_buffer));

}

void MechanicalArcher::End() {

	arduino->~Serial();
	delete arduino;

}