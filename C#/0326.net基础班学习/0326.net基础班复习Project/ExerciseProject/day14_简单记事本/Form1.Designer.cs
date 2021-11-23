namespace day14_简单记事本
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLab = new System.Windows.Forms.Label();
            this.passwordLab = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBut = new System.Windows.Forms.Button();
            this.resetBut = new System.Windows.Forms.Button();
            this.contentTxt = new System.Windows.Forms.TextBox();
            this.outLineBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.粘贴ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // userLab
            // 
            this.userLab.AutoSize = true;
            this.userLab.Location = new System.Drawing.Point(118, 189);
            this.userLab.Name = "userLab";
            this.userLab.Size = new System.Drawing.Size(53, 12);
            this.userLab.TabIndex = 1;
            this.userLab.Text = "用户名：";
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.Location = new System.Drawing.Point(118, 248);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(41, 12);
            this.passwordLab.TabIndex = 2;
            this.passwordLab.Text = "密码：";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(241, 186);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(204, 21);
            this.userTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(241, 245);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '#';
            this.passwordTxt.Size = new System.Drawing.Size(204, 21);
            this.passwordTxt.TabIndex = 4;
            // 
            // loginBut
            // 
            this.loginBut.Location = new System.Drawing.Point(158, 330);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(75, 23);
            this.loginBut.TabIndex = 5;
            this.loginBut.Text = "登录";
            this.loginBut.UseVisualStyleBackColor = true;
            this.loginBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetBut
            // 
            this.resetBut.Location = new System.Drawing.Point(315, 330);
            this.resetBut.Name = "resetBut";
            this.resetBut.Size = new System.Drawing.Size(75, 23);
            this.resetBut.TabIndex = 6;
            this.resetBut.Text = "重置";
            this.resetBut.UseVisualStyleBackColor = true;
            this.resetBut.Click += new System.EventHandler(this.resetBut_Click);
            // 
            // contentTxt
            // 
            this.contentTxt.Location = new System.Drawing.Point(12, 66);
            this.contentTxt.Multiline = true;
            this.contentTxt.Name = "contentTxt";
            this.contentTxt.Size = new System.Drawing.Size(571, 416);
            this.contentTxt.TabIndex = 7;
            this.contentTxt.WordWrap = false;
            // 
            // outLineBut
            // 
            this.outLineBut.Location = new System.Drawing.Point(64, 25);
            this.outLineBut.Name = "outLineBut";
            this.outLineBut.Size = new System.Drawing.Size(75, 23);
            this.outLineBut.TabIndex = 8;
            this.outLineBut.Text = "自动换行";
            this.outLineBut.UseVisualStyleBackColor = true;
            this.outLineBut.Click += new System.EventHandler(this.outLineBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(343, 25);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(75, 23);
            this.saveBut.TabIndex = 9;
            this.saveBut.Text = "保  存";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 494);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.outLineBut);
            this.Controls.Add(this.resetBut);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.passwordLab);
            this.Controls.Add(this.userLab);
            this.Controls.Add(this.contentTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.Label userLab;
        private System.Windows.Forms.Label passwordLab;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Button resetBut;
        private System.Windows.Forms.TextBox contentTxt;
        private System.Windows.Forms.Button outLineBut;
        private System.Windows.Forms.Button saveBut;
    }
}

