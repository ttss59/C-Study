using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04跑马灯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //每半秒钟截取一次字符串
            label1.Text = label1.Text.Substring(label1.Text.Length - 1) + label1.Text.Substring(0, label1.Text.Length - 1);
            
        }
    }
}
