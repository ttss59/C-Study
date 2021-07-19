using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_while循环的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //            要求用户输入用户名和密码 用户名只要不是admin 密码不是888888
            //            就提示用户一直重新输入

            //循环体：提示用户重新输入用户名和密码
            //循环条件: 用户名只要不是admin 密码不是888888

            //string userName = "";
            //string userPwd = "";
            //Console.WriteLine("请输入用户名");
            //userName = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //userPwd = Console.ReadLine();
            //while(userName!="admin"|| userPwd!="888888")
            //{

            //    Console.WriteLine("请重新输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请重新输入密码");
            //    userPwd = Console.ReadLine();
            //}
            //Console.WriteLine("登陆成功");
            //Console.ReadKey();


            //string userName = "";
            //string userPwd = "";
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    userPwd = Console.ReadLine();
            //    if (userName == "admin" && userPwd == "888888")
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //}
            //Console.ReadKey();



            //  //提示用户输入用户名和密码 admin 888888 最多让用户输入3次  如果3次都不会 则退出登录程序

            //string userName = "";
            //string userPwd = "";
            //int i = 0;
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    userPwd = Console.ReadLine();
            //    if (userName == "admin" && userPwd == "888888")
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //    else
            //    {
            //        i++;
            //    }

            //    if (i >= 3)
            //    {
            //        Console.WriteLine("输入次数已到，程序退出");
            //        break;
            //    }
            //}
            //Console.ReadKey();



            // //要求用户A输入用户名 要求不能为空 "" 
            //只要为空 就提示一直重新输入，要求B输入用户名 第一 不能为空  第二 不能跟用户A的用户名相同

            Console.WriteLine("请输入A的用户名");
            string nameOne = Console.ReadLine();
            //不能为空  重新输入
            //循环条件：用户名A为空
            while (nameOne == "")
            {
                Console.WriteLine("A的用户名不能为空，请重新输入");
                nameOne = Console.ReadLine();
            }


            Console.WriteLine("请输入B的用户名");
            string nameTwo = Console.ReadLine();
            //循环条件：B的用户名为空 或者B的用户名跟A的用户名相同
            while (nameTwo == "" || nameTwo == nameOne)
            {
                if (nameTwo == "")
                {
                    Console.WriteLine("B的用户名不能为空，请重新输入");
                    nameTwo = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("B的用户名不能跟A的用户名相同，请重新输入");
                    nameTwo = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}
