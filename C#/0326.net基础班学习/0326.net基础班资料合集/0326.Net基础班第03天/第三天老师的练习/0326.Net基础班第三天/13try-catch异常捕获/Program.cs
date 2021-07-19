using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13try_catch异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            //abc  sql server 异常
            int number=0;
            bool b = true;
            Console.WriteLine("请输入一个数字");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("你看我执行不执行");
            }
            catch
            {
                Console.WriteLine("输入的字符串不能转换成数字，程序退出！！！");
                b = false;
            }
            if (b)
            {
                Console.WriteLine("您输入的数字是{0}", number);
            }
            Console.ReadKey();
        }
    }
}
