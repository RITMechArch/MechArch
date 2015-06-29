#include <cstdlib>
#include <iostream>
#include <chrono>
#include <thread>
#include <string>
#include "Gamepad.h"
#include "SerialClass.h"

using namespace std;

int cycles_per_second = 100;

int cycle_time_us = 1000000/cycles_per_second;

int main() {

	Gamepad * player1;

	char comport [5];

	ZeroMemory(comport, sizeof(comport));

	cin >> comport;

	Serial arduino(comport);

	player1 = new Gamepad(1);

	char send_buffer[32];

	while (player1->Connected()) {

		auto begin = chrono::high_resolution_clock::now();

		ZeroMemory(send_buffer, sizeof(send_buffer));
	
		player1->Update();
		
		if (player1->GetButtonPressed(XButtons.Back)) {
			break;
		}

		if (arduino.IsConnected()) {
			
			int x = player1->RightStick_X() + player1->RXScale;

			int y = player1->RightStick_Y() + player1->RYScale;

			int d = player1->LeftStick_Y() + player1->LYScale;

			int f;

			if (player1->RightTrigger()) {
				f = 1;
			}
			else {
				f = 0;
			}

			sprintf_s(send_buffer, "X%d Y%d D%d F%d", x, y, d, f);

			arduino.WriteData(send_buffer, sizeof(send_buffer));

		}

		player1->RefreshState();

		auto end = chrono::high_resolution_clock::now();

		auto dur = end - begin;

		auto us = chrono::duration_cast<chrono::microseconds>(dur).count();

		this_thread::sleep_for(chrono::microseconds(cycle_time_us - us));
	}

	delete player1;

	arduino.~Serial();

	return 0;
}