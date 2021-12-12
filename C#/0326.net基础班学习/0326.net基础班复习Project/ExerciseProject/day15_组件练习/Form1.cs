using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_组件练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            InitYearCob();
        }

        private void InitYearCob()
        {
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= 1949; i--)
            {
                cboYear.Items.Add(i + "年");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Visible = true;
            button2.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
            button3.Enabled = false;
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add("吃饭");
            comboBox2.Items.Add("吃面");
            comboBox2.Items.Add("吃馒头");
            comboBox1.SelectedIndex = 1;
            comboBox3.SelectedIndex = 3;
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMouth.Items.Count > 0)
            {
                /// 还有一个办法就是，切换年份时，直接清空月份的选择，那样就不需要判断CheckMouth();了
                CheckMouth();
                return;
            }
            for (int i = 1; i < 13; i++)
            {
                cboMouth.Items.Add(i + "月");
            }
        }

        private void cboMouth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("sender = " + sender.ToString() + " e = " + e.ToString());
            CheckMouth();
        }

        private void CheckMouth()
        {
            int mouth = cboMouth.SelectedIndex + 1;
            cboDay.Items.Clear();
            for (int i = 1; i <= 28; i++)
            {
                cboDay.Items.Add(i + "日");
            }

            switch (mouth)
            {
                case 2:
                    int currentYear = int.Parse(cboYear.SelectedItem.ToString().Trim('年'));
                    if ((currentYear % 4 == 0 && currentYear % 100 != 0) || currentYear % 400 == 0)
                        cboDay.Items.Add("29日");
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    cboDay.Items.Add("29日");
                    cboDay.Items.Add("30日");
                    cboDay.Items.Add("31日");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    cboDay.Items.Add("29日");
                    cboDay.Items.Add("30日");
                    break;
            }
        }
    }
}