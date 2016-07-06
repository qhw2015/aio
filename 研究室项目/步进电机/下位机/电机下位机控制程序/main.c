
/*===================================================================================================  
�������ƣ�  Ex1
����������	����TFTʵ�ֺ��֣��ַ���ʾ���ͻ��㹦�ܡ�
Ӳ�����ӣ�  �鿴���޸Ľӿڶ�����NBCTFT.C��,����ϸ���ӿ����ߡ�
      ----------------------------------------
     |     --------TFT���ƽ���----------      |
     |	                                      |
     |	        D10~D17   ��   P0             |
     |          RS        ��   P2^5;	      |
     |			RW   	  ��   P2^4;          |
     |			RD        ��   P2^3;          |
     |		    CS        ��   P2^2;	      |
     |			RES       ��   P2^1;	      |
     |	                                      |
     |			LE        ��   P2^0;          |
     |                                        |
     |     --------��Դ�������---------      |
     |	        GND       ��   ��Դ����       |
     |	        VIN       ��   ��Դ����(5V)   |
      ----------------------------------------
ά����¼��  2015-11-13
====================================================================================================*/

//******************����ͷ�ļ�***************************

#include<reg52.h>    //������Ƭ��ͷ�ļ�
#include<intrins.h>
#include"NBCTFT.h"   //����TFT����ͷ�ļ�
//#include<function.h>
//******************ȫ�ֱ���***************************
//#define AT24C02	       0xa0  //AT24C02 ��ַ
#define White          0xFFFF   //LCD color
#define Black          0x0000
#define Blue           0x001F
#define Blue2          0x051F
#define Red            0xF800
#define Magenta        0xF81F
#define Green          0x07E0
#define Cyan           0x7FFF
#define Yellow         0xFFE0

sbit run=P1^2;
sbit direction_index=P1^3;
sbit modekey=P1^4;
sbit boardorcomputer=P1^5;
sbit direction=P2^6;
sbit motor=P2^7;
sbit microcontrol1=P3^2;

unsigned int Device_code;      //TFT����IC�ͺ�
unsigned char i=100,m,computer_char,computermode;
unsigned char pDat[8];
unsigned char rec,flag;
unsigned char num[]={'\0','\0','\0','\0'};
unsigned char display1[]={'0','1','2','3','4','5','6','7','8','9'};
unsigned char rec_line[]={'X','0','0','>','+','0','0','0','0','0','0','0','0','0','0'};
//**************�����ⲿ�����ͱ���********************

extern void delayms(unsigned int count);

