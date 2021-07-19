using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //问题:让用户输入他的语文和数学成绩,计算他的总成绩并显示出来?
            //Console.WriteLine("请首先输入你的语文成绩");
            //string strChinese = Console.ReadLine();
            //Console.WriteLine("在输入你的数学成绩");
            //string strMath = Console.ReadLine(); //100 90  


            //int chinese = Convert.ToInt32(strChinese);
            //int math = Convert.ToInt32(strMath);
            // int chinese = (int)strChinese;

            //string str = "123afdf";
            //int n = Convert.ToInt32(str);
            string str = "12.34";
            double d = Convert.ToDouble(str);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
