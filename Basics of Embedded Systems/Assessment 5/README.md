# Project Structure and HAL

When Button is pressed LED should toggle between ON and OFF.  
Followed project structure.

# Project structure
    .
    ├── src/
    │   ├── hal/
    │   │   ├── hal_gpio.h
    │   │   └── hal_gpio.c
    │   ├── main.c
    ├── config/
    │   ├── pin_config.h

# Files

pin_config.h : Configures PD6 as LED output and PD7 as switch input with pull-up resistor.  
hal_gpio.c and hal_gpio.h : Contains the functions for initiating LED as output and switch as input, reading the switch state and toggling LED with 500ms delay.  
main.c : Our main code which shows hardware abstraction.
