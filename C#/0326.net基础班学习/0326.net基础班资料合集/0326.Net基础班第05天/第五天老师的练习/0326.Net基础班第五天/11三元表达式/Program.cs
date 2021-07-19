using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字 我们输出比较大的那个数字
            //Console.WriteLine("请输入第一个数字");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());

            ////表达式1?表达式2:表达式3;
            //int max = numberOne > numberTwo ? numberOne : numberTwo;
            //Console.WriteLine(max);
            //Console.ReadKey();
            //if (numberOne > numberTwo)
            //{
            //    Console.WriteLine(numberOne);
            //}
            //else
            //{
            //    Console.WriteLine(numberTwo);
            //}
            //Console.ReadKey();

            Console.WriteLine("请输入一个姓名");
            string name = Console.ReadLine();
            //if (name == "老赵")
            //{
            //    Console.WriteLine("孙中山转世");
            //}
            //else
            //{
            //    Console.WriteLine("山炮一个");
            //}
            string result = name == "老赵" ? "孙中山转世" : "山炮一个";
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
