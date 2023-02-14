using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day16_9_创建监听的Socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            Socket watchSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;//指向的就是本地ip地址
            IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(portTxt.Text));
            watchSocket.Bind(port);
            ShowMessage("设置监听成功!");
            //设置监听队列
            watchSocket.Listen(10);

            //Accept这个方法会一直等待客户端连接，如果一直没有连接，则程序会卡在这里。所以一般要写到子线程中执行
            Socket sendSocket = watchSocket.Accept();
            ShowMessage(sendSocket.RemoteEndPoint.ToString() + " : " + "连接成功!");

            //接收客户端发送的内容，如果用cmd=>telnet 连接的只能接受一个字符
            byte[] buffer = new byte[1024 * 1024 * 3];
            int count = sendSocket.Receive(buffer);
            string result = System.Text.Encoding.UTF8.GetString(buffer, 0, count);
            ShowMessage(sendSocket.RemoteEndPoint.ToString() + " : " + result);
        }

        private void ShowMessage(string content)
        {
            //showTxt.Text += content + "\r\n";
            showTxt.AppendText(content + "\r\n");
        }
    }
}