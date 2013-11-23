/*
 * ATTiny.c
 *
 * Created: 10/13/2013 2:42:22 PM
 *  Author: Dustin Stroup
 */ 

#ifdef DEBUG
#define F_CPU 20000000UL /* Clock Frequency = 20Mhz */
#endif

#include <avr/io.h>
#include <util/delay.h>

// Inputs
#define FWD      PINB3
#define FWD_MASK 0b00001000
#define REV      PINB4
#define REV_MASK 0b00010000

#define INPUTS  (FWD_MASK | REV_MASK)

// Output
#define M1      PORTB5
#define M1_MASK 0b00100000
#define M2      PORTB2
#define M2_MASK 0b00000100
#define M3      PORTB0
#define M3_MASK 0b00000001
#define M4      PORTB1
#define M4_MASK 0b00000010

#define PMOS    (M1_MASK | M2_MASK)
#define NMOS    (M3_MASK | M4_MASK)

// Other
#define DELAY 100 // us
#define BIT_SET(BYTE, BIT) (bit_is_set(BYTE, BIT) != 0)

void busy_wait()
{
	char pinb;
	
	do 
	{
		pinb = PINB;
	//} while ( (bit_is_set(pinb, FWD) == 0) != (bit_is_set(pinb, REV) == 0));
	}while ( BIT_SET(pinb, FWD) != BIT_SET(pinb, REV));
	
}

int main(void)
{
	// Set DDRBx to 1 for output, 0 for input
	DDRB = M1_MASK | M2_MASK | M3_MASK | M4_MASK;
	
	// Set initial state of the bridge, without crowbaring
	PORTB &= ~(PMOS);
	_delay_us(DELAY);
	PORTB |= (PMOS);
	_delay_us(DELAY);
	PORTB |= (NMOS);
	
	while(1)
	{
		// Read & store current state
		char pinb = PINB;
		
		//if((bit_is_set(pinb, FWD) == 0) == (bit_is_set(pinb, REV) == 0))
		if(BIT_SET(pinb, FWD) == BIT_SET(pinb, REV))
		{
			// Do braking 
			
			// Shut off both PMOS
			PORTB |= (PMOS);
			_delay_us(DELAY);
			
			// Turn on both NMOS
			PORTB |= (NMOS);
		}
		else if (BIT_SET(pinb, FWD))	
		{
			// Go forward 
			
			// Turn off both NMOS
			PORTB &= ~(NMOS);
			_delay_us(DELAY);
			
			// Turn on M2 PMOS
			PORTB &= ~(M2_MASK);
			_delay_us(DELAY);
			
			// Turn on opposite NMOS
			PORTB |= (M3_MASK);
			busy_wait();
		}
		else if (BIT_SET(pinb, REV))
		{
			// Go reverse
			
			// Turn off both NMOS
			PORTB &= ~(NMOS);
			_delay_us(DELAY);
			
			// Turn on M1 PMOS
			PORTB &= ~(M1_MASK);
			_delay_us(DELAY);
			
			// Turn on opposite NMOS
			PORTB |= (M4_MASK);
			busy_wait();
		}
	}
}