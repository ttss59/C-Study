﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个年份");
            int year = Convert.ToInt32(Console.ReadLine());

            ////年份能够被400整除.(2000)
            ////年份能够被4整除但不能被100整除.(2008)
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            Console.WriteLine(b);
            Console.ReadKey();

            // & | 

          //  5 < 3 & 3 > 2;
         //   5 > 3 | 3 > 5;

        }
    }
}
