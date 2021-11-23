using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace day14_简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetLoginPanelState(true);
            SetContentPanel(false);
        }

        public void SetLoginPanelState(bool state)
        {
            userTxt.Visible = state;
            passwordTxt.Visible = state;
            userLab.Visible = state;
            passwordLab.Visible = state;
            loginBut.Visible = state;
            resetBut.Visible = state;
        }

        public void SetContentPanel(bool state)
        {
            contentTxt.Visible = state;
            outLineBut.Visible = state;
            saveBut.Visible = state;
        }

        public void ShowMessage(string content)
        {
            MessageBox.Show(content);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userTxt.Text.Trim() != "admin")
            {
                ShowMessage("用户名不正确，请检查用户名！");
                return;
            }
            if (passwordTxt.Text != "password")
            {
                ShowMessage("密码错误，请检查密码是否正确！");
                return;
            }

            ShowMessage("登录成功，欢迎使用记事本！");
            SetLoginPanelState(false);
            SetContentPanel(true);
        }

        private void resetBut_Click(object sender, EventArgs e)
        {
            userTxt.Text = "";
            passwordTxt.Text = "";
            userTxt.Focus();
        }

        private void outLineBut_Click(object sender, EventArgs e)
        {
            if (outLineBut.Text == "自动换行")
            {
                contentTxt.WordWrap = true;
                outLineBut.Text = "取消自动换行";
            }
            else if (outLineBut.Text == "取消自动换行")
            {
                contentTxt.WordWrap = false;
                outLineBut.Text = "自动换行";
            }
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\Desktop\saveTxt.txt"))
            {
                sw.Write(contentTxt.Text);
            }
            ShowMessage("恭喜，保存成功！");
        }
    }
}