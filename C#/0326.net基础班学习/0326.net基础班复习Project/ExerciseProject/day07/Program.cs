using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07
{
    internal class Program
    {
        //递归: 方法中自己调用自己，注意要有跳出的条件

        private static int tellCount;

        private static void TellStory()
        {
            tellCount++;
            Console.WriteLine("从前山里有个庙");
            Console.WriteLine("庙里有个老和尚在给小和尚讲故事:");
            if (tellCount >= 5)
                return;//讲了五次就不讲了，跳出递归的条件

            TellStory();
        }

        private static void TestString()
        {
            string s1 = "jjjjj";
            string s2 = s1;
            Console.WriteLine("before : s1 = {0} s2 = {1}", s1, s2);
            s1 = "sssss";
            Console.WriteLine("after : s1 = {0} s2 = {1}", s1, s2);
            Console.ReadKey();
        }

        private static void TestReString()
        {
            Console.WriteLine("请输入字符串");
            string str = Console.ReadLine();
            char[] ca = str.ToCharArray();
            Array.Reverse(ca);
            str = new string(ca);
            Console.WriteLine("str = " + str);
        }

        private static void TestReTwoString()
        {
            Console.WriteLine("请输入两两反转的字符串:");
            string str = Console.ReadLine();
            char[] ca = str.ToCharArray();
            Array.Reverse(ca);
            str = new string(ca);
            Console.WriteLine("str = " + str);
        }

        private static void Main(string[] args)
        {
            //TellStory();
            //TestString();
            //TestReString();
            Console.ReadKey();
        }
    }
}