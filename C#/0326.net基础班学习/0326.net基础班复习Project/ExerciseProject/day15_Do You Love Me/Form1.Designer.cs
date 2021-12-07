namespace day15_Do_You_Love_Me
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
            this.loveBut = new System.Windows.Forms.Button();
            this.unLoveBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loveBut
            // 
            this.loveBut.Location = new System.Drawing.Point(206, 163);
            this.loveBut.Name = "loveBut";
            this.loveBut.Size = new System.Drawing.Size(75, 23);
            this.loveBut.TabIndex = 0;
            this.loveBut.Text = "爱";
            this.loveBut.UseVisualStyleBackColor = true;
            this.loveBut.Click += new System.EventHandler(this.loveBut_Click);
            // 
            // unLoveBut
            // 
            this.unLoveBut.Location = new System.Drawing.Point(439, 163);
            this.unLoveBut.Name = "unLoveBut";
            this.unLoveBut.Size = new System.Drawing.Size(75, 23);
            this.unLoveBut.TabIndex = 1;
            this.unLoveBut.Text = "不爱";
            this.unLoveBut.UseVisualStyleBackColor = true;
            this.unLoveBut.MouseEnter += new System.EventHandler(this.unLoveBut_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unLoveBut);
            this.Controls.Add(this.loveBut);
            this.Name = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loveBut;
        private System.Windows.Forms.Button unLoveBut;
    }
}

