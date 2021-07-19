using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Do_You_Love_Me
{
    public partial class Form1 : Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你哟思密达");
            this.Close();
        }
    }
}
