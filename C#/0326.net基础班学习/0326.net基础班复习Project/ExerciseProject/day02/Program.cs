using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Test01();
            //Test02();
            //Test03();
            //Test04();
            //Test05();
            Test06();
        }

        private static void Test01()
        {
            Console.WriteLine("请问你喜欢吃什么水果？");
            string fruit = Console.ReadLine();
            Console.WriteLine("哦，原来你喜欢吃{0}", fruit);
            Console.ReadKey();
        }

        public static void Test02()
        {
            Console.WriteLine("请输入您的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的性别：");
            string sex = Console.ReadLine();
            Console.WriteLine("请输入您的年龄：");
            string age = Console.ReadLine();
            Console.WriteLine("哦，原来你叫{0}，今年{1}岁，是个{2}生！", name, age, sex);
            Console.ReadKey();
        }

        public static void Test03()
        {
            int a = 10, b = 3;
            int c = a / b;
            double d = a / b;
            Console.WriteLine("c={0},d={1}", c, d);
            Console.ReadKey();
        }

        private static void Test04()
        {
            Console.WriteLine("请输入天数：");
            bool isInputOk = false;
            string input;
            int sumDays, weeks, days;
            do
            {
                input = Console.ReadLine();
                try
                {
                    sumDays = (int)Convert.ToDouble(input);
                    weeks = sumDays / 7;
                    days = sumDays % 7;
                    Console.WriteLine("{0}天是{1}个星期零{2}天！", sumDays, weeks, days);
                    isInputOk = true;
                }
                catch
                {
                    Console.WriteLine("您的输入不正确！ 请输入数字:");
                }
            }
            while (!isInputOk);
            Console.ReadKey();
        }

        /// <summary>
        /// 这次不考虑输入的违法性
        /// </summary>
        private static void Test05()
        {
            Console.WriteLine("请输入小时：");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入分钟：");
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入秒数：");
            double seconds = Convert.ToDouble(Console.ReadLine());
            int sum = (int)(hours * 3600 + minutes * 60 + seconds);
            int sumHours = sum / 3600;
            int days = sumHours / 24;
            int sumMinutes = (sum % 3600) / 60;
            int s = sum - sumHours * 3600 - sumMinutes * 60;
            Console.WriteLine("{0}小时，{1}分钟，{2}秒 是 {3}天{4}小时{5}分钟{6}秒！{7}", hours, minutes, seconds, days, sumHours % 24, sumMinutes, s, (sum % 3600) % 60);
            Console.ReadKey();
        }

        /// <summary>
        /// 这个方法我只是想看看DataTime到底是个啥玩意
        /// </summary>
        private static void Test06()
        {
            Console.WriteLine("System.DateTime.MinValue={0}", System.DateTime.MinValue.Ticks);
            Console.WriteLine("System.DateTime.MaxValue={0}", System.DateTime.MaxValue.Ticks);
            Console.WriteLine("请输入小时：");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入分钟：");
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入秒数：");
            double seconds = Convert.ToDouble(Console.ReadLine());
            long sum = (long)(hours * 3600 + minutes * 60 + seconds);
            DateTime dateTime = new DateTime(sum);//这里的参数不能填秒数，而是要填具体时间刻度
            Console.WriteLine("dataTime.year={0},dataTime.mouse={1},++++++++++++++++dataTime.day={3}+++++++++++,dataTime.minute={3},dataTime.second={4}", dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Minute, dateTime.Second);
            Console.WriteLine("dataTime.year={0},dataTime.mouse={1},dataTime.day={2},dataTime.minute={3},dataTime.second={4}", dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Minute, dateTime.Second);

            Console.ReadKey();
        }
    }
}