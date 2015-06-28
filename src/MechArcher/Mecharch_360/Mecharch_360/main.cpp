#include <cstdlib>
#include <iostream>
#include "Gamepad.h"

using namespace std;

int main() {

	Gamepad * player1;

	player1 = new Gamepad(1);


	while (player1->Connected()) {
	
		player1->Update();
		
		if (player1->LeftTrigger()) {
			break;
		}

		if (player1->GetButtonPressed(XButtons.A)) {
			cout << "The A button has been pressed.\n";
		}
		if (player1->GetButtonPressed(XButtons.B)) {
			cout << player1->LeftStick_X() << endl;
		}

		player1->RefreshState();

	}

	delete player1;

	return 0;
}