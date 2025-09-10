#ifndef HAL_GPIO_h
#define HAL_GPIO_h

#include <avr/io.h>
#include "../../config/pin_config.h"

void HAL_GPIO_init(void);
void HAL_GPIO_write(void);
void HAL_GPIO_toggle(void);
uint8_t HAL_GPIO_read(void);

#endif