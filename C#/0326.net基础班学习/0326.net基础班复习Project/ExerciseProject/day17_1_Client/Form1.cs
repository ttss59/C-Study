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

namespace day17_1_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectBut_Click(object sender, EventArgs e)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //此客户端连接本地ip，所以可以不用ipTxt中的文本，直接用IPAddress.Any
            IPAddress ip = IPAddress.Parse(severIPTxt.Text);
            IPEndPoint port = new IPEndPoint(ip, int.Parse(portTxt.Text));
            socket.Connect(port);
            Socket severSocket = socket.Accept();
            if (severSocket != null)
                ShowMessage(severSocket.LocalEndPoint.ToString() + ":" + "连接成功！");
        }

        private void ShowMessage(string content)
        {
            showTxt.Text += content + "/r/n";
            // showTxt.AppendText(content + "/r/n");
        }
    }
}