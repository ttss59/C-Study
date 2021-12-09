using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_学生老师登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (!radioStudent.Checked && !radioTecher.Checked)
            {
                MessageBox.Show("请选择正确身份登录！");
                return;
            }

            if (radioTecher.Checked)
            {
                if (txtUser.Text.Trim() != "techer")
                {
                    MessageBox.Show("老师用户名不存在！");
                    InitLoginState();
                    return;
                }
                if (txtPassword.Text != "techer")
                {
                    MessageBox.Show("老师密码错误，请检查！");
                    InitLoginState();
                    return;
                }
                MessageBox.Show("老师登录成功！");
            }
            else
            {
                if (txtUser.Text.Trim() != "student")
                {
                    MessageBox.Show("学生用户名不存在！");
                    InitLoginState();
                    return;
                }
                if (txtPassword.Text != "student")
                {
                    MessageBox.Show("学生密码错误，请检查！");
                    InitLoginState();
                    return;
                }
                MessageBox.Show("学生登录成功！");
            }
        }

        private void InitLoginState()
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();
        }
    }
}