//================================================================================================
//	�������ƣ�	������
//	ʵ�ֹ��ܣ�	����TFTʵ�ֺ��֣��ַ���ʾ.
//	������		��
//	����ֵ��	��
//================================================================================================
main()
{
//        unsigned char  run_computer,direction_index_computer;
		unsigned int x,y,z,di;
		float total,angle;
		
		Device_code=0x9320;                //TFT����IC�ͺ�
		
		TFT_Initial();                     //��ʼ��LCD
	   
		PCON=0x80;		 //���ò����ʼ������ж�
		SCON=0x50;
		TMOD=0x20;		 //T0��ʽ1
		TH1=0xF3;
		TL1=0xF3;
		IT0=1;
		IT1=1;
		TR1=1;
		EX1=1;
		EX0=1;
		ES=1;
		EA=1;	
		
		direction=1;
		Show_RGB(0,240,0,320,Blue);
		LCD_PutString(0,16,"        �� �� �� ѧ Ժ        ",White,Blue);
		LCD_PutString(0,40,"    ���չ�ѧ���ܻ�е�о���    ",White,Blue);
		LCD_PutString(0,72,"��ǰ�Ƕ� ",White,Blue);
		LCD_PutString(110,72,"��",White,Blue);
		LCD_PutString(0,88,"��ǰֵ",White,Blue);
		LCD_PutString(0,120,"����",White,Blue);
		LCD_PutString(0,152,"ģʽ",White,Blue);
		LCD_PutString(0,184,"״̬",White,Blue);
		LCD_PutString(0,304,"version 1,aiofm,hfcas",White,Blue);
		while(1)                                
		{	   
			LCD_PutChar(70,88,rec_line[11],White,Blue);
			LCD_PutChar(78,88,rec_line[12],White,Blue);
			LCD_PutChar(86,88,rec_line[13],White,Blue);
			LCD_PutChar(94,88,rec_line[14],White,Blue);		 

			total=(float)(((int)num[0])*1000+((int)num[1])*100+num[2]*10+((int)num[3])); //��ʾ��ǰ����
			angle=total/4095.0*360.0;
			x=((int)angle)/100;
			y=((int)angle)/10%10;
			z=((int)angle)%10;
			di=((int)(angle*10))%10;	  
				 
			LCD_PutChar(70,72,display1[x],White,Blue);		  //��ʾ��ǰ�Ƕ�
			LCD_PutChar(78,72,display1[y],White,Blue);
			LCD_PutChar(86,72,display1[z],White,Blue);
			LCD_PutChar(94,72,'.',White,Blue);
			LCD_PutChar(102,72,display1[di],White,Blue);
			if(boardorcomputer==1)
				{			
						if(run==0)
						{	
							LCD_PutString(40,184,"����",White,Blue);	
							TH0 = (8192 - 200)/32	;  //��������װ��ֵ
							TL0 = (8192 - 200)%32	;	 
							ET0=1;
							TR0=1;
						}
						else
						{
							LCD_PutString(40,184,"ֹͣ",White,Blue);
							ET0 = 0;       
							TR0 = 0;
							motor=0;
						}
						if(direction_index==1)
						{
							LCD_PutString(40,120,"��ʱ��",White,Blue);
							direction=0;
						}
						else
						{
							LCD_PutString(40,120,"˳ʱ��",White,Blue);
							direction=1;
						}
						if(modekey==1)
						{
							LCD_PutString(40,152,"����",White,Blue);
						}
						else
						{
							LCD_PutString(40,152,"΢��",White,Blue);
						}	
			
				}
				else
				{
					switch(computer_char)
					{
					   case 0xff:
					   {
							LCD_PutString(40,184,"����",White,Blue);	
							TH0 = (8192 - 200)/32	;  //��������װ��ֵ
							TL0 = (8192 - 200)%32	;	 
							ET0=1;
							TR0=1;
					   		break;
					   }
					   case 0x00:
					   {
					   		LCD_PutString(40,184,"ֹͣ",White,Blue);
							ET0 = 0;       
							TR0 = 0;
							motor=0;
							break;
						}
						case 0xf0:
						{
							LCD_PutString(40,120,"��ʱ��",White,Blue);
							direction=0;
							break;
						}
						case 0x0f:
						{
							LCD_PutString(40,120,"˳ʱ��",White,Blue);
							direction=1;
							break;
						}
						case 0x30:
						{
							computermode=0;
							LCD_PutString(40,152,"����",White,Blue);
							break;
						}
						case 0x03:
						{
							computermode=1;
							LCD_PutString(40,152,"΢��",White,Blue);
							break;
						}
					   defult:break;
					}
				}
		}
}

void ser_int(void) interrupt 4 //using 1
{
	
	
	 if(RI == 1)        //RI�����жϱ�־
	 {
		 if(boardorcomputer==1)
		 {
				rec = SBUF;  //SUBF����/���ͻ�����
				if(rec=='X')
				{
					i=0;
				}
				switch(i)
				{
					case 11:
					{
						rec_line[i]=rec;
						num[0]=rec-48;
						break;
					}
					case 12:
					{
						rec_line[i]=rec;
						num[1]=rec-48;
						break;
					}
					case 13:
					{
						rec_line[i]=rec;
						num[2]=rec-48;
						break;
					}
					case 14:
					{
						rec_line[i]=rec;
						num[3]=rec-48;
						break;
					}
					defult:break;
				}
				RI = 0;				 
				i++;
		}
		else
		{
			rec = SBUF;
			computer_char=rec;
			if(rec==0x88)
			{
				if(computermode==1)
				{
					motor=1;
					_nop_();
					_nop_();
					_nop_();
					_nop_();
					_nop_();
					motor=0;
					_nop_();
					_nop_();
					_nop_();
					_nop_();
					_nop_();
				}
			}
			rec=0;
			RI=0;
		}	   
	}
}

void Timer0() interrupt 1
{
   TH0 = (8192 - 200)/32	;  //��������װ��ֵ
   TL0 = (8192 - 200)%32	;
   motor = ~motor;//	}
}

void run_one() interrupt 0			   //3 Ϊ��ʱ��1���жϺ�  1 ��ʱ��0���жϺ� 0 �ⲿ�ж�1 2 �ⲿ�ж�2  4 �����ж�
{
	unsigned int delay_count=200;
	while(delay_count--);
	if(microcontrol1==0)
	{
		if(modekey==0)
		{
			motor=1;
//			_nop_();
//			_nop_();
//			_nop_();
//			_nop_();
//			_nop_();
		}
	}
}
void run_ten() interrupt 2
{
	if(modekey==0)
	{	
		motor=1;
	}
}
