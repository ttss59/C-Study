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

namespace day17_2_Sever
{
    /// <summary>
    /// 定义发送协议：需要发送的文件类型
    /// </summary>
    internal enum SendFileType
    {
        None,
        txt,
        mp4,
        mp3,
        jpg,
    }

    /// <summary>
    /// 定义发送协议：需要发送的操作类型
    /// </summary>
    internal enum SendOpType
    {
        //发送消息 0
        SendMessage,

        //发送文件 1
        SendFile,

        //发送抖动 2
        SendShake
    }

    /// <summary>
    /// Sever
    /// </summary>
    public partial class Form1 : Form
    {
        private Socket watchSocket;
        private Socket currentConnect;
        private Thread watchThread;
        private Thread receriveThread;
        private Dictionary<string, Socket> connectSocketDic = new Dictionary<string, Socket>();

        //private SendFileType currentFileType = SendFileType.Text;

        public Form1()
        {
            InitializeComponent();
        }

        private void watchBut_Click(object sender, EventArgs e)
        {
            try
            {
                watchSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                ipAddressTxt.Text = ip.ToString();
                IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(portTxt.Text));
                //绑定端口进行监听
                watchSocket.Bind(port);

                //设置监听队列
                watchSocket.Listen(10);
                ShowMsg("开启监听成功！");
                watchThread = new Thread(WatchSocketConnect);
                watchThread.IsBackground = true;
                watchThread.Start(watchSocket);
            }
            catch (Exception ex)
            {
                Console.WriteLine("创建Socket 失败 : " + ex.Message);
            }
        }

        private void WatchSocketConnect(object obj)
        {
            Socket watchSocket = obj as Socket;

            while (true)
            {
                try
                {
                    //获得连接成功的socket
                    currentConnect = watchSocket.Accept();
                    ShowMsg("连接成功!", currentConnect);
                    string connectPort = currentConnect.RemoteEndPoint.ToString();
                    if (!connectSocketDic.ContainsKey(connectPort))
                    {
                        connectSocketDic.Add(connectPort, currentConnect);
                        connectedBox.Items.Add(connectPort);
                        connectedBox.SelectedItem = connectPort;
                    }
                    //当currentConnect连接成功后，必须采用新建一个子线程来接收消息，不然会下一个while循环时，当没有新连接时，
                    //会卡在currentConnect = watchSocket.Accept();从而不会接收新的消息
                    receriveThread = new Thread(ReceiveMsg);
                    receriveThread.IsBackground = true;
                    receriveThread.Start(currentConnect);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Accept 失败 : " + ex.Message);
                }
            }
        }

        private void ReceiveMsg(object obj)
        {
            Socket currentConnect = obj as Socket;
            while (currentConnect.Connected)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int count = currentConnect.Receive(buffer);
                    string result = System.Text.Encoding.UTF8.GetString(buffer, 0, count);
                    ShowMsg(result, currentConnect);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Receive接收数据 失败 : " + ex.Message);
                }
            }
        }

        private void SendMsg()
        {
            if (currentConnect == null) return;
            string content = inputTxt.Text;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);

            //添加定义的传输协议
            List<byte> list = new List<byte>();
            list.Add((byte)SendOpType.SendMessage);
            list.AddRange(buffer);
            byte[] newBuffer = list.ToArray();

            if (currentConnect == null) return;
            //发送根据协议修改后的字节数组
            currentConnect.Send(newBuffer);

            //发送完毕后，清空输入框
            inputTxt.Text = string.Empty;
        }

        private void ShowMsg(string content, Socket currentConnect = null)
        {
            if (currentConnect != null)
                showTxt.AppendText(currentConnect.RemoteEndPoint.ToString() + " : " + content + "\r\n");
            else
                showTxt.AppendText(watchSocket.LocalEndPoint.ToString() + " : " + content + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (watchThread != null)
                watchThread.Abort();
            if (receriveThread != null)
                receriveThread.Abort();
        }

        private void connectedBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ip = connectedBox.SelectedItem.ToString();
            if (!connectSocketDic.ContainsKey(ip))
            {
                ShowMsg("连接错误,没有连接此ip : " + connectedBox.SelectedItem.ToString());
                return;
            }
            currentConnect = connectSocketDic[ip];
        }

        private void sendMsgBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputTxt.Text)) return;
            SendMsg();
        }

        private void selectBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\Desktop";
            openFileDialog.Title = "请选择要发送的文件";
            openFileDialog.Filter = "文本文件|*.txt|视频文件|*.mp4|音频文件|*.mp3|图片文件|*.jpg|所有文件|*.*";
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if (string.IsNullOrEmpty(path)) return;
            filePathTxt.Text = path;
        }

        private void sendFileBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePathTxt.Text)) return;
            string filePath = filePathTxt.Text;
            if (!File.Exists(filePath)) return;
            string extension = Path.GetExtension(filePath).Trim('.');
            SendFileType sendFileType = SendFileType.None;
            try
            {
                Console.WriteLine("extension = " + extension);
                sendFileType = (SendFileType)Enum.Parse(typeof(SendFileType), extension);
            }
            catch
            {
                sendFileType = SendFileType.None;
            }
            Console.WriteLine("sendFileType = " + sendFileType.ToString());
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length + 2];//设置实际读取的大小
                buffer[0] = (byte)SendOpType.SendFile;
                buffer[1] = (byte)sendFileType;
                Console.WriteLine("0 = " + buffer[0] + "  1 = " + buffer[1]);
                fs.Read(buffer, 2, buffer.Length - 2);
                if (currentConnect == null) return;
                currentConnect.Send(buffer);
                //发送完毕后，清空输入框
                filePathTxt.Text = string.Empty;
            }
        }

        private void shakeBut_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = (byte)SendOpType.SendShake;
            if (currentConnect == null) return;
            //发送根据协议修改后的字节数组
            currentConnect.Send(buffer);
        }
    }
}