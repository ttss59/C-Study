using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法 返回两个数字中的最大值
            //int max = GetMax(5, 8);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //写一个方法  计算一个整数数组中的最大值
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = GetMaxTwo(nums);
            Console.WriteLine("这个数组的最大值是{0}",max);
            Console.ReadKey();
        }



        /// <summary>
        /// 计算一个数组中的最大值 
        /// </summary>
        /// <param name="numbers">要求最大值的数组</param>
        /// <returns>返回这个数组的最大值</returns>
        public static int GetMaxTwo(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }



        /// <summary>
        /// 比较两个数字中的最大值，并返回最大值
        /// </summary>
        /// <param name="n1">要比较的数字1</param>
        /// <param name="n2">要比较的数字2</param>
        /// <returns>返回比较大的数字</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

    }
}
