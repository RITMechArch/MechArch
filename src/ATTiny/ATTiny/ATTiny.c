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

// - GPIO
#define M1        PORTB5
#define M1_MASK   0b00100000
#define M2        PORTB2
#define M2_MASK   0b00000100
// - TODO: PWM
#define M3        PORTB0
#define M3_MASK   0b00000001
#define M4        PORTB1
#define M4_MASK   0b00000010

// Other
#define DELAY 50 // us TODO: Reasonable delay?

void pwmRamp(int pin)
{
		// TODO: PWM RAMP
}

void busy_wait()
{
	char pinb;
	
	do 
	{
		 pinb = PORTB;
	} while (bit_is_set(pinb, FWD) == bit_is_set(pinb, REV));
	
}

int main(void)
{
	// Set DDRBx to 1 for output, 0 for input
	DDRB = M1_MASK | M2_MASK | M3_MASK | M4_MASK;
	
    while(1)
    {
		// Read & store current state
		char pinb = PORTB;
		
		if(bit_is_set(pinb, FWD) == bit_is_set(pinb, REV))
		{
			// Set M1 & M2 (Shut off both PMOS)
			PORTB |= (M1_MASK | M2_MASK);
			_delay_us(DELAY);
			
			// TODO: PWM (Turn on both NMOS)
			// M3 = 255
			// M4 = 255
		}
		else if (bit_is_set(pinb, FWD))	
		{
			// TODO: PWM (Turn off both NMOS)
			// M3 = 0
			// M4 = 0
			_delay_us(DELAY);
			
			// Clear M2 (Turn on M2 PMOS)
			PORTB &= ~(M2_MASK);
			_delay_us(DELAY);
			
			pwmRamp(M3);
			busy_wait();
		}
		else if (bit_is_set(pinb, REV))
		{
			// TODO: PWM (Turn off both NMOS)
			// M3 = 0
			// M4 = 0
			_delay_us(DELAY);
			
			// Clear M1 (Turn on M1 PMOS)
			PORTB &= ~(M3_MASK);
			_delay_us(DELAY);
			
			pwmRamp(M4);
			busy_wait();
		}
    }
}