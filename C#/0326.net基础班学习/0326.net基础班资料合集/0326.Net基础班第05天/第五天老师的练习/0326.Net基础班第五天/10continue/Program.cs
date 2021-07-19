using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 10)
            //{
            //   // break;
            //    continue;
            //    Console.WriteLine("Hello World");
            //}
            //Console.ReadKey();


            //练习1：用 while continue实现计算1到100(含)之间的除了能被7整除之外所有整数的和。
            //int i = 1;
            //int sum = 0;
            //while (i<=100)
            //{
            //    if (i % 7 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();



            //打印1-100之间所有的质数
            //质数：只能被1和自身整除的数字 叫做质数
            //判断一个整数是否是质数：让这个整数从2开始除，除到自己的前一位

            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)//不是质数
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
    }
}
