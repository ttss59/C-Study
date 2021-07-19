using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_判断年份
{
    class Program
    {
        static void Main(string[] args)
        {
            //  //请用户输年份,再输入月份,输出该月的天数.(结合之前如何判断闰年来做)
            Console.WriteLine("请输入一个年份");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入一个月份");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {
                        int day = 0;//存储天数
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12: day = 31;
                                break;
                            case 2:
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default: day = 30;
                                break;
                        }//swich
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }//if
                    else
                    {
                        Console.WriteLine("月份必须在1~12月之间，程序退出！！！");
                    }
                }//try月份
                catch//catch月份
                {
                    Console.WriteLine("月份输入有误，程序退出");
                }
            }//try年份的
            catch//年份的catch
            {
                Console.WriteLine("年份输入有误，程序退出");
            }
            Console.ReadKey();

        }
    }
}
