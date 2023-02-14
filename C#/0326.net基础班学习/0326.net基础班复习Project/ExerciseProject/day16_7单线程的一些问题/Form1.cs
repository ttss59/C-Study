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

namespace day16_7单线程的一些问题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread thread;

        private void button1_Click(object sender, EventArgs e)
        {
            //单线程执行耗时的方法，会导致程序伪卡死
            //Test();

            //新建子线程去执行耗时方法
            //Thread thread = new Thread(Test);
            thread = new Thread(Test2);
            //设置后台线程
            thread.IsBackground = true;

            //开启子线程，让子线程准备好，等待主线程随时启动,Start这个方法只是让子线程准备好，并不是开启子线程，子线程的开始还是由主线程启动
            thread.Start();

            //thread.Abort();
            ////线程一旦被关闭了 就不能再被打开了
            //thread.Start();
        }

        /// <summary>
        /// 测试耗时方法
        /// </summary>
        private void Test2()
        {
            for (int i = 0; i < 100000; i++)
            {
                textBox1.Text = i.ToString();
            }
        }

        /// <summary>
        /// 测试耗时方法
        /// </summary>
        private void Test()
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(i.ToString());//这个打印还是挺耗资源的，所以即使使用子线程执行，还是会导致卡顿
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程之间的校验
            //没有下面这句话会报错: System.InvalidOperationException:“线程间操作无效: 从不是创建控件“textBox1”的线程访问它。”
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //由于主线程已被关闭，但是子线程没有手动关闭，那么可能出现主线程关闭了，子线程还是使用主线程中的组件，导致报出如下错误
            //System.InvalidOperationException:“执行 CreateHandle() 时无法调用值 Dispose()。”
            //所以为了避免报错，应该在窗口正在关闭的事件中添加关闭子线程的方法
            if (thread != null)
                thread.Abort();//关闭子线程，释放资源
        }
    }
}