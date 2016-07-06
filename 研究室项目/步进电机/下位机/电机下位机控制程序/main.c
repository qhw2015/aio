
/*===================================================================================================  
工程名称：  Ex1
功能描述：	控制TFT实现汉字，字符显示，和画点功能。
硬件连接：  查看和修改接口定义在NBCTFT.C中,请仔细检查接口连线。
      ----------------------------------------
     |     --------TFT控制接线----------      |
     |	                                      |
     |	        D10~D17   接   P0             |
     |          RS        接   P2^5;	      |
     |			RW   	  接   P2^4;          |
     |			RD        接   P2^3;          |
     |		    CS        接   P2^2;	      |
     |			RES       接   P2^1;	      |
     |	                                      |
     |			LE        接   P2^0;          |
     |                                        |
     |     --------电源供电接线---------      |
     |	        GND       接   电源负极       |
     |	        VIN       接   电源正极(5V)   |
      ----------------------------------------
维护记录：  2015-11-13
====================================================================================================*/

//******************包含头文件***************************

#include<reg52.h>    //包含单片机头文件
#include<intrins.h>
#include"NBCTFT.h"   //包含TFT驱动头文件
//#include<function.h>
//******************全局变量***************************
//#define AT24C02	       0xa0  //AT24C02 地址
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

unsigned int Device_code;      //TFT控制IC型号
unsigned char i=100,m,computer_char,computermode;
unsigned char pDat[8];
unsigned char rec,flag;
unsigned char num[]={'\0','\0','\0','\0'};
unsigned char display1[]={'0','1','2','3','4','5','6','7','8','9'};
unsigned char rec_line[]={'X','0','0','>','+','0','0','0','0','0','0','0','0','0','0'};
//**************声明外部函数和变量********************

extern void delayms(unsigned int count);

//================================================================================================
//	函数名称：	主函数
//	实现功能：	控制TFT实现汉字，字符显示.
//	参数：		无
//	返回值：	无
//================================================================================================
main()
{
//        unsigned char  run_computer,direction_index_computer;
		unsigned int x,y,z,di;
		float total,angle;
		
		Device_code=0x9320;                //TFT控制IC型号
		
		TFT_Initial();                     //初始化LCD
	   
		PCON=0x80;		 //设置波特率及串口中断
		SCON=0x50;
		TMOD=0x20;		 //T0方式1
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
		LCD_PutString(0,16,"        中 国 科 学 院        ",White,Blue);
		LCD_PutString(0,40,"    安徽光学精密机械研究所    ",White,Blue);
		LCD_PutString(0,72,"当前角度 ",White,Blue);
		LCD_PutString(110,72,"度",White,Blue);
		LCD_PutString(0,88,"当前值",White,Blue);
		LCD_PutString(0,120,"方向",White,Blue);
		LCD_PutString(0,152,"模式",White,Blue);
		LCD_PutString(0,184,"状态",White,Blue);
		LCD_PutString(0,304,"version 1,aiofm,hfcas",White,Blue);
		while(1)                                
		{	   
			LCD_PutChar(70,88,rec_line[11],White,Blue);
			LCD_PutChar(78,88,rec_line[12],White,Blue);
			LCD_PutChar(86,88,rec_line[13],White,Blue);
			LCD_PutChar(94,88,rec_line[14],White,Blue);		 

			total=(float)(((int)num[0])*1000+((int)num[1])*100+num[2]*10+((int)num[3])); //显示当前读数
			angle=total/4095.0*360.0;
			x=((int)angle)/100;
			y=((int)angle)/10%10;
			z=((int)angle)%10;
			di=((int)(angle*10))%10;	  
				 
			LCD_PutChar(70,72,display1[x],White,Blue);		  //显示当前角度
			LCD_PutChar(78,72,display1[y],White,Blue);
			LCD_PutChar(86,72,display1[z],White,Blue);
			LCD_PutChar(94,72,'.',White,Blue);
			LCD_PutChar(102,72,display1[di],White,Blue);
			if(boardorcomputer==1)
				{			
						if(run==0)
						{	
							LCD_PutString(40,184,"运行",White,Blue);	
							TH0 = (8192 - 200)/32	;  //给计数器装初值
							TL0 = (8192 - 200)%32	;	 
							ET0=1;
							TR0=1;
						}
						else
						{
							LCD_PutString(40,184,"停止",White,Blue);
							ET0 = 0;       
							TR0 = 0;
							motor=0;
						}
						if(direction_index==1)
						{
							LCD_PutString(40,120,"逆时针",White,Blue);
							direction=0;
						}
						else
						{
							LCD_PutString(40,120,"顺时针",White,Blue);
							direction=1;
						}
						if(modekey==1)
						{
							LCD_PutString(40,152,"常规",White,Blue);
						}
						else
						{
							LCD_PutString(40,152,"微调",White,Blue);
						}	
			
				}
				else
				{
					switch(computer_char)
					{
					   case 0xff:
					   {
							LCD_PutString(40,184,"运行",White,Blue);	
							TH0 = (8192 - 200)/32	;  //给计数器装初值
							TL0 = (8192 - 200)%32	;	 
							ET0=1;
							TR0=1;
					   		break;
					   }
					   case 0x00:
					   {
					   		LCD_PutString(40,184,"停止",White,Blue);
							ET0 = 0;       
							TR0 = 0;
							motor=0;
							break;
						}
						case 0xf0:
						{
							LCD_PutString(40,120,"逆时针",White,Blue);
							direction=0;
							break;
						}
						case 0x0f:
						{
							LCD_PutString(40,120,"顺时针",White,Blue);
							direction=1;
							break;
						}
						case 0x30:
						{
							computermode=0;
							LCD_PutString(40,152,"常规",White,Blue);
							break;
						}
						case 0x03:
						{
							computermode=1;
							LCD_PutString(40,152,"微调",White,Blue);
							break;
						}
					   defult:break;
					}
				}
		}
}

void ser_int(void) interrupt 4 //using 1
{
	
	
	 if(RI == 1)        //RI接受中断标志
	 {
		 if(boardorcomputer==1)
		 {
				rec = SBUF;  //SUBF接受/发送缓冲器
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
   TH0 = (8192 - 200)/32	;  //给计数器装初值
   TL0 = (8192 - 200)%32	;
   motor = ~motor;//	}
}

void run_one() interrupt 0			   //3 为定时器1的中断号  1 定时器0的中断号 0 外部中断1 2 外部中断2  4 串口中断
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
