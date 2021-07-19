using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04params
{
    class Program
    {
        static void Main(string[] args)
        {
            //求任意数字中的最大值

            //int max = GetMax(new int[] { 1, 2, 3, 4, 5 });
            int max = GetMax(1, 2, 3, 4, 5);
            Console.WriteLine(max);
            Console.ReadKey();
        }

        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
