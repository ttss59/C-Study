namespace day17_2_Sever
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
            this.ipAddressTxt = new System.Windows.Forms.TextBox();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.watchBut = new System.Windows.Forms.Button();
            this.connectedBox = new System.Windows.Forms.ComboBox();
            this.showTxt = new System.Windows.Forms.TextBox();
            this.sendTxt = new System.Windows.Forms.TextBox();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.selectBut = new System.Windows.Forms.Button();
            this.sendFileBut = new System.Windows.Forms.Button();
            this.sendMsgBut = new System.Windows.Forms.Button();
            this.shakeBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipAddressTxt
            // 
            this.ipAddressTxt.Location = new System.Drawing.Point(36, 28);
            this.ipAddressTxt.Name = "ipAddressTxt";
            this.ipAddressTxt.Size = new System.Drawing.Size(100, 21);
            this.ipAddressTxt.TabIndex = 0;
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(167, 28);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(45, 21);
            this.portTxt.TabIndex = 1;
            this.portTxt.Text = "50000";
            // 
            // watchBut
            // 
            this.watchBut.Location = new System.Drawing.Point(287, 28);
            this.watchBut.Name = "watchBut";
            this.watchBut.Size = new System.Drawing.Size(75, 23);
            this.watchBut.TabIndex = 2;
            this.watchBut.Text = "开启监听";
            this.watchBut.UseVisualStyleBackColor = true;
            this.watchBut.Click += new System.EventHandler(this.watchBut_Click);
            // 
            // connectedBox
            // 
            this.connectedBox.BackColor = System.Drawing.SystemColors.Window;
            this.connectedBox.FormattingEnabled = true;
            this.connectedBox.Location = new System.Drawing.Point(417, 31);
            this.connectedBox.Name = "connectedBox";
            this.connectedBox.Size = new System.Drawing.Size(163, 20);
            this.connectedBox.TabIndex = 3;
            // 
            // showTxt
            // 
            this.showTxt.Location = new System.Drawing.Point(36, 111);
            this.showTxt.Multiline = true;
            this.showTxt.Name = "showTxt";
            this.showTxt.Size = new System.Drawing.Size(544, 140);
            this.showTxt.TabIndex = 4;
            // 
            // sendTxt
            // 
            this.sendTxt.Location = new System.Drawing.Point(36, 276);
            this.sendTxt.Multiline = true;
            this.sendTxt.Name = "sendTxt";
            this.sendTxt.Size = new System.Drawing.Size(544, 140);
            this.sendTxt.TabIndex = 5;
            // 
            // filePathTxt
            // 
            this.filePathTxt.Location = new System.Drawing.Point(36, 465);
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(302, 21);
            this.filePathTxt.TabIndex = 6;
            // 
            // selectBut
            // 
            this.selectBut.Location = new System.Drawing.Point(371, 463);
            this.selectBut.Name = "selectBut";
            this.selectBut.Size = new System.Drawing.Size(75, 23);
            this.selectBut.TabIndex = 7;
            this.selectBut.Text = "选 择";
            this.selectBut.UseVisualStyleBackColor = true;
            // 
            // sendFileBut
            // 
            this.sendFileBut.Location = new System.Drawing.Point(481, 463);
            this.sendFileBut.Name = "sendFileBut";
            this.sendFileBut.Size = new System.Drawing.Size(99, 23);
            this.sendFileBut.TabIndex = 8;
            this.sendFileBut.Text = "发送文件";
            this.sendFileBut.UseVisualStyleBackColor = true;
            // 
            // sendMsgBut
            // 
            this.sendMsgBut.Location = new System.Drawing.Point(371, 529);
            this.sendMsgBut.Name = "sendMsgBut";
            this.sendMsgBut.Size = new System.Drawing.Size(75, 23);
            this.sendMsgBut.TabIndex = 9;
            this.sendMsgBut.Text = "发送消息";
            this.sendMsgBut.UseVisualStyleBackColor = true;
            // 
            // shakeBut
            // 
            this.shakeBut.Location = new System.Drawing.Point(505, 529);
            this.shakeBut.Name = "shakeBut";
            this.shakeBut.Size = new System.Drawing.Size(75, 23);
            this.shakeBut.TabIndex = 10;
            this.shakeBut.Text = "震动";
            this.shakeBut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 589);
            this.Controls.Add(this.shakeBut);
            this.Controls.Add(this.sendMsgBut);
            this.Controls.Add(this.sendFileBut);
            this.Controls.Add(this.selectBut);
            this.Controls.Add(this.filePathTxt);
            this.Controls.Add(this.sendTxt);
            this.Controls.Add(this.showTxt);
            this.Controls.Add(this.connectedBox);
            this.Controls.Add(this.watchBut);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.ipAddressTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipAddressTxt;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Button watchBut;
        private System.Windows.Forms.ComboBox connectedBox;
        private System.Windows.Forms.TextBox showTxt;
        private System.Windows.Forms.TextBox sendTxt;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Button selectBut;
        private System.Windows.Forms.Button sendFileBut;
        private System.Windows.Forms.Button sendMsgBut;
        private System.Windows.Forms.Button shakeBut;
    }
}

