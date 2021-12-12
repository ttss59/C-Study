using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_浏览器
{
    public partial class Form1 : Form
    {
        private string urlString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (webBro1.Url == null)
            {
                webBro1.Url = new Uri("http://www.baidu.com");
                txtURL.Text = "http://www.baidu.com";
            }
        }

        private void butGo_Click(object sender, EventArgs e)
        {
            urlString = txtURL.Text;
            if (!urlString.Trim().StartsWith("http://") && !urlString.Trim().StartsWith("https://"))
            {
                urlString = "https://" + urlString;
            }
            webBro1.Url = new Uri(urlString);
        }
    }
}