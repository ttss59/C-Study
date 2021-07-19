using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Sayounala");
            comboBox2.Items.Add("aniasaiyou");
            comboBox2.Items.Add("雷猴呀");
            comboBox2.Items.Add("吃了么");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在程序加载的时候 默认的显示一条数据
            comboBox1.SelectedIndex = 1;
        }
    }
}
