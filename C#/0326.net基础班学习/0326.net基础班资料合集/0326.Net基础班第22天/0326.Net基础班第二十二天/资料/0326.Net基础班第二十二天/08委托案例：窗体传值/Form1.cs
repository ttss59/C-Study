using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08委托案例_窗体传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(SetLable);
            frm2.Show();
        }


        /// <summary>
        /// 窗体一主要任务就是给lable赋值
        /// </summary>
        /// <param name="s"></param>

        private void SetLable(string s)
        {
            label1.Text = s;
        }
    }
}
