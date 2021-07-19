using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习题1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //编写一段程序，运行时向用户提问“你考了多少分？（0~100）”，
            //接受输入后判断其等级并显示出来。判断依据如下：
            ////等级={优 （90~100分）；良 （80~89分）；中 （60~69分）；差 （0~59分）；}
            //Console.WriteLine("请输入考试成绩");
            //int s=Convert.ToInt32(Console.ReadLine());
            //string level = GetLevel(s);
            //Console.WriteLine(level);
            //Console.ReadKey();

            //编程输出九九乘法表。
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <=9 ; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //定义长度50的数组,随机给数组赋值,并可以让用户输入一个数字n,按一行n个数输出数组
            //int[]  array = new int[50];     Random r = new Random();  r.Next();
            //int[] nums = new int[50];
            //Random r = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = r.Next(1, 10);
            //}
            //Console.WriteLine("请输入一个数字");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < nums.Length; i++)
            //{

            //    if ((i) % number == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //    Console.Write(nums[i] + "\t");
            //}
            //Console.ReadKey();

            //编写一个函数,接收一个字符串,把用户输入的字符串中的第一个字母转换成小写然后返回(命名规范  骆驼命名)  
            //name       s.SubString(0,1)      s.SubString(1);
            //ADFDSdsfsdfAFdsfsd  aDFDSdsfsdfAFdsfsd

            Console.WriteLine("请输入一个字符串");
            string str = Console.ReadLine();
            string strNew = GetStr(str);
            Console.WriteLine(strNew);
            Console.ReadKey();

        }


        public static string GetStr(string s)
        {
            s = s.Substring(0, 1).ToLower() + s.Substring(1);
            return s;
        }

        public static string GetLevel(int score)
        {
            string level = "";
            switch (score / 10)
            {
                case 10:
                case 9: level = "优";
                    break;
                case 8: level = "良";
                    break;
                case 7: level = "中";
                    break;
                case 6: level = "差";
                    break;
                default: level = "不及格";
                    break;
            }
            return level;
        }

    }
}
