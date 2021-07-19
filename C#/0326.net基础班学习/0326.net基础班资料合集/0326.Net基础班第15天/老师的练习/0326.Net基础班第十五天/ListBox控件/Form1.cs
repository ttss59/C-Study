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
namespace ListBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        List<string> list = new List<string>();//用来存储文件的全路径 
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\.net\Desktop\Images\t1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string[] str = Directory.GetFiles(@"C:\Users\.net\Desktop\Images");

            //将数组中存放的文件名加载到ListBox中
            //将全路径截取出文件名
            //将截取出来的文件名放到ListBox中
            for (int i = 0; i < str.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(str[i]));
                list.Add(str[i]);
            }
        }



        /// <summary>
        /// 点击更换照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(list[listBox1.SelectedIndex]);
        }
    }
}
