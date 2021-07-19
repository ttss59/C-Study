using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07方法的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //用方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string max = GetLongest(names);
            //Console.WriteLine(max);
            //Console.ReadKey();
        
          //  81、写一个方法，用来判断用户输入的数字是不是质数  再写一个方法 要求用户只能输入数字 输入有误就一直让用户输入数字
            Console.WriteLine("请输入一个数字");
            int number = Convert.ToInt32(Console.ReadLine());
            //只能被1和自身整除的数字叫质数
            bool b = IsPrime(number);
            Console.WriteLine(b);
            Console.ReadKey();

        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else//>=2
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }


        public static string GetLongest(string[] names)
        {
            string max = names[0];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > max.Length)
                {
                    max = names[i];
                }
            }
            return max;
        }
    }
}
