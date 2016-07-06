namespace Test
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.meter1 = new Chart.Meter();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "自动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "因为开启线程实现指针的平滑移动,\r\n但也造成了，当变量太快时，指针移动幅度过大，\r\n望修改之\r\n";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(380, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.meter1;
            this.propertyGrid1.Size = new System.Drawing.Size(239, 321);
            this.propertyGrid1.TabIndex = 1;
            // 
            // meter1
            // 
            this.meter1.BackColor = System.Drawing.Color.Transparent;
            this.meter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("meter1.BackgroundImage")));
            this.meter1.BorderColor = System.Drawing.Color.White;
            this.meter1.CenterColor = System.Drawing.Color.White;
            this.meter1.ChangeValue = 0D;
            this.meter1.Diameter = 149;
            this.meter1.FrameColor = System.Drawing.Color.Black;
            this.meter1.IsDrawBackGround = false;
            this.meter1.IsMaxValueChange = false;
            this.meter1.Location = new System.Drawing.Point(107, 96);
            this.meter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.meter1.MaxValue = 100D;
            this.meter1.Name = "meter1";
            this.meter1.PinColor = System.Drawing.Color.Black;
            this.meter1.PinLen = 60;
            this.meter1.Size = new System.Drawing.Size(150, 150);
            this.meter1.TabIndex = 0;
            this.meter1.UnitStr = "KB/s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.meter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chart.Meter meter1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

