using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06画验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string str = "";
            for (int i = 0; i < 5; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber;
            }

            //创建一个图片对象
            Bitmap bmp=new Bitmap(120,25);
            //创建GDI对象
            Graphics g = Graphics.FromImage(bmp);
           // MessageBox.Show(str);

            string[] fonts = { "黑体", "楷体", "微软雅黑", "宋体", "隶书" };
            Color[] colors = { Color.Red, Color.Yellow, Color.Blue, Color.Black, Color.Green };

            for (int i = 0; i < 5; i++)
            {
                Point p=new Point(i*20,0);//0,0   20 0
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 20, FontStyle.Bold),new SolidBrush(colors[r.Next(0,5)]), p);
            }

            //画线
            for (int i = 0; i < 25; i++)
            {
                Point p1=new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));
                Point p2=new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));
                g.DrawLine(new Pen(Color.Green), p1, p2);
            }

            //画像素颗粒
            for (int i = 0; i < 100; i++)
            {
                 Point p=new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));
                 bmp.SetPixel(p.X, p.Y, Color.Black);
            }

            //把画好的图片放到PictureBox上
            pictureBox1.Image = bmp;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   Form1_Load += pictureBox1_Click;
            //pictureBox1_Click(;
        }
    }
}
