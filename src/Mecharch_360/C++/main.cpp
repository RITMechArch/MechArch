#include <cstdlib>
#include <iostream>
#include <string>
#include "MechanicalArcher.h"
#include "Gamepad.h"
#include "Timer.h"

using namespace std;

int main() {

	MechanicalArcher * frame = new MechanicalArcher();

	Gamepad * player1 = new Gamepad(1);
	
	Timer * time = new Timer();

	delete player1;

	frame->End();

	return 0;
}