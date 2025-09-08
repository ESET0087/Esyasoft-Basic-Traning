# Problem

Set bit 5
Clear bit 2
Toggle bit 7
Return 1 if bit 2 is set, else 0

# PIN Configuration

Red LED: PD5
Green LED: PD2
Yellow LED: PD7

# Behavior

Initial state: Red LED off, Green LED on

After 1 second delay: Red LED turns on, Green LED turns off

Yellow LED toggles continuously every 300ms in an infinite loop

The program checks if the Green LED is on before exiting.