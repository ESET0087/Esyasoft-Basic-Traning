#ifndef HAL_GPIO_h
#define HAL_GPIO_h

#include <avr/io.h>
#include <util/delay.h>
#include "../../config/pin_config.h"

void HAL_GPIO_init(void);
void HAL_GPIO_write(void);
uint8_t HAL_GPIO_read(void);
void LED_blink(int ms);
void LED_ON(void);
void LED_OFF(void);
void LED_Cycle_operation(void);

#endif