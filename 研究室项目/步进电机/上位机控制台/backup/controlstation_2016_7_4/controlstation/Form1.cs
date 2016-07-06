using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
//using Microsoft.VisualBasic;

namespace controlstation
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        string FileName = System.AppDomain.CurrentDomain.BaseDirectory + "data.txt";
        int dcount = 0;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] send_command2 = new byte[1];
            if (serialPort2.IsOpen)
            {
                try
                {

                    send_command2[0] = 0x0f;
                    serialPort2.Write(send_command2, 0, 1);
                    //                        serialPort1.WriteLine(textBox1.Text);  //这种写法发送的是字符串形式，发送数据时最后会加上'/0'
                }
                catch (Exception err)
                { }
            }
            else
            {
                MessageBox.Show("通信串口未打开", "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] send_command1 = new byte[1];
            if (serialPort2.IsOpen)
            {
                try
                {

                    send_command1[0] = 0xf0;
                    serialPort2.Write(send_command1, 0, 1);
                    //                        serialPort1.WriteLine(textBox1.Text);  //这种写法发送的是字符串形式，发送数据时最后会加上'/0'
                }
                catch (Exception err)
                { }
            }
            else
            {
                MessageBox.Show("通信串口未打开", "提示");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usedserial;
            usedserial = comboBox_code.Text;
            comboBox_com.Items.Remove(usedserial);
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch
                { }
               
                    button_opencode.Text = "开编码器串口";
                    ovalShape_com.BackgroundImage = null;
                    button_scan.Enabled = true;
                    comboBox_code.Enabled = true;
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox_code.Text;
                    serialPort1.Open();
                    button_opencode.Text = "关编码器串口";
                    ovalShape_com.BackgroundImage = Properties.Resources.red;
                    button_scan.Enabled = false;
                    comboBox_code.Enabled = false;
                }
                catch 
                {
                    MessageBox.Show("串口打开失败！", "错误");
                }
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchAndAddSerialToCombobox(serialPort1,comboBox_code);
            SearchAndAddSerialToCombobox(serialPort2, comboBox_com);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }
        private void port_DataReceived(object sender,SerialDataReceivedEventArgs e)
        {
                try
                {dcount++;
                string str = serialPort1.ReadExisting();
                textBox_receive.AppendText(str);
                if (dcount == 3) { 
                string tstr = textBox_receive.Text;
                    string mystring = "    ";
                    char[] mychars = mystring.ToCharArray();
                    textBox_receive.Text = ""; dcount = 0;
                    for (int i = 0; i < tstr.Length;i++)
                    {
                        if (tstr[i] == 'X')
                        {
                            mychars[0] = tstr[i + 11];
                            mychars[1] = tstr[i + 12];
                            mychars[2] = tstr[i + 13];
                            mychars[3] = tstr[i + 14];
                            string s = new string(mychars);
                            textBox_codenum.Text=s;
                            int codenum = Convert.ToInt16(s);
                            float angle = ((float)codenum) / 4096 * 360;
                            string anglestring = string.Format("{0:f1}", angle);
                            textBox_currentangle.Text = anglestring + "°";
                        }
                    }
                   
                }       
                }
                catch 
                {}
            }
        private void SearchAndAddSerialToCombobox(SerialPort Myport,ComboBox Mybox)
        {
            string Buffer;
            Mybox.Items.Clear();
            for (int i = 1; i < 20;i++ )
            {
                try
                {
                    Buffer = "COM" + i.ToString();
                    Myport.PortName = Buffer;
                    Myport.Open();
                    Mybox.Items.Add(Buffer);
                    Myport.Close();
                }
                catch
                { }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchAndAddSerialToCombobox(serialPort1, comboBox_code);
            SearchAndAddSerialToCombobox(serialPort2, comboBox_com);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //发送数据
        {
                byte[] Data = new byte[1];
                if (serialPort1.IsOpen)
                {
                    if (textBox_send.Text != "")
                    {
                            try
                            {
                                string str = textBox_send.Text;
                                for (int i = 0; i < str.Length; i++)
                                {
                                    serialPort1.Write(textBox_send.Text.Substring(i, 1));//按字符形式发送
                                }
                            }
                            catch (Exception err)
                            {
                                
                                serialPort1.Close();
                                button_opencode.Text = "打开通信串口";
                                ovalShape_com.BackgroundImage = null;
                                button_scan.Enabled = true;
                                comboBox_code.Enabled = true;
                                MessageBox.Show("通信串口数据写入错误", "错误");
                            }
                    }
                }
                else
                {
                    MessageBox.Show("通信串口未打开","提示");
                }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string usedserial;
            usedserial = comboBox_com.Text;
            comboBox_code.Items.Remove(usedserial);
            if (serialPort2.IsOpen)
            {
                try
                {
                    serialPort2.Close();
                }
                catch
                { }

                button_opencom.Text = "打开通信串口";
                ovalShape_code.BackgroundImage = null;
                comboBox_com.Enabled = true;
            }
            else
            {
                try
                {
                    serialPort2.PortName = comboBox_com.Text;
                    serialPort2.Open();
                    button_opencom.Text = "关闭通信串口";
                    ovalShape_code.BackgroundImage = Properties.Resources.red;
                    comboBox_com.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("编码器串口打开失败！", "错误");
                }
            }

        }
        private void textBox_codenum_TextChanged(object sender, EventArgs e)//保存编码器返回值
        {
            string current_codenum = textBox_codenum.Text;
            WritePrivateProfileString("数据", "读数", "", FileName);//作用：防止出现末尾X0
            WritePrivateProfileString("数据", "读数", current_codenum, FileName);
        }
        private void textBox_currentangle_TextChanged(object sender, EventArgs e) //保存当前角度
        {
            string currentangle = textBox_currentangle.Text;
            WritePrivateProfileString("数据", "角度", "", FileName);
            WritePrivateProfileString("数据", "角度", currentangle, FileName);
        }

        private void button_hold_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] send_command6 = new byte[1];
            if (button6.Text == "转动")
            {
                if (serialPort2.IsOpen)
                {
                    try
                    {

                        send_command6[0] = 0xff;
                        serialPort2.Write(send_command6, 0, 1);//按字符形式发送
                        button6.Text = "停止";
                        //                        serialPort1.WriteLine(textBox1.Text);  //这种写法发送的是字符串形式，发送数据时最后会加上'/0'
                    }
                    catch (Exception err)
                    { }
                }
                else
                {
                    MessageBox.Show("通信串口未打开", "提示");
                }
            }
            else
            {

                if (serialPort2.IsOpen)
                {
                    try
                    {
                        send_command6[0] = 0x00;
                        serialPort2.Write(send_command6, 0, 1);//按字符形式发送
                        button6.Text = "转动";
                        //                        serialPort1.WriteLine(textBox1.Text);  //这种写法发送的是字符串形式，发送数据时最后会加上'/0'
                    }
                    catch (Exception err)
                    { }
                }
                else
                {
                    MessageBox.Show("通信串口未打开", "提示");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            byte[] send_command2_1 = new byte[1];
            if (btn_normal.Text == "常规")
            {
                if (serialPort2.IsOpen)
                {
                    try
                    {

                        send_command2_1[0] = 0x03;
                        serialPort2.Write(send_command2_1, 0, 1);//按字符形式发送
                        btn_normal.Text = "微调";
                        //  button.Text = "微调";
                        //                        serialPort1.WriteLine(textBox1.Text);  //这种写法发送的是字符串形式，发送数据时最后会加上'/0'
                    }
                    catch (Exception err)
                    { }
                }
                else
                {
                    MessageBox.Show("通信串口未打开", "提示");
                }
            }
            else
            {

                if (serialPort2.IsOpen)
                {
                    try
                    {
                        send_command2_1[0] = 0x30;
                        serialPort2.Write(send_command2_1, 0, 1);//按字符形式发送
                        btn_normal.Text = "常规";
                        //                        serialPort1.WriteLine(textBox1.Text);  //这种写法发送的是字符串形式，发送数据时最后会加上'/0'
                    }
                    catch (Exception err)
                    { }
                }
                else
                {
                    MessageBox.Show("通信串口未打开", "提示");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            byte[] send_command1_1 = new byte[1];
            if (serialPort2.IsOpen)
            {
                try
                {

                    send_command1_1[0] = 0x88;
                    serialPort2.Write(send_command1_1, 0, 1);
                    //                        serialPort1.WriteLine(textBox1.Text);  //这种写法发送的是字符串形式，发送数据时最后会加上'/0'
                }
                catch (Exception err)
                { }
            }
            else
            {
                MessageBox.Show("通信串口未打开", "提示");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12800; i++)
            {
                button2_Click_1(sender, e);
            }
                
        }
    }
}
