using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05学生或者老师登陆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text;
            if (rdoStudent.Checked)
            {
                if (name == "student" && pwd == "student")
                {
                    MessageBox.Show("学生登陆成功");
                }
                else
                {
                    MessageBox.Show("学生登陆失败");
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtName.Focus();
                }
            }
            else if (rdoTeacher.Checked)
            {
                if (name == "teacher" && pwd == "teacher")
                {
                    MessageBox.Show("老师登陆成功");
                }
                else
                {
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtName.Focus();
                }
            }
            else
            {
                MessageBox.Show("请首先选择老师登陆或者学生登陆");
            }
        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    txtName.Text = "张三";
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
