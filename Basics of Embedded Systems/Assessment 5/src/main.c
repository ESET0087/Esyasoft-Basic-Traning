#include "hal/hal_gpio.h"

int main(void){
    HAL_GPIO_init();

    HAL_GPIO_write();

    while(1){
        if (HAL_GPIO_read()) {
            HAL_GPIO_toggle();
        }
    }

    return 0;
}