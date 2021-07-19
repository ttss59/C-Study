using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08使用多线程来实现摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        bool b = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (b==false)
            {
                b = true;
                th = new Thread(GameStart);
                th.IsBackground = true;
                th.Start();
                button1.Text = "暂停";
            }
            else
            {
                b = false;
                button1.Text = "开始";
            }


          
        }


        public void GameStart()
        {
            Random r = new Random();
            while (b)
            {
                try
                {
                    label1.Text = r.Next(0, 10).ToString();
                    label2.Text = r.Next(0, 10).ToString();
                    label3.Text = r.Next(0, 10).ToString();
                }
                catch
                { 
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th != null)
            {
                th.Abort();
            }
        }
    }
}
