# Problem

Operate LED in 3 mode cycle using a single button.  
Mode 1: LED blinks slowly.  
Mode 2: LED blinks fast.  
Mode 3: LED always on.

HAL based project build for LED and button control setup.

# Setup

pin_config.h : Configures PD6 as LED output and PD7 as switch input with pull-up resistor.  

hal_gpio.c : Contains the functions for initiating LED as output and switch as input, reading the switch state, turing LED ON, OFF and blink with desired delay for speed control of blinking and logic for 3 mode operation of LED using single button.  

main.c : Our main code which shows hardware abstraction.