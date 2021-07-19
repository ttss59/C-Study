using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket socket;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //在客户端创建一个负责跟服务端通信使用的Socket
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //获得要连接的服务器的IP地址
                IPAddress ip = IPAddress.Parse(txtServer.Text);
                //获得要连接的服务器的端口号
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //客户端负责通信的Socket去连接服务端的IP地址跟端口号
                socket.Connect(point);
                ShowMsg("连接成功");

                Thread th1 = new Thread(Rec);
                th1.IsBackground = true;
                th1.Start();
            }
            catch 
            {
                
            }
          

        }

        void Rec()
        {
            while (true)
            {
                try
                {
                    //客户端接收服务端发来的数据
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = socket.Receive(buffer);
                    byte b = buffer[0];
                    //发送的是文字
                    if (b == 0)
                    {
                        string str = System.Text.Encoding.UTF8.GetString(buffer, 1, r-1);
                        ShowMsg(str);
                    }
                    //发送的是文件
                    else if (b == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"C:\Users\SpringRain\Desktop";
                        sfd.Filter = "文本文件|*.txt|音乐文件|*.wav|图片文件|*.jpg|所有文件|*.*";
                        sfd.Title = "请选择要保存的文件路径";
                        sfd.ShowDialog(this);

                        string path = sfd.FileName;
                        using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功");
                    }
                    //发送的是震动
                    else if (b == 2)
                    {
                        ZD();
                    }


                    
                }
                catch
                { 
                    
                }
            }
          
        }



        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txtMsg.Text;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            socket.Send(buffer);
        }



        /// <summary>
        /// 让船体震动
        /// </summary>
        void ZD()
        {
            for (int i = 0; i < 200; i++)
            {
                this.Location = new Point(220, 220);
                this.Location = new Point(420, 420);
            }
        }



        /// <summary>
        /// 在程序加载的时候 取消跨线程的检查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
