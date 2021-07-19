using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现107653秒是几天几小时几分钟几秒?
            /*
             60*60*24=86400   86461
              
             */

            ////练习,编程实现计算几天(如46天)是几周零几 天.
            //Console.WriteLine("请输入要计算的天数");
            ////string strDays = Console.ReadLine();
            //int day = Convert.ToInt32(Console.ReadLine());
            //int week = day / 7;//求得星期数
            //day = day % 7;//零的那几天
            //Console.WriteLine("46天是{0}周零{1}天",week,day);
            //Console.ReadKey();

            //练习:编程实现107653秒是几天几小时几分钟几秒?
            Console.WriteLine("请输入要计算的秒数");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int day = seconds / 86400;//求得天数
            int secs = seconds % 86400;//求得剩余的秒数
            int hours = secs / 3600;//求得剩余的小时数
            secs = secs % 3600;//求完小时数后剩余的秒数
            int mins = secs / 60;//求得分钟数
            secs = secs % 60;//求完分钟后剩余的秒数

            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, day, hours, mins, secs);
            Console.ReadKey();
        }
    }
}
