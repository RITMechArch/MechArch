#ifndef MECHANICALARCHER_H
#define MECHANICALARCHER_H

#include "SerialClass.h"
#include "Gamepad.h"
#include "Timer.h"
#include <string>

class MechanicalArcher {

	char send_buffer[32];
	char receive_buffer[32];

	static const short zero_offset = 255;

	Serial * arduino;

	bool debug_mode;

	short draw_pos_out;
	short aim_x_out;
	short aim_y_out;
	short draw_pow_out;
	short trigger_out;

	short string_pos;
	short retracted_pos;
	short drawn_pos;

	short draw_pos;
	short aim_x_pos;
	short aim_y_pos;
	bool f_optic;
	bool r_optic;
	short aim_y_cs;
	short aim_x_r_cs;
	short aim_x_l_cs;
	short draw_cs;

	void Update_Arduino();

public:

	MechanicalArcher(char *, bool debug = false);

	bool Draw();
	bool Fire();

	void Update(Gamepad *);

	void End();

};

#endif // !MECHANICALARCHER_H
