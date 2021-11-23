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

namespace _15_简单记事儿本儿
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当窗体加载的时候 隐藏掉我们不需要的控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            btnWordWrap.Visible = false;
            btnSave.Visible = false;
            txtWords.Visible = false;
            //在程序加载的时候 取消文本框的自动换行
            txtWords.WordWrap = false;
        }

        /// <summary>
        /// 判断登陆是否成功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //要获得用户输入的用户名和密码
            string userName = txtName.Text.Trim();
            string userPwd = txtPwd.Text;
            if (userName == "admin" && userPwd == "admin")
            {
                MessageBox.Show("登陆成功哟亲，欢迎使用简单记事本儿程序~~~");
                label1.Visible = false;
                label2.Visible = false;
                txtName.Visible = false;
                txtPwd.Visible = false;
                btnLogin.Visible = false;
                btnRest.Visible = false;
                btnWordWrap.Visible = true;
                btnSave.Visible = true;
                txtWords.Visible = true;
            }
            else//登陆失败
            {
                MessageBox.Show("用户名或者密码错误，请重新输入");
                txtName.Clear();
                txtPwd.Clear();
                txtName.Focus();
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPwd.Clear();
            txtName.Focus();
        }

        /// <summary>
        /// 点击自动换行或者取消自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            if (btnWordWrap.Text == "自动换行")
            {
                txtWords.WordWrap = true;
                btnWordWrap.Text = "取消自动换行";
            }
            else if (btnWordWrap.Text == "取消自动换行")
            {
                txtWords.WordWrap = false;
                btnWordWrap.Text = "自动换行";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream fsWrite = new FileStream(@"D:\Desktop\saveTxt.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = System.Text.Encoding.Default.GetBytes(txtWords.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功哟亲，感谢您的使用思密达~~~");
        }
    }
}