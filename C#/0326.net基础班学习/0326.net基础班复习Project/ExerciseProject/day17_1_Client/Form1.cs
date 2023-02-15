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

namespace day17_1_Client
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Client
        /// </summary>
        private Socket socket;

        private IPEndPoint port;
        private Thread receiveThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectBut_Click(object sender, EventArgs e)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //此客户端连接本地ip，所以可以不用ipTxt中的文本，直接用IPAddress.Any
                IPAddress ip = IPAddress.Parse(severIPTxt.Text);
                port = new IPEndPoint(ip, int.Parse(portTxt.Text));
                socket.Connect(port);
                ShowMessage("连接成功！");
                //ReceiveMsg();//直接在主线程中执行，会阻塞程序
                receiveThread = new Thread(ReceiveMsg);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("创建Socket 失败 : " + ex.Message);
            }
        }

        private void ReceiveMsg()
        {
            while (socket.Connected)
            {
                try
                {
                    //暂时不考虑超大文件，最多10M
                    byte[] buffer = new byte[1024 * 1024 * 5];

                    //ShowMessage("等待服务端发送信息");
                    //Receive方法会一直等待服务端的信息，所以当服务器没有发送信息时，会阻塞主线程运行，所以应新建一个子线程接收消息
                    int count = socket.Receive(buffer);
                    //ShowMessage("收到信息，准备解析");
                    int opType = buffer[0];
                    switch (opType)
                    {
                        case 1:
                            //发送文件
                            int fileType = buffer[1];
                            byte[] newBuffer = buffer.Skip(2).Take(count).ToArray();
                            SaveFile(fileType, newBuffer, count);
                            break;

                        case 2:
                            Shake();
                            break;

                        default:
                            //发送Message
                            string result = System.Text.Encoding.UTF8.GetString(buffer, 1, count);
                            ShowMessage(result);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Receive接收数据 失败 : " + ex.Message);
                }
            }
        }

        /// <summary>
        /// 让窗体振动
        /// </summary>
        private void Shake()
        {
            for (int i = 0; i < 166; i++)
            {
                this.Location = new Point(Location.X + 6, Location.Y + 6);
                this.Location = new Point(Location.X - 6, Location.Y - 6);
            }
        }

        private void SaveFile(int fileType, byte[] data, int dataCount)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "请选择文件的保存路径";
            saveFileDialog.InitialDirectory = @"D:\Desktop";
            switch (fileType)
            {
                case 1:
                    saveFileDialog.Filter = "文本文件|*.txt";
                    break;

                case 2:
                    saveFileDialog.Filter = "视频文件|*.mp4";
                    break;

                case 3:
                    saveFileDialog.Filter = "音频文件|*.mp3";
                    break;

                case 4:
                    saveFileDialog.Filter = "图片文件|*.jpg";
                    break;

                default:
                    saveFileDialog.Filter = "所有文件|*.*";
                    break;
            }
            saveFileDialog.ShowDialog(this);
            if (string.IsNullOrEmpty(saveFileDialog.FileName)) return;
            string path = saveFileDialog.FileName;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(data, 0, dataCount);
                MessageBox.Show("文件保存成功！");
            }
        }

        private void SendMsg()
        {
            string content = inputTxt.Text;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);
            socket.Send(buffer);
            //发送完毕后，清空输入框
            inputTxt.Text = string.Empty;
        }

        private void ShowMessage(string content)
        {
            showTxt.AppendText(port.ToString() + " : " + content + "\r\n");
        }

        private void sendBut_Click(object sender, EventArgs e)
        {
            SendMsg();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (receiveThread != null)
                receiveThread.Abort();
        }
    }
}