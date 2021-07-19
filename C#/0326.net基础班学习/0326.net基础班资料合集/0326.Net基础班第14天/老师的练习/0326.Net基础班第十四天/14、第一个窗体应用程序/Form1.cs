using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_第一个窗体应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox btn1 = (TextBox)sender;
            MessageBox.Show("Hello World");
        }
    }
}
