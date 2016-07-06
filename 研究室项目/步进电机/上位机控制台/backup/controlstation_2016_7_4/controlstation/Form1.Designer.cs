namespace controlstation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_clockwise = new System.Windows.Forms.Button();
            this.button_anticlockwise = new System.Windows.Forms.Button();
            this.ovalShape_com = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape_code = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.button_opencode = new System.Windows.Forms.Button();
            this.comboBox_code = new System.Windows.Forms.ComboBox();
            this.button_scan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.button_senddate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.textBox_turnangle = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox_currentangle = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_hold = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.button_opencom = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox_codenum = new System.Windows.Forms.TextBox();
            this.btn_normal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 4800;
            // 
            // button_clockwise
            // 
            this.button_clockwise.Location = new System.Drawing.Point(328, 267);
            this.button_clockwise.Name = "button_clockwise";
            this.button_clockwise.Size = new System.Drawing.Size(75, 23);
            this.button_clockwise.TabIndex = 0;
            this.button_clockwise.Text = "正转";
            this.button_clockwise.UseVisualStyleBackColor = true;
            this.button_clockwise.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_anticlockwise
            // 
            this.button_anticlockwise.Location = new System.Drawing.Point(409, 267);
            this.button_anticlockwise.Name = "button_anticlockwise";
            this.button_anticlockwise.Size = new System.Drawing.Size(75, 23);
            this.button_anticlockwise.TabIndex = 1;
            this.button_anticlockwise.Text = "反转";
            this.button_anticlockwise.UseVisualStyleBackColor = true;
            this.button_anticlockwise.Click += new System.EventHandler(this.button2_Click);
            // 
            // ovalShape_com
            // 
            this.ovalShape_com.Location = new System.Drawing.Point(129, 222);
            this.ovalShape_com.Name = "ovalShape_com";
            this.ovalShape_com.Size = new System.Drawing.Size(13, 14);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape_code,
            this.ovalShape_com});
            this.shapeContainer1.Size = new System.Drawing.Size(515, 506);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape_code
            // 
            this.ovalShape_code.Location = new System.Drawing.Point(130, 173);
            this.ovalShape_code.Name = "ovalShape_code";
            this.ovalShape_code.Size = new System.Drawing.Size(13, 14);
            // 
            // button_opencode
            // 
            this.button_opencode.Location = new System.Drawing.Point(155, 219);
            this.button_opencode.Name = "button_opencode";
            this.button_opencode.Size = new System.Drawing.Size(89, 23);
            this.button_opencode.TabIndex = 6;
            this.button_opencode.Text = "开编码器串口";
            this.button_opencode.UseVisualStyleBackColor = true;
            this.button_opencode.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox_code
            // 
            this.comboBox_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_code.FormattingEnabled = true;
            this.comboBox_code.Location = new System.Drawing.Point(6, 18);
            this.comboBox_code.Name = "comboBox_code";
            this.comboBox_code.Size = new System.Drawing.Size(97, 20);
            this.comboBox_code.TabIndex = 7;
            // 
            // button_scan
            // 
            this.button_scan.Location = new System.Drawing.Point(280, 168);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(75, 23);
            this.button_scan.TabIndex = 8;
            this.button_scan.Text = "扫描";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_code);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 44);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编码器串口";
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(6, 20);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_send.Size = new System.Drawing.Size(246, 45);
            this.textBox_send.TabIndex = 15;
            // 
            // button_senddate
            // 
            this.button_senddate.Location = new System.Drawing.Point(280, 413);
            this.button_senddate.Name = "button_senddate";
            this.button_senddate.Size = new System.Drawing.Size(62, 45);
            this.button_senddate.TabIndex = 16;
            this.button_senddate.Text = "发送";
            this.button_senddate.UseVisualStyleBackColor = true;
            this.button_senddate.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_send);
            this.groupBox6.Location = new System.Drawing.Point(13, 393);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(261, 72);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "待发送数据";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox_receive);
            this.groupBox7.Location = new System.Drawing.Point(526, 239);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(214, 225);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "接收数据区";
            // 
            // textBox_receive
            // 
            this.textBox_receive.Location = new System.Drawing.Point(7, 19);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_receive.Size = new System.Drawing.Size(201, 200);
            this.textBox_receive.TabIndex = 0;
            // 
            // textBox_turnangle
            // 
            this.textBox_turnangle.Location = new System.Drawing.Point(6, 20);
            this.textBox_turnangle.Name = "textBox_turnangle";
            this.textBox_turnangle.Size = new System.Drawing.Size(75, 21);
            this.textBox_turnangle.TabIndex = 19;
            this.textBox_turnangle.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox_turnangle);
            this.groupBox8.Location = new System.Drawing.Point(19, 252);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(88, 48);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "转动角度";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(144, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "转动";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(328, 344);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "归零";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox_currentangle
            // 
            this.textBox_currentangle.Location = new System.Drawing.Point(6, 18);
            this.textBox_currentangle.Name = "textBox_currentangle";
            this.textBox_currentangle.Size = new System.Drawing.Size(75, 21);
            this.textBox_currentangle.TabIndex = 16;
            this.textBox_currentangle.TextChanged += new System.EventHandler(this.textBox_currentangle_TextChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox_currentangle);
            this.groupBox9.Location = new System.Drawing.Point(19, 343);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(88, 44);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "当前角度";
            // 
            // button_hold
            // 
            this.button_hold.Location = new System.Drawing.Point(428, 344);
            this.button_hold.Name = "button_hold";
            this.button_hold.Size = new System.Drawing.Size(75, 23);
            this.button_hold.TabIndex = 26;
            this.button_hold.Text = "暂停";
            this.button_hold.UseVisualStyleBackColor = true;
            this.button_hold.Click += new System.EventHandler(this.button_hold_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.comboBox_com);
            this.groupBox13.Location = new System.Drawing.Point(12, 153);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(110, 44);
            this.groupBox13.TabIndex = 32;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "通信串口";
            // 
            // comboBox_com
            // 
            this.comboBox_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Location = new System.Drawing.Point(6, 18);
            this.comboBox_com.Name = "comboBox_com";
            this.comboBox_com.Size = new System.Drawing.Size(97, 20);
            this.comboBox_com.TabIndex = 7;
            // 
            // button_opencom
            // 
            this.button_opencom.Location = new System.Drawing.Point(155, 168);
            this.button_opencom.Name = "button_opencom";
            this.button_opencom.Size = new System.Drawing.Size(85, 23);
            this.button_opencom.TabIndex = 33;
            this.button_opencom.Text = "打开通信串口";
            this.button_opencom.UseVisualStyleBackColor = true;
            this.button_opencom.Click += new System.EventHandler(this.button9_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 4800;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::controlstation.Properties.Resources.ustc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox_codenum);
            this.groupBox10.Location = new System.Drawing.Point(144, 344);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(88, 45);
            this.groupBox10.TabIndex = 25;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "编码器值";
            // 
            // textBox_codenum
            // 
            this.textBox_codenum.Location = new System.Drawing.Point(6, 18);
            this.textBox_codenum.Name = "textBox_codenum";
            this.textBox_codenum.Size = new System.Drawing.Size(75, 21);
            this.textBox_codenum.TabIndex = 0;
            this.textBox_codenum.TextChanged += new System.EventHandler(this.textBox_codenum_TextChanged);
            // 
            // btn_normal
            // 
            this.btn_normal.Location = new System.Drawing.Point(144, 305);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(75, 23);
            this.btn_normal.TabIndex = 35;
            this.btn_normal.Text = "常规";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "微调按键";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(225, 267);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(75, 23);
            this.btn_circle.TabIndex = 37;
            this.btn_circle.Text = "180转动";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 506);
            this.Controls.Add(this.btn_circle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_normal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_opencom);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.button_hold);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button_senddate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_scan);
            this.Controls.Add(this.button_opencode);
            this.Controls.Add(this.button_anticlockwise);
            this.Controls.Add(this.button_clockwise);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "步进电机控制器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_clockwise;
        private System.Windows.Forms.Button button_anticlockwise;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape_com;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button button_opencode;
        private System.Windows.Forms.ComboBox comboBox_code;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button button_senddate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.TextBox textBox_turnangle;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox_currentangle;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button_hold;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox comboBox_com;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape_code;
        private System.Windows.Forms.Button button_opencom;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox_codenum;
        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_circle;
    }
}

