using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_do_while的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习2：要求用户输入用户名和密码，
            //只要不是admin、888888就一直提示用户名或密码错误,请重新输入。
            //string name = "";
            //string pwd = "";
            ////循环体：输入用户名和密码 判断 
            ////循环条件：输入错误
            //do
            //{
            //    Console.WriteLine("请输入用户名");
            //    name=Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    pwd=Console.ReadLine();
            //    if(name!="admin"||pwd!="888888")
            //    {
            //        Console.WriteLine("用户名或密码错误");
            //    }
            //}while(name!="admin"|| name!="888888");

            //Console.ReadKey();


            //练习3:不断要求用户输入学生姓名,输入q结束.
            //循环体：提示用户输入学生姓名  接收
            //循环条件：输入的不等于q
            //string input = "";//存储用户的输入
            //while (true)
            //{
            //    Console.WriteLine("输入姓名");
            //    input = Console.ReadLine();
            //    if (input == "q")
            //    {
            //        break;
            //    }
            //}
            //Console.ReadKey();
            //do
            //{
            //    Console.WriteLine("请输入学生姓名");
            //    input = Console.ReadLine();
            //}while(input!="q");

            //while (input != "q")
            //{
            //    Console.WriteLine("请输入学生姓名");
            //    input = Console.ReadLine();
            //}
            //   Console.ReadKey();


            //练习4：不断要求用户输入一个数字，然后打印这个数字的二倍，
            //当用户输入q的时候程序退出。


            //循环体：提示用户输入数字  转换 打印这个数字的2倍
            //循环条件：输入的不能是q

            //string strNumber = "";//存储的用户的输入
            //do
            //{
            //    Console.WriteLine("请输入数字");
            //    strNumber = Console.ReadLine();//数字  q    乱七八糟
            //    if (strNumber != "q")//数字  乱七八糟
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(strNumber);
            //            Console.WriteLine("这个数字的2倍是{0}", number * 2);
            //        }
            //        catch//输入的是乱七八糟
            //        {
            //            Console.WriteLine("输入有误，请重新输入");
            //        }
            //    }
            //    else//==q
            //    {
            //        Console.WriteLine("你输入的是q，程序退出！！！");
            //    }
            //} while (strNumber != "q");
            //Console.ReadKey();
            //while (strNumber != "q")
            //{
            //    Console.WriteLine("请输入数字");
            //    strNumber = Console.ReadLine();//数字  q    乱七八糟
            //    if (strNumber != "q")//数字  乱七八糟
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(strNumber);
            //            Console.WriteLine("这个数字的2倍是{0}", number * 2);
            //        }
            //        catch//输入的是乱七八糟
            //        {
            //            Console.WriteLine("输入有误，请重新输入");
            //        }
            //    }
            //    else//==q
            //    {
            //        Console.WriteLine("你输入的是q，程序退出！！！");
            //    }
            //}


            //练习5：不断要求用户输入一个数字（假定用户输入的都是正整数），
            //当用户输入end的时候显示刚才输入的数字中的最大值
            //循环体:提示用户输入一个数字 接收 转换 比较的过程
            //循环条件：输入的不能是end

            string strNumber = "";
            int max = 0;//用来存储最大值
            while (strNumber != "end")
            {
                Console.WriteLine("请输入一个数字，输入end，我们将显示你输入的数字中的最大值");
                strNumber = Console.ReadLine();//数字 end  乱七八糟
                if (strNumber != "end")
                {
                    try
                    {
                        int number = Convert.ToInt32(strNumber);
                        if (number > max)
                        {
                            max = number;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("输入有误，请重新输入");
                    }
                }
                else//输入的是end
                {
                    Console.WriteLine("您刚才输入的数字中最大值是{0}",max);
                }
            }
            Console.ReadKey();

        }
    }
}
