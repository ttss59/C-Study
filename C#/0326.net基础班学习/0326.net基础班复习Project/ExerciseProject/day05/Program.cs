using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05
{
    internal class Program
    {
        /*
         * 练习1:循环录入5个人的年龄并计算平均年龄,如果录入的数据出现负数或大于100的数,立即停止输入并报错.
         * 练习2：在while中用break实现要求用户一直输入用户名和密码，只要不是admin、88888就一直提示要求重新输入,如果正确则提登录成功.
         * 练习3：1~100之间的整数相加，得到累加值大于20的当前数(比如:1+2+3+4+5+6=21)结果6
         */

        /// <summary>测试brake</summary>
        private static void Test01()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                {
                    Console.WriteLine("遇到break 循环再此跳出 i = " + i);
                    break;//用于跳出循环或者switch，不能单纯用于if中
                }
                Console.WriteLine("i < 5 i = " + i);
            }
            Console.ReadKey();
        }

        /// <summary>练习1:循环录入5个人的年龄并计算平均年龄,如果录入的数据出现负数或大于200的数,立即停止输入并报错.</summary>
        private static void Test02()
        {
            int sum = 0;
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("请输入第{0}人的年龄：", count + 1);
                int result = Convert.ToInt32(Console.ReadLine());
                if (result < 0 || result > 200)
                {
                    Console.WriteLine("输入的年龄不合法，程序停止运行！");
                    break;
                }
                count++;
                sum += result;
            }
            Console.WriteLine("正确输入合法的人数为{0}，平均年龄为{1}", count, sum / count);
        }

        /// <summary>练习2：在while中用break实现要求用户一直输入用户名和密码，只要不是admin、88888就一直提示要求重新输入,如果正确则提登录成功.</summary>
        private static void Test03()
        {
            while (true)
            {
                Console.WriteLine("请输入用户名：");
                string user = Console.ReadLine();
                if (user != "admin")
                    continue;
                Console.WriteLine("请输入密码：");
                string password = Console.ReadLine();
                if (password == "888888")
                {
                    Console.WriteLine("恭喜账号为admin，密码为888888,全部输入正确！登录成功！");
                    break;
                }
            }
        }

        /// <summary>试验随机方法</summary>
        private static void Test04()
        {
            Random random = new Random();
            Console.WriteLine("随机产生的数为：" + random.Next(1, 11));//随机数不包含11
        }

        private static void Main(string[] args)
        {
            //Test01();
            //Test02();
            //Test03();
            Test04();

            Console.ReadKey();
        }
    }
}