namespace day17_1_Client
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
            this.connectBut = new System.Windows.Forms.Button();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.severIPTxt = new System.Windows.Forms.TextBox();
            this.showTxt = new System.Windows.Forms.TextBox();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.sendBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectBut
            // 
            this.connectBut.Location = new System.Drawing.Point(334, 34);
            this.connectBut.Name = "connectBut";
            this.connectBut.Size = new System.Drawing.Size(88, 30);
            this.connectBut.TabIndex = 5;
            this.connectBut.Text = "连   接";
            this.connectBut.UseVisualStyleBackColor = true;
            this.connectBut.Click += new System.EventHandler(this.connectBut_Click);
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(247, 40);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(40, 21);
            this.portTxt.TabIndex = 4;
            this.portTxt.Text = "6666";
            // 
            // severIPTxt
            // 
            this.severIPTxt.Location = new System.Drawing.Point(98, 40);
            this.severIPTxt.Name = "severIPTxt";
            this.severIPTxt.Size = new System.Drawing.Size(116, 21);
            this.severIPTxt.TabIndex = 3;
            this.severIPTxt.Text = "192.168.188.69";
            // 
            // showTxt
            // 
            this.showTxt.Location = new System.Drawing.Point(98, 92);
            this.showTxt.Multiline = true;
            this.showTxt.Name = "showTxt";
            this.showTxt.Size = new System.Drawing.Size(528, 152);
            this.showTxt.TabIndex = 6;
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(98, 295);
            this.inputTxt.Multiline = true;
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(528, 152);
            this.inputTxt.TabIndex = 7;
            // 
            // sendBut
            // 
            this.sendBut.Location = new System.Drawing.Point(509, 487);
            this.sendBut.Name = "sendBut";
            this.sendBut.Size = new System.Drawing.Size(99, 34);
            this.sendBut.TabIndex = 8;
            this.sendBut.Text = "发送消息";
            this.sendBut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 551);
            this.Controls.Add(this.sendBut);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.showTxt);
            this.Controls.Add(this.connectBut);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.severIPTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBut;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.TextBox severIPTxt;
        private System.Windows.Forms.TextBox showTxt;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Button sendBut;
    }
}

