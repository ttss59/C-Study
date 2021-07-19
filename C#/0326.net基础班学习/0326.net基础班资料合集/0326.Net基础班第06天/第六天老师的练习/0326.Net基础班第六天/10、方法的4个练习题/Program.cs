using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_方法的4个练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 读取输入的整数，定义成方法，
            //多次调用(如果用户输入的是数字,则返回,否则提示用户重新输入)
            //Console.WriteLine("请输入一个数字");
            //string str = Console.ReadLine();
            //int n = GetNumber(str);
            //Console.WriteLine(n);
            //Console.ReadKey();

            //还记得学循环时做的那道题吗?只允许用户输入y或n,请改成方法

            //Console.WriteLine("请输入yes或者no");
            //string str = Console.ReadLine();
            //string strNew = IsYorN(str);
            //Console.WriteLine("您输入的是{0}",strNew);
            //Console.ReadKey();



            //3查找两个整数中的最大值：int Max(int i1,int i2)


            //计算输入数组的和：int Sum(int[] values)
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int sum = GetSum(nums);
            Console.WriteLine(sum);
            Console.ReadKey();


        }

        public static int GetSum(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }

        /// <summary>
        /// 判断用户输入的是否是yes或者no，只要不是，就重新输入
        /// </summary>
        /// <param name="input">要判断的字符串</param>
        /// <returns>yes或者no</returns>
        public static string IsYorN(string input)
        {
            while (true)
            {
                if (input != "yes" && input != "no")
                {
                    Console.WriteLine("输入有误，只能输入yes或者no");
                    input = Console.ReadLine();
                }
                else
                {
                    return input;
                }
            }
        }




        /// <summary>
        /// 将用户输入的字符串转换成int类型
        /// </summary>
        /// <param name="strNumber">用户输入的字符串</param>
        /// <returns>返回转换成功后的整数</returns>
        public static int GetNumber(string strNumber)//数字  乱七八糟
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


    }
}
