using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09多线程执行带参数的方法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //线程执行的方法 如果有参数 那么这个参数必须是object类型
            Thread th = new Thread(Test);
            th.IsBackground = true;
            th.Start("123");
        }

        public void Test(object str)
        {
            string s = (string)str;
            MessageBox.Show(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
