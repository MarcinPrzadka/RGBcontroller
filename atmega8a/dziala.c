#define F_CPU 8000000
#define FOSC 1843200 
#define BAUD 9600
#define MYUBRR ((F_CPU+BAUD*8UL) / (16UL*BAUD)-1) 

#define LED_PIN_R (1<<PC0)
#define LED_PIN_G (1<<PC1)
#define LED_PIN_B (1<<PC2)

#define LED_ON_R PORTC &= ~LED_PIN_R
#define LED_OFF_R PORTC |= LED_PIN_R

#define LED_ON_G PORTC &= ~LED_PIN_G
#define LED_OFF_G PORTC |= LED_PIN_G

#define LED_ON_B PORTC &= ~LED_PIN_B
#define LED_OFF_B PORTC |= LED_PIN_B

#include <avr/io.h>
#include <util/delay.h>

void USART_Init( uint16_t baud){
	UBRRH = (uint16_t)(baud>>8);
	UBRRL = (uint16_t)baud;
	UCSRB = (1<<RXEN)|(1<<TXEN);
	UCSRC = (1<<URSEL)|(3<<UCSZ0);
}

void USART_Transmit( char buflen) {
	while( !(UCSRA & (1<<UDRE)) );
	UDR = buflen;
}
	
unsigned char USART_Receive( void ){
   while( !(UCSRA & (1<<RXC)) );
   return UDR;
}

int main(void){
	USART_Init(MYUBRR);
	unsigned char data;

	DDRC |= LED_PIN_R;
	DDRC |= LED_PIN_G;
	DDRC |= LED_PIN_B;
	LED_OFF_R;
	LED_OFF_G;
	LED_OFF_B;

	while(1){
		data = USART_Receive();
		USART_Transmit(data);
		if(data == '1' ) LED_ON_R;
		if(data == '4' ) LED_OFF_R;
		if(data == '2' ) LED_ON_G;
		if(data == '5' ) LED_OFF_G;
		if(data == '3' ) LED_ON_B;
		if(data == '6' ) LED_OFF_B;
	//	LED_TOG;
	//	_delay_ms(10000);
	}
}


