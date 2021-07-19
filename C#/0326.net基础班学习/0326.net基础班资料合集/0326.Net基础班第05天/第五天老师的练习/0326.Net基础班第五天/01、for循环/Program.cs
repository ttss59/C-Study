using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //break
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //使用for循环求1-100之间所有整数的和
            int sum = 0;
            for (int i = 1; i <= 100; i+=2)
            {
                    sum += i;
            }
            Console.WriteLine(sum);
            
            Console.ReadKey();
        }
    }
}
