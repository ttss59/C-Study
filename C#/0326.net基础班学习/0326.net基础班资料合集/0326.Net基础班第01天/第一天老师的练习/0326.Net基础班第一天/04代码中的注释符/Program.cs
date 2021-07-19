using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04代码中的注释符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");//这行代码能够将 "Hello World" 打印到控制台
            Console.ReadKey();//这行代码能够暂停这个程序 




            /*Console.WriteLine("Hello World");
            Console.ReadKey();
            Console.WriteLine("Hello World");
            Console.ReadKey();
            Console.WriteLine("Hello World");
            Console.ReadKey();
            Console.WriteLine("Hello World");
            Console.ReadKey();
            Console.WriteLine("Hello World");
            Console.ReadKey();
            Console.WriteLine("Hello World");
            Console.ReadKey();
            Console.WriteLine("Hello World");
            Console.ReadKey();*/
        }





        /// <summary>
        /// 这个方法能够帮助我们计算两个整数之间的最大值
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回这两个整数中最大的那个数字</returns>

        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
