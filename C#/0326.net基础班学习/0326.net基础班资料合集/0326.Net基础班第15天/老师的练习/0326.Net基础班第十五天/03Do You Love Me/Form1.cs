using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03Do_You_Love_Me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你哟思密达");
            this.Close();
        }


        /// <summary>
        /// 每当鼠标进入按钮的可见部分的时候 给按钮一个新的随机的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnLove_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            //最大横向活动的范围就是当前窗体的宽度减去按钮的宽度
            int maxWidth = this.ClientSize.Width - btnUnLove.Width;
            int maxHeight = this.ClientSize.Height - btnUnLove.Height;

            //给按钮重新赋值一个新坐标
            btnUnLove.Location = new Point(r.Next(0, maxWidth + 1), r.Next(0, maxHeight + 1));


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  this.Text = "X:" +this MousePosition.X + "Y:" + MousePosition.Y;
            //Point p2 = this.PointToClient(MousePosition);
            //this.Text = p2.ToString();
        }
    }
}
