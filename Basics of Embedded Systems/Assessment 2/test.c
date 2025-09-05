#include <avr/io.h>
#include <util/delay.h>

#define LED_PIN PD6 // set led pin at 6
#define SWITCH_PIN PD7 // set switch pin at 7

int main(void){
    // setting PD6 as led output
    DDRD |= (1 << LED_PIN);

    // setting PD7 as switch input
    DDRD &= ~(1 << SWITCH_PIN);

    // Enables pull up register
    PORTD |= (1 << SWITCH_PIN);

    while(1){
        if (!(PIND & (1 << SWITCH_PIN))) {
            // LED on
            PORTD |= (1 << LED_PIN);
            _delay_ms(500); // 500ms delay

            // LED off
            PORTD &= ~(1 << LED_PIN);
            _delay_ms(500); // 500ms delay
        }
        else {
            PORTD &= ~(1 << LED_PIN);
        }
    }
}