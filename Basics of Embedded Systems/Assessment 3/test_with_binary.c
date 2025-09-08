#include <avr/io.h>
#include <util/delay.h>

int main(void) {
  DDRD |= 0b00100000;
  DDRD |= 0b00000100;
  DDRD |= 0b10000000;

  PORTD &= ~0b00100000; // PD5
  PORTD |= 0b00000100; // PD2

  _delay_ms(1000);

  PORTD |= 0b00100000; // PD5
  PORTD &= ~0b00000100; // PD2

  while(1) {
    _delay_ms(300);
    PORTD ^= 0b10000000; // PD7
  }

  if(PIND & 0b00000100) return 0;
  return 1;
}