using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day16_GDI_的基本用法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Black);
            Point point1 = new Point(66, 66);
            Point point2 = new Point(222, 222);
            graphics.DrawLine(pen, point1, point2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Point point1 = new Point(88, 88);
            Point point2 = new Point(888, 228);
            graphics.DrawLine(pen, point1, point2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.DrawRectangle(new Pen(Brushes.Blue), new Rectangle(66, 88, 88, 66));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.FillRectangle(Brushes.Red, new Rectangle(66, 88, 88, 22));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.DrawString("不要怂，认真做!\n我一定可以！", new Font("宋体", 66, FontStyle.Bold), Brushes.Green, new Point(66, 88));
        }
    }
}