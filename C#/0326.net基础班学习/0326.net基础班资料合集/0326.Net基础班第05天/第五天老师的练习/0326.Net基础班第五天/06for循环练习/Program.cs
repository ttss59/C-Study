﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06for循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <=num ; i++)
            {
                Console.WriteLine("{0}+{1}={2}", i, num - i, num);
            }
            Console.ReadKey();
        }
    }
}
