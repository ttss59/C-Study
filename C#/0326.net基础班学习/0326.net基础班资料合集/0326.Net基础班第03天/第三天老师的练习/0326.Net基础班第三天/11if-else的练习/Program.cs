using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11if_else的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //2、 要求用户输入两个数a、b，如果a和b整除或者a加b大于100，
            //则输出a的值，否则输出b的值
            //Console.WriteLine("请输入第一个数字");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int b = Convert.ToInt32(Console.ReadLine());

            //bool bb = a % b == 0 || a + b > 100;
            //if (bb)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}
            //Console.ReadKey();



            //对学员的结业考试成绩评测(考虑用if好还是用if-else好)             //         成绩>=90 ：A                   //90>成绩>=80 ：B 	             //80>成绩>=70 ：C             //70>成绩>=60 ：D             //         成绩<60  ：E

            Console.WriteLine("请输入你的考试成绩");
            int score = Convert.ToInt32(Console.ReadLine());
            #region if的做法
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //if (score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //if (score < 60)
            //{
            //    Console.WriteLine("E");
            //} 
            #endregion
            #region if -else的做法
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else//<90
            //{
            //    if (score >= 80)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else//<80
            //    {
            //        if (score >= 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else//<70
            //        {
            //            if (score >= 60)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {
            //                Console.WriteLine("E");
            //            }
            //        }
            //    }
            //} 
            #endregion



            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
        






            //计算两个数字之间的最大值
            //计算三个数字之间的最大值 不考虑相等

            //a b c
            /*
             如果(a>b)
             * {
             *   如果(a>c)
             *   {
             *  a最大  
             * }
             * 否则
             * {
             *  c最大
             * }
             * }
             * 
             * 否则
             * 
             * {
             *  如果(b>c)
             *  {
             *  b最大 
             * }
             * 否则
             * 
             * {
             *  c最大
             * }
             * }
             */

            Console.ReadKey();
        }
    }
}
