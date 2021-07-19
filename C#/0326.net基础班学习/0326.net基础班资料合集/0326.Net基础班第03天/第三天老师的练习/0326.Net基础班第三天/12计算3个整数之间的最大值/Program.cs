using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12计算3个整数之间的最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();



            //if (a > b)
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine("最大值是{0}",a);
            //    }
            //    else//c>a
            //    {
            //        Console.WriteLine("最大值是{0}",c);
            //    }
            //}
            //else//b>a
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine("最大值是{0}", b);
            //    }
            //    else//b<c
            //    {
            //        Console.WriteLine("最大值是{0}",c);
            //    }
            //}
            Console.ReadKey();
        }
    }
}
