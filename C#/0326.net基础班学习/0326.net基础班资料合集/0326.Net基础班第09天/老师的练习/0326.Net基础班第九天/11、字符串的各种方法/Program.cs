using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你心中想到的那个女神的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你想到的女神的名字的长度是{0}",name.Length);
            //Console.ReadKey();

            //练习二:两个学员输入各自最喜欢的课程名称，判断是否一致,如果相等,
            //则输出你们俩喜欢相同的课程.如果不相同,则输出你们俩喜欢不相同的课程.
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////将一个字符串转换成大写
            ////  lessonOne = lessonOne.ToUpper();
            ////将一个字符串转换成小写
            ////  lessonOne = lessonOne.ToLower();
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            //// lessonTwo = lessonTwo.ToUpper();
            ////  lessonTwo = lessonTwo.ToLower();
            //if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们俩喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你们俩喜欢的课程不相同");
            //}
            //Console.ReadKey();



            //  string str = "1988  --,   -,-    ,  10--  ,--05";
            ////  char[] chs = { ' ', '-', ',' };
            //  string[] strNew = str.Split(new char[]{' ','-',','},StringSplitOptions.RemoveEmptyEntries);
            //  Console.ReadKey();


            //练习：从日期字符串（"2008-08-08"）中分析出年、月、日；2008年08月08日。
            //让用户输入一个日期格式如:2008-01-02,你输出你输入的日期为2008年1月2日
            //string date = "2008-08-08";//2008年08月08日
            //string[] newDate = date.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);


            //date = newDate[0] + "年" + newDate[1] + "月" + newDate[2] + "日";

            //Console.WriteLine(date);
            //Console.ReadKey();


            //string str = "赵剑宇";//***//周华健 郑伊健 保剑锋 赵剑宇
            //str = str.Replace("赵剑宇", "***");
            //Console.WriteLine(str);
            //Console.ReadKey();


            string str = "今天天气好晴朗，处处好风光";
            str = str.Substring(1,2);
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
