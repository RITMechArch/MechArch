#include "MechanicalArcher.h"

MechanicalArcher::MechanicalArcher() {

	memset(send_buffer, 0, sizeof(send_buffer));
	memset(receive_buffer, 0, sizeof(send_buffer));

}

void MechanicalArcher::Update() {

	if (!arduino->IsConnected() || !pad->Connected()) {
		return;
	}

	if (debug_mode) {

		output.typed.state = STATE_DEBUG;

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

		output.typed.aim_x_out = pad->RightStick_X() + zero_offset;
		output.typed.aim_y_out = pad->RightStick_Y() + zero_offset;
		output.typed.draw_out = pad->LeftStick_Y() + zero_offset;
		if (pad->RightTrigger()) {
			output.typed.trigger_out = 1;
		}
		else {
			output.typed.trigger_out = 0;
		}

	}
	else {



	}

	Update_Arduino();

}

bool MechanicalArcher::Draw() {

	// drawing sequence

	return true;
}

bool MechanicalArcher::Fire() {

	// firing sequence

	return true;
}

void MechanicalArcher::Update_Arduino() {

	FillSendBuffer();

	arduino->SendData(send_buffer, sizeof(send_buffer));
	memset(send_buffer, 0, sizeof(send_buffer));

	time->Delayms(5);

	arduino->RecieveData(receive_buffer, sizeof(receive_buffer));
	FlushRecieveBuffer();
}

void MechanicalArcher::End() {

	Disconnect_Arduino();
	delete arduino;
	delete this;
}

void MechanicalArcher::Connect_Arduino() {

	arduino->ConnectToHost(Arduino_Port, Arduino_IP);

}

void MechanicalArcher::Disconnect_Arduino() {

	arduino->CloseConnection();
	
}

void MechanicalArcher::SetDebug(bool flag) {

	debug_mode = flag;

}

internal_state MechanicalArcher::GetInfo() {

	return feedback;

}

void MechanicalArcher::FillSendBuffer() {
	memset(send_buffer, 0, sizeof(send_buffer));

	for (int i = 0; i < OUTBUFSIZE; i++) {

		send_buffer[i] = output.raw[i];

	}

}

void MechanicalArcher::FlushRecieveBuffer() {

	for (int i = 0; i < INBUFSIZE; i++) {

		feedback.raw[i] = receive_buffer[i];
		
	}

}

void MechanicalArcher::SetController(Gamepad * gamepad) {

	pad = gamepad;

}