# LCD Display Control

## Overview
This project controls a 16x2 LCD display using an AVR microcontroller in 4-bit mode.

## Pin Connections
LCD D4 -> PB2  
LCD D5 -> PB1  
LCD D6 -> PB0  
LCD D7 -> PD7  
LCD E -> PB3  
LCD RS -> PB4

## Functions

lcd_pulse(): Toggles Enable pin  
lcd_command(): Sends commands to LCD  
lcd_data(): Sends data to LCD  
lcd_init(): Initializes LCD  
lcd_print(): Displays strings

## Usage

LCD will display:  
Line 1: "Hello World!"  
Line 2: "LCD Working :)"