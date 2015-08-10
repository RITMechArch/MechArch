#ifndef TIMER_H
#define TIMER_H

#include <cstdlib>
#include <chrono>
#include <thread>

using namespace std;

class Timer {

	int delay_time_us;
	chrono::system_clock::time_point last_sample_time;

public:

	Timer();

	void Sync(int cps);

	void Delayms(int time);
	void Delayus(int time);

};

#endif