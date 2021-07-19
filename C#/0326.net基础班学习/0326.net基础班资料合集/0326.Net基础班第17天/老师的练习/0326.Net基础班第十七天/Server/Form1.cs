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
using System.IO;
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
            try
            {
                //创建了一个负责监听引用程序IP地址和端口号的Socket
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //获得IP地址
                IPAddress ip = IPAddress.Any;//IPAddress.Parse()
                //获得端口号对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //让负责监听的Socket绑定端口号
                socketWatch.Bind(point);
                //设置监听队列
                socketWatch.Listen(10);
                ShowMsg("监听成功");
                //开启新的线程来执行Listen方法
                Thread th1 = new Thread(Listen);
                th1.IsBackground = true;
                th1.Start(socketWatch);
            }
            catch
            {

            }

        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }




        //存储ip地址和负责跟客户端通信的Socket
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        //将负责通信的Socket写到方法外面，方便别的方法调用
        Socket socketSend;
        /// <summary>
        /// 监听客户端的连接  并创建与之通信的Socket
        /// </summary>
        /// <param name="o"></param>
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                try
                {
                    //通过Accept这个方法创建负责和客户端通信的Socket
                    socketSend = socketWatch.Accept();
                    //将远程客户端的IP地址跟端口号存储到ComboBox中
                    cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                    //再将IP地址和IP地址所对应的Socket添加到键值对集合中
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + "连接成功");
                    //开启一个新线程来不停的接受客户端发送来的消息
                    Thread th2 = new Thread(Rec);
                    th2.IsBackground = true;
                    th2.Start(socketSend);
                }
                catch
                {

                }
            }
        }


        /// <summary>
        /// 不停的接受客户端发来的消息
        /// </summary>
        /// <param name="o"></param>
        void Rec(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    //服务端开始接收客户端发来的数据
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //服务端实际接收到的有效字节数
                    int r = socketSend.Receive(buffer);
                    //表示客户端下线了
                    if (r == 0)
                    {
                        break;
                    }
                    //将字节数组转换成字符串
                    string str = System.Text.Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + str);
                }
                catch
                {

                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //在程序加载的时候 取消跨线程的检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }



        /// <summary>
        /// 服务端给客户端发送文字消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txtMsg.Text);

            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            //将集合转换成字节数组
            byte[] newBuffer = list.ToArray();
            //获得在下拉框中选中的IP地址
            string ip = cboUsers.SelectedItem.ToString();
            dicSocket[ip].Send(newBuffer);
        }



        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\SpringRain\Desktop";
            ofd.Title = "请选择要发送的文件";
            ofd.Filter = "文本文件|*.txt|音乐文件|*.wav|图片文件|*.jpg|所有文件|*.*";
            ofd.ShowDialog();
            //获得选中文件的路径
            string path = ofd.FileName;
            txtPath.Text = path;
        }



        /// <summary>
        /// 向客户端发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            using (FileStream fsRead = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fsRead.Length];
                //实际读取到的有效字节数
                int r = fsRead.Read(buffer, 0, buffer.Length);

                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                //先获得用户选择的IP地址
                string ip = cboUsers.SelectedItem.ToString();
                dicSocket[ip].Send(newBuffer);
            }
        }



        /// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZD_Click(object sender, EventArgs e)
        {
            byte[] buffer=new byte[1];
            buffer[0] = 2;
            string ip = cboUsers.SelectedItem.ToString();
            dicSocket[ip].Send(buffer);
        }
    }
}
