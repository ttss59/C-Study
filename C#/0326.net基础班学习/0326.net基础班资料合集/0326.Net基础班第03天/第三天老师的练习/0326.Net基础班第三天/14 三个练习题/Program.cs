using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_三个练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：提示用户输入密码，如果密码是“88888”则提示正确，
            //否则要求再输入一次，如果密码是“88888”则提示正确，
            //否则提示错误,程序结束。(如果我的密码里有英文还要转换吗,密码:abc1)


            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();
            //if (pwd == "88888")
            //{
            //    Console.WriteLine("正确");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误，请重新输入");
            //    pwd = Console.ReadLine();
            //    if (pwd == "88888")
            //    {
            //        Console.WriteLine("第二次输入正确");
            //    }
            //    else
            //    {
            //        Console.WriteLine("白痴，两次都不对，程序退出！！！");
            //    }
            //}
            //Console.ReadKey();




            //练习2：提示用户输入用户名，然后再提示输入密码，            //如果用户名是“admin”并且密码是“88888”，则提示正确，            //否则，如果用户名不是admin还提示用户用户名不存在,            //如果用户名是admin则提示密码错误.
            //Console.WriteLine("请输入用户名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();

            //if (name == "admin" && pwd == "88888")
            //{
            //    Console.WriteLine("登陆成功");
            //}
            //else if (name == "admin")
            //{
            //    Console.WriteLine("密码错误");
            //}
            //else if (pwd == "88888")
            //{
            //    Console.WriteLine("用户名错误");
            //}
            //else
            //{
            //    Console.WriteLine("未知错误");
            //}
            //Console.ReadKey();



            //练习3：提示用户输入年龄，如果大于等于18，则告知用户可以查看，
            //如果小于10岁，则告知不允许查看，如果大于等于10岁并且小于18，
            //则提示用户是否继续查看（yes、no），如果输入的是yes则提示用户请查看，
            //否则提示"退出,你放弃查看"。

            Console.WriteLine("请输入你的年龄");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("看吧，早晚你都要知道");
            }
            else if (age < 10)
            {
                Console.WriteLine("滚蛋，回家吃奶去");
            }
            else if(age>=10&&age<18)
            {
                Console.WriteLine("你确定要看么？看yes 不看 no");
                string input = Console.ReadLine();//yes no
                if (input == "yes")
                {
                    Console.WriteLine("看吧，早熟的孩子，后果自负哟~~");
                }
                else
                {
                    Console.WriteLine("乖孩子，回家吃奶去好了，没出息");
                }
            }
            Console.ReadKey();


        }
    }
}
