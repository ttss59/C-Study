using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    internal class Program
    {
        /*
         *问题1:求1-100间的所有偶数和?
         *问题2:找出100-999间的水仙花数?
         *问题3:输出九九乘法表(循环的嵌套)
        */

        /// <summary>问题1:求1-100间的所有偶数和?</summary>
        private static void Test01()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine("1-100之间所有偶数和为:{0}", sum);
            Console.ReadKey();
        }

        /// <summary>问题2:找出100-999间的水仙花数?</summary>
        private static void Test02()
        {
            Console.WriteLine("100-999之间的水仙花数有：");
            for (int i = 100; i < 999; i++)
            {
                int x = i / 100;
                int y = (i - 100 * x) / 10;
                int z = (i - x * 100 - y * 10);
                int result = x * x * x + y * y * y + z * z * z;
                if (result == i)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        /// <summary>问题3:输出九九乘法表(循环的嵌套)</summary>
        private static void Test03()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j != i)
                        Console.Write("{0}*{1}={2}\t", j, i, i * j);
                    else
                        Console.WriteLine("{0}*{1}={2}", j, i, i * j);
                }
            }
            Console.ReadKey();
        }

        private static void Test04()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j < 9)
                        Console.Write("{0}*{1}={2}\t", j, i, i * j);
                    else
                        Console.WriteLine("{0}*{1}={2}", j, i, i * j);
                }
            }

            Console.ReadKey();
        }

        /// <summary>根据用户输入的数字，打印该数字的加法表</summary>
        private static void Test05()
        {
            Console.WriteLine("请输入要打印的加法表的数字：");
            int result = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= result; i++)
            {
                Console.WriteLine("{0}+{1}={2}", i, result - i, result);
            }
            Console.ReadKey();
        }

        private static void Test06()
        {
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("out num : " + num);
            Console.ReadKey();
        }

        随机

        private static void Main(string[] args)
        {
            //Test01();
            //Test02();
            //Test03();
            //Test04();
            //Test05();
            Test06();
        }
    }
}