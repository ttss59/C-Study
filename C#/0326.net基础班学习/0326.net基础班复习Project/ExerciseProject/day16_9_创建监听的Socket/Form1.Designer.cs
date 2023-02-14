namespace day16_9_创建监听的Socket
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
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.showTxt = new System.Windows.Forms.TextBox();
            this.startBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(116, 87);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(100, 21);
            this.ipTxt.TabIndex = 0;
            this.ipTxt.Text = "192.168.188.69";
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(241, 86);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(76, 21);
            this.portTxt.TabIndex = 1;
            this.portTxt.Text = "50000";
            // 
            // showTxt
            // 
            this.showTxt.Location = new System.Drawing.Point(116, 173);
            this.showTxt.Multiline = true;
            this.showTxt.Name = "showTxt";
            this.showTxt.Size = new System.Drawing.Size(299, 168);
            this.showTxt.TabIndex = 2;
            // 
            // startBut
            // 
            this.startBut.Location = new System.Drawing.Point(359, 84);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(75, 23);
            this.startBut.TabIndex = 3;
            this.startBut.Text = "开始监听";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.showTxt);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.ipTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.TextBox showTxt;
        private System.Windows.Forms.Button startBut;
    }
}

