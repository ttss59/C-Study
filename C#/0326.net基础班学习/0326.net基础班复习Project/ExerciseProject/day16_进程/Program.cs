using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16_进程
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //一个开启运行的程序就是一个进程
            //现在的电脑一个进程里包含有多个线程

            //获取电脑现在所有开启的进程
            //Process[] pors = Process.GetProcesses();
            //for (int i = 0; i < pors.Length; i++)
            //{
            //    Console.WriteLine("pros = " + pors[i].ToString());
            //}

            //获取当前进程
            Console.WriteLine("current process = " + Process.GetCurrentProcess());

            //通过代码，直接打开电脑的某些程序（进程）

            //打开计算器
            //Process.Start("calc");
            //打开画板
            //Process.Start("mspaint");

            //两种方式都可以打开ESM
            //Process.Start(@"D:\ZXLab\ESM\ESM");
            //Process.Start(@"D:\ZXLab\ESM\ESM.exe");

            Console.ReadKey();
        }
    }
}