using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01闹钟小程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //  MessageBox.Show("你中病毒啦");
            //每隔一秒钟将当前系统的时间赋值给我的Lable

            lblTime.Text = DateTime.Now.ToString();


            if (DateTime.Now.Hour == 13 && DateTime.Now.Minute == 14 && DateTime.Now.Second == 50)
            {
                //创建一个能够播放音乐的对象
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"C:\Users\SpringRain\Desktop\Resources\想你的夜.wav";
                sp.Play();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //当程序加载的时候 将当前系统的时间 赋值给Label
            lblTime.Text = DateTime.Now.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = textBox1.Text;
        }
    }
}
