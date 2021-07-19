using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_while循环的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入yes或者no，只要不是yes或者no，就一直提示用户重新输入，只能输入yes和no
            //循环体：提示用户输入yes或者no，接收，判断
            //循环条件：不是yes || 不是no
            Console.WriteLine("请输入yes或者no");
            string input = Console.ReadLine();

            while (input != "yes" && input != "no")
            {
                Console.WriteLine("只能输入yes或者no，请重新输入");
                input = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
