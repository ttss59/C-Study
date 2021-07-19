using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08if
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现:如果跪键盘的时间大于60分钟,那么媳妇奖励我晚饭不用做了.
            Console.WriteLine("请输入你跪键盘的时间");
            int mins = Convert.ToInt32(Console.ReadLine());
            bool b= mins > 60;
            if (b)
            {
                Console.WriteLine("你不用做晚饭啦！！！好老公，去吃屎吧");
            }
            Console.ReadKey();
        }
    }
}
