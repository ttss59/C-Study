using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06逻辑运算符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入老苏的语文和数学成绩,输出以下判断是否正确,正确输出True,错误输出False
            //1)老苏的语文和数学成绩都大于90分
            Console.WriteLine("请输入苏小鬼的语文成绩");
            int chinese = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入苏老头的数学成绩");
            int math = Convert.ToInt32(Console.ReadLine());

            // bool b = chinese > 90 && math > 90;
            //2)语文和数学有一门是大于90分的
            bool b = chinese > 90 || math > 90;

            Console.WriteLine(b);
            Console.ReadKey();



        }
    }
}
