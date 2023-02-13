namespace day16_剪刀石头布
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
            this.butST = new System.Windows.Forms.Button();
            this.butB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblJudger = new System.Windows.Forms.Label();
            this.butJD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butST
            // 
            this.butST.Location = new System.Drawing.Point(80, 271);
            this.butST.Name = "butST";
            this.butST.Size = new System.Drawing.Size(75, 23);
            this.butST.TabIndex = 0;
            this.butST.Text = "石头";
            this.butST.UseVisualStyleBackColor = true;
            this.butST.Click += new System.EventHandler(this.butST_Click);
            // 
            // butB
            // 
            this.butB.Location = new System.Drawing.Point(314, 271);
            this.butB.Name = "butB";
            this.butB.Size = new System.Drawing.Size(75, 23);
            this.butB.TabIndex = 1;
            this.butB.Text = "布";
            this.butB.UseVisualStyleBackColor = true;
            this.butB.Click += new System.EventHandler(this.butB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "玩家出：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "电脑出：";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(102, 59);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(41, 12);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "label3";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(361, 59);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(41, 12);
            this.lblComputer.TabIndex = 5;
            this.lblComputer.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "裁判：";
            // 
            // lblJudger
            // 
            this.lblJudger.AutoSize = true;
            this.lblJudger.Location = new System.Drawing.Point(220, 184);
            this.lblJudger.Name = "lblJudger";
            this.lblJudger.Size = new System.Drawing.Size(41, 12);
            this.lblJudger.TabIndex = 7;
            this.lblJudger.Text = "label6";
            // 
            // butJD
            // 
            this.butJD.Location = new System.Drawing.Point(200, 271);
            this.butJD.Name = "butJD";
            this.butJD.Size = new System.Drawing.Size(75, 23);
            this.butJD.TabIndex = 8;
            this.butJD.Text = "剪刀";
            this.butJD.UseVisualStyleBackColor = true;
            this.butJD.Click += new System.EventHandler(this.butJD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 372);
            this.Controls.Add(this.butJD);
            this.Controls.Add(this.lblJudger);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butB);
            this.Controls.Add(this.butST);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butST;
        private System.Windows.Forms.Button butB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblJudger;
        private System.Windows.Forms.Button butJD;
    }
}

