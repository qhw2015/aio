﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = (timer1.Enabled) ? false : true;
            button1.Text = (timer1.Enabled) ? "停止" : "自动";
        }
        Random rnd = new Random(DateTime .Now .Millisecond);
        private void timer1_Tick(object sender, EventArgs e)
        {
            meter1.ChangeValue = rnd.Next(0,100);
        }
    }
}
