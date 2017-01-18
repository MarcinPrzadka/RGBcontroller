#define F_CPU 8000000
#define FOSC 1843200 
#define BAUD 9600
#define MYUBRR ((F_CPU+BAUD*8UL) / (16UL*BAUD)-1) 

#include <avr/io.h>
#include <util/delay.h>
#include <avr/interrupt.h>


extern volatile uint8_t pwmR, pwmG, pwmB;

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
    
	unsigned char m;
	char t[10];
	int p = 0;
//	do{
		while( !(UCSRA & (1<<RXC)) );
	 //	if(UDR >= ' '){
   	//		t[p] = UDR;
	//		p=p+1;
	//		t[p] = '\0';
	//	}
//	}while(UDR != '\r');
	
	if(strncmp(t, "r",1) == 0) pwmR = t[2] - '0'; 
//	if(strncmp(t, "g ",2) == 0) pwmG = t[2] - '0'; 
//	if(strncmp(t, "b ",2) == 0) pwmB = t[2] - '0'; 
//	if(t[0] == "r") pwmR = 200;
		
	return UDR; 

	

}

volatile uint8_t pwmR, pwmG, pwmB;

ISR( TIMER2_COMP_vect ) // cia³o procedury obs³ugi przerwania Compare Match Timera2
{
	static uint8_t cnt; // definicja naszego licznika PWM

	// bezpoœrednie sterowanie wyjœciami kana³ów PWM
	if(cnt>=pwmR) PORTC |= (1<<PC0); else PORTC &= ~(1<<PC0);
	if(cnt>=pwmG) PORTC |= (1<<PC1); else PORTC &= ~(1<<PC1);
	if(cnt>=pwmB) PORTC |= (1<<PC2); else PORTC &= ~(1<<PC2);
	cnt++;	// zwiêkszanie licznika o 1
}


int main(void){

	USART_Init(MYUBRR);
	unsigned char data;
	unsigned size[10];
	
	//***** SPRZÊTOWY PWM - 1 KANA£ OC0 (PB2) *******
	DDRB |= (1<<PB2); // ustawienie koñcówki OC0 (PB2) sprzêtowy PWM jako WYJŒCIE
	TCCR0 |= (1<<WGM10)|(1<<WGM12);		// tryb Fast PWM
	TCCR0 |= (1<<COM21);				// clear at TOP
	TCCR0 |= (1<<CS00);					// preskaler = 1
	OCR1A=255;							// wygaszenie diody w kanale PWM
	DDRC |= (1<<PC0)|(1<<PC1)|(1<<PC2); // ustawienie pinów kana³ów programowych PWM jako WYJŒCIA
	PORTC |= (1<<PC0)|(1<<PC1)|(1<<PC2); // wy³¹czenie diod LED pod³¹czonych katodami do wyjœæ
	
	TCCR2 |= (1<<WGM21);	// tryb  CTC
	TCCR2 |= (1<<CS20);		// preskaler = 1
	OCR2 = 199;				// dodatkowy podzia³ czêsttotliwoœci przez 200
	TIMSK |= (1<<OCIE2);	// zezwolenie na przerwanie CompareMatch
	sei();				// odblokowanie globalne przerwañ
	
 	pwmR=0;
	pwmG=0;
	pwmB=0;
	

	while(1){
		data = USART_Receive();
		USART_Transmit(data);	
			
		}
}


