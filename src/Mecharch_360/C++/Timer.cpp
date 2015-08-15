#include "Timer.h"

Timer::Timer() { last_sample_time = chrono::high_resolution_clock::now(); }

void Timer::Sync(int cps) {

	int cycle_time_us = 1000000 / cps;

	auto now = chrono::high_resolution_clock::now();

	auto dur = now - last_sample_time;

	auto us = chrono::duration_cast<chrono::microseconds>(dur).count();

	delay_time_us += cycle_time_us - delay_time_us - us;

	if (delay_time_us < 0) {
		delay_time_us = 0;
	}
	else if (delay_time_us > cycle_time_us) {
		delay_time_us = cycle_time_us;
	}

	last_sample_time = now;

	this_thread::sleep_for(chrono::microseconds(delay_time_us));

}

void Timer::Delayms(int time) {
	this_thread::sleep_for(chrono::milliseconds(time));
}

void Timer::Delayus(int time) {
	this_thread::sleep_for(chrono::microseconds(time));
}