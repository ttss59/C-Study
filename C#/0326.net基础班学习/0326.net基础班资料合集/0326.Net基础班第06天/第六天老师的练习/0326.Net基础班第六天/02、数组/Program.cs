using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               // nums[i]  两种理解方式：1代表数组中当前循环到的这个元素  2、由于在循环中，也可以认为是数组
                //中的每一个元素
                sum += nums[i];

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
