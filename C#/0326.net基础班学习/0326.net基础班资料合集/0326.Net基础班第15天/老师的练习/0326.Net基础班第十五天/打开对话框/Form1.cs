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
namespace 打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //设置打开对话框显示的文本
            ofd.Title = "请选择文件哟亲~~";
            //设置打开对话框可以多选
            ofd.Multiselect = true;
            //设置打开对话框的初识目录
            ofd.InitialDirectory = @"C:\Users\SpringRain\Desktop\Resources";
            //设置打开对话框文件的类型
            ofd.Filter = "媒体文件|*.wav|图片文件|*.jpg|文本文件|*.txt|所有文件|*.*";
            ofd.ShowDialog();
            //获得所有选中文件的全路径
            string[] str = ofd.FileNames;

            for (int i = 0; i < str.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(str[i]));
            }
        }
    }
}
