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

namespace day15_图片的上下翻页
{
    public partial class Form1 : Form
    {
        private string[] images;
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            images = Directory.GetFiles("images");
            if (images != null && images.Length > 0)
            {
                pictureBox1.Load(images[0]);
                currentIndex = 0;
            }
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
                currentIndex = images.Length - 1;
            pictureBox1.Load(images[currentIndex]);
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex > images.Length - 1)
                currentIndex = 0;
            pictureBox1.Load(images[currentIndex]);
        }
    }
}