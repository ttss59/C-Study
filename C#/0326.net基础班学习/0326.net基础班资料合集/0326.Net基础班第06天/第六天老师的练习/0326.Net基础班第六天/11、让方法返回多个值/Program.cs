using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_让方法返回多个值
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //写一个方法 让这个方法返回一个数组的最大值、最小值、总和、平均值
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numsNew = GetMaxMinSumAvg(nums);
            Console.WriteLine("这个数组的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}",numsNew[0],numsNew[1],numsNew[2],numsNew[3]);
            Console.ReadKey();
        }


        /// <summary>
        /// 返回一个数组的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] GetMaxMinSumAvg(int[] nums)//string double bool
        {
            int[] numsNew = new int[4];
            //numsNew[0]最大值  numsNew[1]最小值 numsNew[2]总和 numsNew[3]平均值
            numsNew[0] = nums[0];//int max=nums[0]
            numsNew[1] = nums[0];//int min=nums[0]
            numsNew[2] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > numsNew[0])
                {
                    numsNew[0] = nums[i];
                }
                if (nums[i] < numsNew[1])
                {
                    numsNew[1] = nums[i];
                }
                numsNew[2] += nums[i];
            }
            numsNew[3] = numsNew[2] / nums.Length;
            return numsNew;
        }

    }
}
