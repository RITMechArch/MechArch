/*
 * ATTiny.c
 *
 * Created: 10/13/2013 2:42:22 PM
 *  Author: Dustin Stroup
 */ 

#define F_CPU 20000000UL /* Clock Frequency = 20Mhz */

#include <avr/io.h>
#include <util/delay.h>

// Inputs
#define FWD_MASK  0b00001000
#define FWD       PINB3
#define REV_MASK  0b00010000
#define REV       PINB4

// Outputs
#define LLEG_MASK 0b00000100
#define LLEG      PORTB2
#define RLEG_MASK 0b00000001
#define RLEG      PORTB0
#define EN_MASK   0b00000010 // TODO: PWM
#define EN        PORTB1

// Other
#define DELAY 50 // us TODO: Reasonable delay?

// Macros
#define CLEAR(byte, bit) (_SFR_BYTE(byte) &= ~_BV(bit))
#define SET(byte, bit) (_SFR_BYTE(byte) |= _BV(bit))


int main(void)
{
	// Set DDRBx to 1 for output, 0 for input
	DDRB = LLEG_MASK | RLEG_MASK | EN_MASK;
	
    while(1)
    {
		// Read & store current state
		char pinb = PORTB;
		
		if(bit_is_set(pinb, FWD) == bit_is_set(pinb, REV))
		{
			CLEAR(PORTB, EN);
			_delay_us(DELAY);
			
			// Set LLEG and RLLEG
			PORTB |= LLEG_MASK | RLEG_MASK;
			_delay_us(DELAY);
			
			SET(PORTB, EN);
		}
		else if (bit_is_set(pinb, FWD))	
		{
			CLEAR(PORTB, EN);
			_delay_us(DELAY);
			
			CLEAR(PORTB, LLEG);
			SET(PORTB, RLEG);
			_delay_us(DELAY);
			
			// TODO: pwmRamp();
		}
		else if (bit_is_set(pinb, REV))
		{
			CLEAR(PORTB, EN);
			_delay_us(DELAY);
			
			SET(PORTB, LLEG);
			CLEAR(PORTB, RLEG);
			_delay_us(DELAY);
			
			// TODO: pwmRamp();
		}
		
		// TODO: busy_wait();
		_delay_us(DELAY);
    }
}