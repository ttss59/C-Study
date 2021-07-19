using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_数组的5个练习
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //练习1：从一个整数数组中取出最大的整数,最小整数,总和,平均值
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = nums[0];//int.MinValue;//nums[0];
            //int min = nums[0];//int.MaxValue;//nums[0];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];
            //}
            //Console.WriteLine("这个数组中的最大值是{0},最小值是{1},总和是{2}，平均值是{3}", max, min, sum, sum / nums.Length);
            //Console.ReadKey();

            //练习3:数组里面都是人的名字,分割成:例如:老杨|老苏|老邹…”
            //(老杨,老苏,老邹,老虎,老牛,老蒋,老王,老马)
            //string[] names = { "老杨", "武藤兰", "老苏", "苍井空", "老赵", "孙中山" };
            ////老杨|武藤兰|老苏|苍井空|老赵|孙中山
            //string str = null;
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    str += names[i] + "|";
            //}
            //Console.WriteLine(str+names[names.Length-1]);
            //Console.ReadKey();

            //练习4：将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数则将这个位置的元素的值加1，
            //如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变。

            //int[] nums = { -9, -87, 0, 123, 34 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        nums[i] += 1;
            //    }
            //    else if (nums[i] < 0)
            //    {
            //        nums[i] -= 1;
            //    }
            //    else
            //    {
            //    }
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            string[] names = { "abc", "Hello", "张三", "哇哈哈哈哈", "金X恩" };

            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}