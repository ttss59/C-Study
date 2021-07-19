using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明两个变量：int n1 = 10, n2 = 20;要求将两个变量交换
            //，最后输出n1为20,n2为10。扩展（*）：不使用第三个变量如何交换？

            int n1 = 10;
            int n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;


            //n1 = n1 - n2;
            //n2 = n1 + n2;
            //n1 = n2 - n1;
            ////ref将值传递变成引用传递
            //Change(ref n1,ref  n2);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.ReadKey();

            //用方法来实现：计算两个数的最大值。思考：方法的参数？
            //返回值？扩展（*）：计算任意多个数间的最大值（提示：params）。

            //params  out ref
            //int max = GetMax(1, 2, 3, 4, 5);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //用方法来实现：判断一个给定的整数是否为“质数”。

            //while (true)
            //{
            //    Console.WriteLine("请输入一个数字");
            //    int n = int.Parse(Console.ReadLine());
            //    bool b = IsPrime(n);
            //    Console.WriteLine(b);
            //    Console.ReadKey();
            //}

            //用方法来实现：计算1-100之间的所有质数（素数）的和
            int sum = GetPrimeSum();
            Console.WriteLine(sum);
            Console.ReadKey();

        }

        public static int GetPrimeSum()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                bool b = true;
                for (int j =2; j <i ; j++)
                {
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    sum+=i;
                }
            }
            return sum;
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

        public static void Change(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
