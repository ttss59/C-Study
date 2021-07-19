using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字  计算这两个数字之间所有整数的和
            //1、用户只能输入数字
            //3、计算两个数字之间和
            //2、要求第一个数字必须比第二个数字小  就重新输入
            Console.WriteLine("请输入第一个数字");
            string strNumberOne = Console.ReadLine();
            int numberOne = GetNumber(strNumberOne);
            Console.WriteLine("请输入第二个数字");
            string strNumberTwo = Console.ReadLine();
            int numberTwo = GetNumber(strNumberTwo);
            Judge(ref numberOne,ref  numberTwo);
            int sum = GetSum(numberOne, numberTwo);
            Console.WriteLine("{0}到{1}之间的总和是{2}", numberOne, numberTwo, sum);
            Console.ReadKey();
        }


        /// <summary>
        /// 获得一个整数
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    strNumber = Console.ReadLine();
                }
            }
        }


        public static void Judge(ref int n1,ref  int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else//n1>=n2
                {
                    Console.WriteLine("第一个数字不能大于第二个数字，请重新输入第一个数字");
                    string s1 = Console.ReadLine();
                    n1 = GetNumber(s1);
                    Console.WriteLine("请重新输入第二个数字");
                    string s2 = Console.ReadLine();
                    n2 = GetNumber(s2);
                }
            }
            
        }



        public static int GetSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
