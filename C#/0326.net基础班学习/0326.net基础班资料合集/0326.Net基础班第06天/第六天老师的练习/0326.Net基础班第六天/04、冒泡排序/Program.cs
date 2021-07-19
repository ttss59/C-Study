using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //升序排列 降序排列
            //int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }; 
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = 0; j < nums.Length - 1-i ; j++)
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

         //   int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] nums = { 4, 8, 6, 5, 1, 2, 9, 7, 3, 0 };
            Array.Sort(nums);//Sort这个方法只能对数组进行升序排列

            Array.Reverse(nums);//反转数组
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
           


            Console.ReadKey();

        }
    }
}
