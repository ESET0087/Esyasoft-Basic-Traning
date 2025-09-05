# Problem Statement

When Button is kept pressed LED should blink at interval of 0.5s else it should be off

# Hardware Setup

Microcoltroller: Arduino UNO

LED: Connected to PD6 (Digital Pin 6)

Switch: Connected to PD7 (Digital Pin 7) with pull-up resistor

# How It Works

The if(!(PIND & (1 << SWITCH_PIN))) condition detects button press and delay creates blink. Else LED is turned off.

