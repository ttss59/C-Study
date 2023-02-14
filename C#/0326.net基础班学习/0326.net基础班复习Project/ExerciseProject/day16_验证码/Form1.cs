using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day16_验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //加载成功时，就有个默认验证码
            DrawVarification();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DrawVarification();
        }

        /// <summary>
        /// 画验证码方法
        /// </summary>
        private void DrawVarification()
        {
            int count = 5;
            Random rd = new Random();
            string str = null;
            for (int i = 0; i < count; i++)
            {
                int num = rd.Next(0, 10);
                str += num.ToString();
            }

            Bitmap bitmap = new Bitmap(166, 36);
            Graphics graphics = Graphics.FromImage(bitmap);

            //定义字体和颜色
            string[] fonts = new string[] { "宋体", "楷体", "微软雅黑", "黑体", "隶书" };
            Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Black };

            //画数字
            for (int i = 0; i < count; i++)
            {
                Point p1 = new Point(8 + i * 30, rd.Next(0, 8));
                int index = rd.Next(0, 5);
                graphics.DrawString(str[i].ToString(), new Font(fonts[index], 22, FontStyle.Bold), new SolidBrush(colors[index]), p1);
            }

            //画线
            for (int i = 0; i < 36; i++)
            {
                Point p1 = new Point(rd.Next(0, bitmap.Width), rd.Next(0, bitmap.Height));
                Point p2 = new Point(rd.Next(0, bitmap.Width), rd.Next(0, bitmap.Height));
                graphics.DrawLine(new Pen(Brushes.Gray), p1, p2);
            }

            for (int i = 0; i < 166; i++)
            {
                Point p1 = new Point(rd.Next(0, bitmap.Width), rd.Next(0, bitmap.Height));
                bitmap.SetPixel(p1.X, p1.Y, Color.Black);
            }

            pictureBox1.Image = bitmap;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //画边框
            this.CreateGraphics().DrawRectangle(new Pen(Brushes.Black, 2), new Rectangle(192, 103, 166, 36));
        }
    }
}