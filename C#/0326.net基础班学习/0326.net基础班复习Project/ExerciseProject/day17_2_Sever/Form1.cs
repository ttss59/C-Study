using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day17_2_Sever
{
    public partial class Form1 : Form
    {
        private Socket watchSocket;
        private Socket currentConnect;
        private Thread watchThread;
        private Dictionary<string, Socket> connectSocketDic = new Dictionary<string, Socket>();

        public Form1()
        {
            InitializeComponent();
        }

        private void watchBut_Click(object sender, EventArgs e)
        {
            watchSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            ipAddressTxt.Text = ip.ToString();
            IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(portTxt.Text));
            //绑定端口进行监听
            watchSocket.Bind(port);

            //设置监听队列
            watchSocket.Listen(10);
            ShowMsg("开启监听成功！", true);
            watchThread = new Thread(WatchSocketConnect);
            watchThread.IsBackground = true;
            watchThread.Start(watchSocket);
        }

        private void WatchSocketConnect(object obj)
        {
            Socket watchSocket = obj as Socket;

            while (true)
            {
                //获得连接成功的socket
                currentConnect = watchSocket.Accept();
                ShowMsg("连接成功!");
                string connectPort = currentConnect.RemoteEndPoint.ToString();
                if (!connectSocketDic.ContainsKey(connectPort))
                {
                    connectSocketDic.Add(connectPort, currentConnect);
                    connectedBox.Items.Add(connectPort);
                    connectedBox.SelectedItem = connectPort;
                }
                byte[] buffer = new byte[1024 * 1024 * 3];
                int count = currentConnect.Receive(buffer);
                string result = System.Text.Encoding.UTF8.GetString(buffer, 0, count);
                ShowMsg(result);
            }
        }

        private void ShowMsg(string content, bool isWatchSocket = false)
        {
            if (!isWatchSocket)
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
        }
    }
}