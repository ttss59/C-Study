using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10算数运算符
{
    class Program
    {
        static void Main(string[] args)
        {

            //演示:某学生三门课成绩为,语文:90  数学:80  英语:67,编程求总分和平均分.
            int chinese = 90;
            int math = 80;
            int english = 67;
            int sum = chinese + math + english;
            Console.WriteLine("总分是{0}，平均分是{1}", chinese + math + english, (chinese + math + english) / 3);
            Console.ReadKey();
        }
    }
}
