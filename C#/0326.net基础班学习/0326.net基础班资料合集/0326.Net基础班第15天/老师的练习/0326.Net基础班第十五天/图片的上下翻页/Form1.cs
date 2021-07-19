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
namespace 图片的上下翻页
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] path;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\SpringRain\Desktop\images\t1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            //获得Images文件夹下所有的全路径
            path = Directory.GetFiles(@"C:\Users\SpringRain\Desktop\Resources","*.jpg");
        }

        int i = 0;

        /// <summary>
        /// 点击下一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i == path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = path.Length - 1;
            }

            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
