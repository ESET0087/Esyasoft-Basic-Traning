#include "hal_gpio.h"

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

void LED_ON(void){
    PORTD |= (1 << LED_PIN);
}

void LED_OFF(void){
    PORTD &= ~(1 << LED_PIN);
}

void LED_blink(int ms){
    LED_ON();
    _delay_ms(ms);
    LED_OFF();
    _delay_ms(ms);
}

uint8_t HAL_GPIO_read(void){
    // reads the button state, returns 1 if pressed, 0 if not pressed
    return (PIND & (1 << SWITCH_PIN)) ? 0 : 1;
}

void LED_Cycle_operation(void) {
    static uint8_t mode = 0; // 0: off, 1: slow blink, 2: fast blink, 3: on
    static uint8_t lastButtonState = 0;
    
    while(1) {
        uint8_t buttonState = HAL_GPIO_read();

        if (buttonState && !lastButtonState) {
            _delay_ms(50); // Debounce delay
            mode = (mode + 1) % 4; // Cycle through modes
        }
        lastButtonState = buttonState;

        switch(mode) {
            case 0:  // LED Off
                LED_OFF();
                _delay_ms(10);
                break;
                
            case 1:  // Slow Blink (500ms)
                LED_blink(500);
                break;
                
            case 2:  // Fast Blink (100ms)
                LED_blink(100);
                break;
                
            case 3:  // LED On
                LED_ON();
                _delay_ms(10);
                break;    
        }
    }
}