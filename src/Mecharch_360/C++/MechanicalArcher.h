#ifndef MECHANICALARCHER_H
#define MECHANICALARCHER_H

#include "Winsock_Ethernet.h"
#include "Gamepad.h"
#include "Timer.h"
#include "Constants.h"
#include <thread>
#include <string>

#define OUTBUFSIZE 18
#define INBUFSIZE 9

union internal_state {
	struct formatted {
		short state;
		short draw_pos;
		short aim_x_pos;
		short aim_y_pos;
		bool f_optic;
		bool r_optic;
		short aim_y_cs;
		short aim_x_r_cs;
		short aim_x_l_cs;
		short draw_cs;
	} typed;
	char raw[OUTBUFSIZE];
};

union output_state {
	struct formatted {
		byte state;
		short aim_x_out;
		short aim_y_out;
		short draw_out;
		short trigger_out;
	} typed; 
	char raw[INBUFSIZE];
};

class MechanicalArcher {

	char send_buffer[INBUFSIZE];
	char receive_buffer[OUTBUFSIZE];

	static const short zero_offset = 255;

	Ethernet_Client * arduino = new Ethernet_Client();
	char Arduino_IP[4];// = { 192, 168, 1, 200 };
	int Arduino_Port = 2048;

	bool debug_mode = false;

	bool terminate = false;

	Gamepad * pad;
	Timer * time = new Timer();
	std::thread * updater;

	short string_pos;
	short retracted_pos;
	short drawn_pos;

	output_state output;
	
	internal_state feedback;

	void Update_Arduino();

	void FillSendBuffer();
	void FlushRecieveBuffer();

public:

	MechanicalArcher();

	// utility functions
	void Connect_Arduino();
	void Disconnect_Arduino();

	void Update();

	void End();

	void SetDebug(bool flag = false);
	void SetController(Gamepad*);

	// operating functions
	bool Draw();

	bool Fire();

	internal_state GetInfo();

};

#endif /* MECHANICALARCHER_H */
