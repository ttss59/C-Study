using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04可变参数数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //求任意数字中的总和
            // int[] s={98,79,65};
            //GetScore("张三", 98, 79, 65,100,100);
            //Console.ReadKey();
       //     int[] n={1,2,3,4,5};
            int sum = GetSum(1.5,2,3,4,5,6);
            Console.Write(sum);
            Console.ReadKey();
        }

        public static int GetSum(double d,params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }


        public static void GetScore(string name,int id ,params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }

            Console.WriteLine("{0}这次考试的总成绩是{1}", name, sum);
        }

    }
}
