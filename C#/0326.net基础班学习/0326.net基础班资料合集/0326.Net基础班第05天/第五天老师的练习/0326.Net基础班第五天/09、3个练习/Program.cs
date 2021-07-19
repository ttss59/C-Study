using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1:输入班级人数  并计算平均年龄,
            //如果录入的数据出现负数或大于100的数,立即停止输入并报错.


            //只要输入有误，就要求一直重新输入
            #region 练习1
            //int count=0;
            //while (true)
            //{
            //    Console.WriteLine("请输入班级人数");
            //    try
            //    {
            //        count = Convert.ToInt32(Console.ReadLine());
            //        break;//如果count转换成功，则没有必要继续循环
            //    }
            //    catch//输入有误
            //    {
            //        Console.WriteLine("输入有误!请重新输入");
            //    }
            //}

            //bool b = true;
            //int sum=0;
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的年龄", i + 1);
            //    try
            //    {
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        if (age >= 0 && age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            b = false;
            //            Console.WriteLine("输入的年龄不再正确范围内!!程序退出！！");
            //            break;
            //        }
            //    }
            //    catch//输入的不是数字
            //    {
            //        i--;
            //    }
            //}

            //if (b)
            //{
            //    Console.WriteLine("{0}个人的班级平均年龄是{1}", count, sum / count);
            //}
            //Console.ReadKey(); 
            #endregion


            //练习2：在while中用break实现要求用户一直输入用户名和密码，
            //只要不是admin、88888就一直提示要求重新输入,如果正确则提登录成功.

            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    string pwd = Console.ReadLine();
            //    if (name == "admin" && pwd == "88888")
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //}

            //1~100之间的整数相加，得到累加值大于20的当前数(比如:1+2+3+4+5+6=21)结果6
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                if (sum >= 20)
                {
                    Console.WriteLine(i);
                    break;
                }
            }


            Console.ReadKey();
            
        }
    }
}
