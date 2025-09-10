#include "hal_gpio.h"
#include <util/delay.h>

void HAL_GPIO_init(void){
    // setting PD6 as led output
    DDRD |= (1 << LED_PIN);

    // setting PD7 as switch input
    DDRD &= ~(1 << SWITCH_PIN);
}

void HAL_GPIO_write(void){
    // Enables pull up register
    PORTD |= (1 << SWITCH_PIN);
}

void HAL_GPIO_toggle(void){
    PORTD ^= (1 << LED_PIN);
    _delay_ms(500);
}

uint8_t HAL_GPIO_read(void){
    return (PIND & (1 << SWITCH_PIN)) ? 0 : 1;
}