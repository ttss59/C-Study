using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_MIDBox
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void item1_Click(object sender, EventArgs e)
        {
            if (form2 != null) return;
            form2 = new Form2();
            form2.Show();
            form2.MdiParent = this;
            Form3 form3 = new Form3();
            form3.Show();
            form3.MdiParent = this;
            Form4 form4 = new Form4();
            form4.Show();
            form4.MdiParent = this;
        }

        private void item2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void item3_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}