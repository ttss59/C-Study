using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //自动类型转换或者隐式类型转换
            //1)、类型必须相兼容 (int和double)
            //2)、必须是小的类型转大的类型
            //int n=10;
            //double d = n;

            //强制类型转换 显示类型转换 结果：丢失精度
            //303.6===》303   double---->int
            //int result = (int)303.6;
            //Console.WriteLine(result);
            //Console.ReadKey();
            //int a = 10, b = 3;
            //int m = a % b;
            //double q = a*1.0 / b;
            //Console.WriteLine(m);
            //Console.WriteLine("{0:0.00}",q);
            //Console.ReadKey();
            //double d = 3.1000;
            //Console.WriteLine("{0:0.00}",d);
            //Console.ReadKey();


            int a = 10;
            int b = 3;
            double d = 10 / 3 + 0.1;
            Console.WriteLine(d);
            Console.ReadKey();

            //Console.WriteLine(3*1.1);
            //Console.ReadKey();
        }
    }
}