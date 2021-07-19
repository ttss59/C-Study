using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //一次性存储或者声明多个相同类型的变量  数组
            //数组类型[] 数组名=new 数组类型[数组长度];
            int[] nums = new int[10];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 5;
            nums[5] = 6;
            nums[6] = 7;
            nums[7] = 10;
            nums[8] = 9;
            nums[9] = 100;
            nums[10] = 200;

            //表示通过一个循环给数组赋值
            //表示将0-9这10个数字，依次的赋值给数组中的每一个元素
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //}
            ////表示通过一个循环给数组取值
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            Console.ReadKey();
        }
    }
}
