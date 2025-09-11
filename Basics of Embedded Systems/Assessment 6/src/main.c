#include "hal/hal_gpio.h"

int main(void){
    HAL_GPIO_init();
    
    HAL_GPIO_write();

    LED_Cycle_operation(); // main logic for 3 mode operation using single button

    return 0;
}