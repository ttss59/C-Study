using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14out参数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用out参数返回一个数组的最大值、最小值、总和、平均值
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max;
            int min;
            int sum;
            int avg;
            GetMaxMinSumAvg(nums, out  max, out min, out sum, out avg);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadKey();
        }

        public static void GetMaxMinSumAvg(int[] nums, out int max, out int min, out int sum, out int avg)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i =0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
        }
    }
}
