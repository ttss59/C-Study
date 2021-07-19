﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05GDI_的基本用法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //通过当前窗体对象来创建一个GDI对象
            Graphics g = this.CreateGraphics();// new Graphics();
            //画直线
            //笔 纸  两个点  颜色  你
            Point p1 = new Point(50, 50);
            Point p2 = new Point(250, 250);
            Pen pen = new Pen(Brushes.Black);
            g.DrawLine(pen, p1, p2);
        }

        int i = 0;//用来记录窗体重新绘制控件的次数
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            //通过当前窗体对象来创建一个GDI对象
            Graphics g = this.CreateGraphics();// new Graphics();
            //画直线
            //笔 纸  两个点  颜色  你
            Point p1 = new Point(150, 150);
            Point p2 = new Point(450, 450);
            Pen pen = new Pen(Brushes.Black);
            g.DrawLine(pen, p1, p2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Size size=new System.Drawing.Size(150,150);
            Rectangle rec=new Rectangle(new Point(220,220),size);
            g.DrawRectangle(new Pen(Brushes.Red), rec);
        }

        private void button4_Click(object sender, EventArgs e)
        {
             Size size=new System.Drawing.Size(150,150);
            Rectangle rec=new Rectangle(new Point(220,220),size);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(Brushes.Yellow, rec);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("老赵是最帅的", new Font("宋体",20 ,FontStyle.Bold), Brushes.Red, new Point(240, 240));
        }
    }
}
