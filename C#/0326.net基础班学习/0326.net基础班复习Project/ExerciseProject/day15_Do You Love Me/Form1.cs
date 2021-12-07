using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_Do_You_Love_Me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point pos = this.PointToClient(MousePosition);
            this.Text = string.Format("mouseX = {0} , mouseY = {1} ", pos.X, pos.Y);
        }

        private void unLoveBut_MouseEnter(object sender, EventArgs e)
        {
            int h = this.ClientSize.Height - unLoveBut.Height;
            int v = this.ClientSize.Width - unLoveBut.Width;
            Random random = new Random();
            int h2 = random.Next(0, h + 1);
            int v2 = random.Next(0, v + 1);

            unLoveBut.Location = new Point(v2, h2);
        }

        private void loveBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你，思密达！");
            this.Close();
        }
    }
}