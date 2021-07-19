using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03return关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World");
                //break;//跳出当前循环
               // continue; 跳到循环条件进行判断
                return;
            }
            Console.WriteLine("哈哈哈");
            Console.ReadKey();
        }
    }
}
