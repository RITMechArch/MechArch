avr-gcc -g -DF_CPU=9600000 -Wall -Os -mmcu=attiny13a -c -o tmp.o blink.c
avr-gcc -g -DF_CPU=9600000 -Wall -Os -mmcu=attiny13a -o tmp.elf tmp.o
avr-size tmp.elf
avr-objcopy -j .text -j .data -O ihex tmp.elf tmp.hex