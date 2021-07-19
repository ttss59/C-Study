using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //进程:我们每一个应用程序都是一个进程
            //而进程又是由多个线程组成的
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    // 不试的不是爷们
            //    //item.Kill();  蓝屏  
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //Console.WriteLine(Process.GetCurrentProcess().ToString());
            //Console.ReadKey();


            //Process.Start("calc");
            //Process.Start("mspaint");
            //Process.Start("iexplore", "http://www.baidu.com");
            Thread.Sleep(3000);
            Console.WriteLine("Hello World");
            //Process.Start("devenv");
            Console.ReadKey();
        }
    }
}
