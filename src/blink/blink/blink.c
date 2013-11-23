/*
 * blink.c
 *
 * Created: 11/17/2013 2:33:28 PM
 *  Author: Dustin
 */ 


#include <avr/io.h>
#include <util/delay.h>

int main(void)
{
	DDRB = 1<<3; // port B3, ATtiny13a pin 2
	PORTB = 0x0;

	while (1)
	{
		PORTB = 1<<3; // port B3, ATtiny13a pin 2
		_delay_ms(50);
		PORTB = 0X0;
		_delay_ms(25);
	}
}