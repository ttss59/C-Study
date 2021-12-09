namespace day15_小闹钟
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labTxt1 = new System.Windows.Forms.Label();
            this.clockTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labTxt2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTxt1
            // 
            this.labTxt1.AutoSize = true;
            this.labTxt1.Location = new System.Drawing.Point(209, 64);
            this.labTxt1.Name = "labTxt1";
            this.labTxt1.Size = new System.Drawing.Size(41, 12);
            this.labTxt1.TabIndex = 0;
            this.labTxt1.Text = "label1";
            // 
            // clockTime
            // 
            this.clockTime.Checked = false;
            this.clockTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.clockTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.clockTime.Location = new System.Drawing.Point(211, 107);
            this.clockTime.Name = "clockTime";
            this.clockTime.Size = new System.Drawing.Size(200, 21);
            this.clockTime.TabIndex = 1;
            this.clockTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "闹钟时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 53);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labTxt2
            // 
            this.labTxt2.AutoSize = true;
            this.labTxt2.Location = new System.Drawing.Point(484, 181);
            this.labTxt2.Name = "labTxt2";
            this.labTxt2.Size = new System.Drawing.Size(41, 12);
            this.labTxt2.TabIndex = 5;
            this.labTxt2.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labTxt2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clockTime);
            this.Controls.Add(this.labTxt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTxt1;
        private System.Windows.Forms.DateTimePicker clockTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labTxt2;
        private System.Windows.Forms.Button button1;
    }
}

