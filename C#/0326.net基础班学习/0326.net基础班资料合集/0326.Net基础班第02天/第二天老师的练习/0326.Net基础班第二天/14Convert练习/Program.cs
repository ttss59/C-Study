using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Convert练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的姓名");
            //声明一个字符串类型的变量来接收用户在控制台的输入
            string name = Console.ReadLine();

            Console.WriteLine("请输入你的语文成绩");
            string strChinese = Console.ReadLine();
            double chinese = Convert.ToDouble(strChinese);

            Console.WriteLine("请输入你的数学成绩");
            string strMath = Console.ReadLine();
            double math = Convert.ToDouble(strMath);

            Console.WriteLine("请输入你的英语成绩");
            string strEnglish = Console.ReadLine();
            double english = Convert.ToDouble(strEnglish);


            Console.WriteLine("{0}你的总成绩是{1}平均成绩是{2:0.00}", name, chinese + math + english, (chinese + english + math) / 3);
            Console.ReadKey();


        }
    }
}
