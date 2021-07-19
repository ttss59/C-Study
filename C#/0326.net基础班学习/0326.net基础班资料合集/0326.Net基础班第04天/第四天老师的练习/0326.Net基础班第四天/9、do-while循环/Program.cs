using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //明天小兰就要登台演出了,老师说再把明天的演出的歌曲唱一遍,
            //如果满意,小兰就可以回家了.否则就需要再练习一遍,直到老师满意为止.(y/n)

            //循环体：小兰唱一遍，问老师，老师回答
            //循环条件：老师不满意

            //Console.WriteLine("老师，我唱的你满意么？");
            //string answer = Console.ReadLine();
            //while (answer == "no")
            //{
            //    Console.WriteLine("老师，我再唱一遍，你满意么？");
            //    answer = Console.ReadLine();
            //}

            //Console.WriteLine("OK，放学回家");
            //Console.ReadKey();


            string answer = "";
            do
            {
                Console.WriteLine("老师，我唱的这一遍你满意么？");
                answer = Console.ReadLine();
            } while (answer == "no");
            Console.WriteLine("Ok，放学回家");
            Console.ReadKey();
        }
    }
}
