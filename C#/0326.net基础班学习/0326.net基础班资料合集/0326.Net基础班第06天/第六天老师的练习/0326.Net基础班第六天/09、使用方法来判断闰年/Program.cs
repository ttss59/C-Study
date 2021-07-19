using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_使用方法来判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，判断你给的年份是否是闰年 true false bool类型
            //需要给一个年份作为参数
            Console.WriteLine("请输入一个年份");
            int year = Convert.ToInt32(Console.ReadLine());
            bool b = IsRun(year);
            Console.WriteLine(b);
            Console.ReadKey();
        }



        /// <summary>
        /// 判断给定的年份是否是闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool IsRun(int year)
        {
            //if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0) ? true : false;
        }

    }
}
