namespace day15_浏览器
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.webBro1 = new System.Windows.Forms.WebBrowser();
            this.butGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtURL.Location = new System.Drawing.Point(12, 25);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(673, 26);
            this.txtURL.TabIndex = 0;
            // 
            // webBro1
            // 
            this.webBro1.Location = new System.Drawing.Point(12, 64);
            this.webBro1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBro1.Name = "webBro1";
            this.webBro1.Size = new System.Drawing.Size(776, 374);
            this.webBro1.TabIndex = 1;
            // 
            // butGo
            // 
            this.butGo.Location = new System.Drawing.Point(704, 25);
            this.butGo.Name = "butGo";
            this.butGo.Size = new System.Drawing.Size(75, 26);
            this.butGo.TabIndex = 2;
            this.butGo.Text = "转到";
            this.butGo.UseVisualStyleBackColor = true;
            this.butGo.Click += new System.EventHandler(this.butGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butGo);
            this.Controls.Add(this.webBro1);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.WebBrowser webBro1;
        private System.Windows.Forms.Button butGo;
    }
}

