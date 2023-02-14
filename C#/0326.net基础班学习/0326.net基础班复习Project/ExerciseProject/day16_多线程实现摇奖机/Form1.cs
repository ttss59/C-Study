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

namespace day16_多线程实现摇奖机
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private TextBox[] textBoxes;
        private Random random;
        private bool isStartGame = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            isStartGame = false;
            textBoxes = new TextBox[] { textBox1, textBox2, textBox3 };
            thread = new Thread(StartGameSelf);
            //设置为后台线程
            thread.IsBackground = true;
            thread.Start();
            //程序开始时给个默认数字：0，0，0
            for (int i = 0; i < 3; i++)
            {
                textBoxes[i].Text = "0";
            }

            random = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StartGame();//在主线程中执行会阻塞程序，所以新建子线程来执行
            if (!isStartGame)
            {
                isStartGame = true;
                label1.Text = "停止抽奖";
            }
            else
            {
                isStartGame = false;
                label1.Text = "开始抽奖";
            }
        }

        /// <summary>
        /// 自己的方式，这样不好，虽然只Start一次，但是子线程会一直运行，消耗资源
        /// </summary>
        private void StartGameSelf()
        {
            while (true)
            {
                if (!isStartGame) continue;
                for (int i = 0; i < 3; i++)
                {
                    int num = random.Next(0, 10);
                    textBoxes[i].Text = num.ToString();
                }
            }
        }

        /// <summary>
        /// 老师的方式
        /// </summary>
        private void StartGameTecher()
        {
            while (true)
            {
                //停止游戏，跳出循环，那么子线程也就停止了，下次重新新建子线程来执行操作
                if (!isStartGame)
                {
                    Console.WriteLine("停止游戏，子线程停止，无法再次开启");
                    break;
                }
                for (int i = 0; i < 3; i++)
                {
                    int num = random.Next(0, 10);
                    textBoxes[i].Text = num.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Init();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //主程序结束时，关闭子线程
            if (thread != null)
                thread.Abort();
        }

        /// <summary>
        /// 老师的方式好些,停止时，不会消耗资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!isStartGame)
            {
                isStartGame = true;
                label1.Text = "停止抽奖";
                thread = new Thread(StartGameTecher);
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                isStartGame = false;
                label1.Text = "开始抽奖";
            }
        }
    }
}