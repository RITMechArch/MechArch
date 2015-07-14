#include <cstdlib>
#include <iostream>
#include <string>
#include "MechanicalArcher.h"
#include "Gamepad.h"
#include "Timer.h"

using namespace std;

int main() {

	char comport [6];
	ZeroMemory(comport, sizeof(comport));
	cin >> comport;

	MechanicalArcher * frame = new MechanicalArcher(comport, true);

	Gamepad * player1 = new Gamepad(1);
	
	Timer * time = new Timer();

	while (true) {

		if (player1->GetButtonDown(XButtons.Back)) {
			break;
		}

		frame->Update(player1);

		time->Sync(30);

	}

	delete player1;

	frame->End();

	return 0;
}