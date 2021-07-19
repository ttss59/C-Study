using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //循环结构
            //输出10遍  欢迎来到传智播客学习.Net
            //循环体：向控制台打印一行文本
            //循环条件：打印的次数小于10
            //int i = 0;//声明一个循环变量记录循环的次数
            //while (i < 10)
            //{
            //    Console.WriteLine("欢迎来到传智播客学习第{0}次",i+1);
            //    i++;
            //}
            //Console.ReadKey();


            //求1-100之间所有整数的和
            //循环体：累加
            //循环条件：i<=100
            int i = 1;
            int sum = 0;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    sum += i;//sum=sum+i;
                }
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

           //1-100奇数的和
            //1-100偶数的和
        }
    }
}
