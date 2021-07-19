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

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //创建一个负责监听的Socket
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //创建IP地址和端口号对象
            IPAddress ip = IPAddress.Any;//IPAddress.Parse(txtServer.Text);
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            //让负责监听的Socket绑定IP地址跟端口号
            socketWatch.Bind(point);
            ShowMsg("监听成功");
            //设置监听队列
            socketWatch.Listen(10);
            //负责监听的Socket 来接受客户端的连接  创建跟客户端通信的Socket
            Socket socketSend = socketWatch.Accept();
            ShowMsg(socketSend.RemoteEndPoint.ToString() + "连接成功");

        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }
    }
}
