﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Switch_case前奏
{
    class Program
    {
        static void Main(string[] args)
        {
            //李四的年终工作评定,如果定为A级,则工资涨500元,如果定为B级,            //则工资涨200元,如果定为C级,工资不变,如果定为D级工资降200元,            //如果定为E级工资降500元.            //设李四的原工资为5000,请用户输入李四的评级,然后显示李四来年的工资.


            //switch(要判断的变量或者表达式)
            //{
            //    case 值1:要执行的代码;
            //    break;
            //    case 值2:要执行的代码;
            //    break;
            //    case 值3:要执行的代码;
            //    break;
            //    ........
            //    default:要执行的代码;
            //    break;
            //}
            bool b = true;
            Console.WriteLine("请输入对李四的一个年终评定");
            string level = Console.ReadLine();
            double salary = 5000;
            switch (level)
            {
                case "A": salary += 500;
                    break;
                case "B": salary += 200;
                    break;
                case "C": break;
                case "D": salary -= 200;
                    break;
                case "E": salary -= 500;
                    break;
                default: Console.WriteLine("输入有误，程序退出！！！");
                    b = false;
                    break;
            }
            if (b)
            {
                Console.WriteLine("李四明年的工资是{0}", salary);
            }
            Console.ReadKey();
            #region if else-if的做法
            //bool b = true;
            //Console.WriteLine("请输入对李四的年终评定");
            //string level = Console.ReadLine();//A B C D E 乱七八糟
            //double salary = 5000;
            //if (level == "A")
            //{
            //    salary += 500;//salary=salary+500;
            //}
            //else if (level == "B")
            //{
            //    salary += 200;
            //}
            //else if (level == "C")
            //{
            //   // salary += 0;
            //}
            //else if (level == "D")
            //{
            //    salary -= 200;
            //}
            //else if (level == "E")
            //{
            //    salary -= 500;
            //}
            //else//输入错误
            //{
            //    Console.WriteLine("输入有误，程序退出！！！");
            //    b = false;
            //}
            //if (b)
            //{
            //    Console.WriteLine("李四明年的工资是{0}", salary);
            //}
            //Console.ReadKey(); 
            #endregion
        }
    }
}
