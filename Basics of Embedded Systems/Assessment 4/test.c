#include <avr/io.h>
#include <util/delay.h>

#define LCD_PIND7 PD7
#define LCD_PIND6 PB0
#define LCD_PIND5 PB1
#define LCD_PIND4 PB2
#define ENABLE PB3
#define LCD_RS PB4

void lcd_pulse(){
  PORTB |= (1 << ENABLE);
  _delay_ms(1);
  PORTB &= ~(1 << ENABLE);
  _delay_ms(2);
}

void lcd_command(unsigned char cmd){
  PORTB &= ~(1 << LCD_RS); // RS = 0 for command

  // send higher nibble
  (cmd & 0x10) ? (PORTB |= (1 << LCD_PIND4)) : (PORTB &= ~(1 << LCD_PIND4));
  (cmd & 0x20) ? (PORTB |= (1 << LCD_PIND5)) : (PORTB &= ~(1 << LCD_PIND5));
  (cmd & 0x40) ? (PORTB |= (1 << LCD_PIND6)) : (PORTB &= ~(1 << LCD_PIND6));
  (cmd & 0x80) ? (PORTD |= (1 << LCD_PIND7)) : (PORTD &= ~(1 << LCD_PIND7));
  lcd_pulse();

  // send low nibble
  (cmd & 0x01) ? (PORTB |= (1 << LCD_PIND4)) : (PORTB &= ~(1 << LCD_PIND4));
  (cmd & 0x02) ? (PORTB |= (1 << LCD_PIND5)) : (PORTB &= ~(1 << LCD_PIND5));
  (cmd & 0x04) ? (PORTB |= (1 << LCD_PIND6)) : (PORTB &= ~(1 << LCD_PIND6));
  (cmd & 0x08) ? (PORTD |= (1 << LCD_PIND7)) : (PORTD &= ~(1 << LCD_PIND7));
  lcd_pulse();
}

void lcd_data(unsigned char data){
  PORTB |= (1 << LCD_RS); // RS = 1 for data

  // send higher nibble
  (data & 0x10) ? (PORTB |= (1 << LCD_PIND4)) : (PORTB &= ~(1 << LCD_PIND4));
  (data & 0x20) ? (PORTB |= (1 << LCD_PIND5)) : (PORTB &= ~(1 << LCD_PIND5));
  (data & 0x40) ? (PORTB |= (1 << LCD_PIND6)) : (PORTB &= ~(1 << LCD_PIND6));
  (data & 0x80) ? (PORTD |= (1 << LCD_PIND7)) : (PORTD &= ~(1 << LCD_PIND7));
  lcd_pulse();

  // send low nibble
  (data & 0x01) ? (PORTB |= (1 << LCD_PIND4)) : (PORTB &= ~(1 << LCD_PIND4));
  (data & 0x02) ? (PORTB |= (1 << LCD_PIND5)) : (PORTB &= ~(1 << LCD_PIND5));
  (data & 0x04) ? (PORTB |= (1 << LCD_PIND6)) : (PORTB &= ~(1 << LCD_PIND6));
  (data & 0x08) ? (PORTD |= (1 << LCD_PIND7)) : (PORTD &= ~(1 << LCD_PIND7));
  lcd_pulse();
}

void lcd_init() {
  DDRB = 0xFF;
  DDRD |= (1 << LCD_PIND7);

  _delay_ms(200);  // wait for lcd power on

  lcd_command(0x02); // 4 bit mode
  lcd_command(0x28); // 2 line, 5x7 matrix
  lcd_command(0x0C); // display on, cursor off
  lcd_command(0x06); // increment cursor
  lcd_command(0x01); // clear screen

  _delay_ms(20);
}

// printing string
void lcd_print(const char *str){
  while(*str){
    lcd_data(*str++);
  }
}

int main(void) {
  lcd_init();

  lcd_command(0x80);
  lcd_print("Hello World!");

  lcd_command(0xC0);
  lcd_print("LCD Working :)");
}


 