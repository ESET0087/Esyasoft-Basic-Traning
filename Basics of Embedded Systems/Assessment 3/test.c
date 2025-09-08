#include <avr/io.h>
#include <util/delay.h>

#define RED PD5
#define GREEN PD2
#define YELLOW PD7

int main(void) {
  DDRD |= (1 << RED);
  DDRD |= (1 << GREEN);
  DDRD |= (1 << YELLOW);

  // initially red LED is off and green LED is on
  PORTD &= ~(1<<RED);
  PORTD |= (1<<GREEN);

  // delay to see initial value of each LED
  _delay_ms(1000); 
  
  // red LED is always ON and green in always OFF
  PORTD |= (1<<RED);
  PORTD &= ~(1<<GREEN);

  // infinite toggling of yellow LED
  while(1) {
    _delay_ms(300);
    PORTD ^= (1<<YELLOW);
  }

  if(PIND & (1 << GREEN)) return 0;
  return 1;
}