﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI窗体的设计
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 点击创建子窗体对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void 总想排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
