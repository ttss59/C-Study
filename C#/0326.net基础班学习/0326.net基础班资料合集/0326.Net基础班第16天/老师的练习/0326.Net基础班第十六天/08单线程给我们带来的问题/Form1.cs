﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08单线程给我们带来的问题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        private void button1_Click(object sender, EventArgs e)
        {
            //开启一个新的线程帮助我们执行Test方法
            th = new Thread(Test);
            //设置成后台线程
            th.IsBackground = true;
          
            //启动线程
            th.Start();
            //th.Abort();
            ////线程一旦被关闭了 就不能再被打开了
            //th.Start();
        }

        void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消对跨线程访问的检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当关闭窗体的时候  同时关闭我的后台线程
            if (th != null)
            {
                //关闭线程
             //   th.Abort();
            }
        }
    }
}
