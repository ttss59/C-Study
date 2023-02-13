using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day16_窗体之间的移动
{
    public partial class Form1 : Form
    {
        public Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Parent == this)
            {
                form2.Controls.Add(button1);
                button1.Text = "我现在在第二个窗体中";
            }
            else
            {
                this.Controls.Add(button1);
                button1.Text = "我现在在第一个窗体中";
            }
        }
    }
}