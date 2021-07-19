using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串可以看做是char类型的只读数组
            //string s = "abcdef";


            ////s.ToUpper();
            ////s.ToLower();
            //bool b = s.Equals("ABcdeF", StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine(b);
            //Console.ReadKey();

            //char[] chs = s.ToCharArray();


            //s = new string(chs);

            //================Split====================================
            //string s = "a -- )d  fdf , --";
            //string[] sNew = s.Split(new char[] { '-', ' ', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);

            //================Substring====================================
            //string s = "今天天气好晴朗，处处好风光";
            //string sNew = s.Substring(1, 2);
            //Console.WriteLine(sNew);
            //Console.ReadKey();

            //字符串的不可变性

            //================Contains====================================
            //string s = "今天天气好晴朗，处处好风光";
            //if (s.Contains("天好"))
            //{
            //    Console.WriteLine("包含");
            //}
            //else
            //{
            //    Console.WriteLine("不包含");
            //}
            //Console.ReadKey();



            //================EndsWith====================================
            //string s = "今天天气好晴朗，处处好风光";
            //if (s.EndsWith("今天天气好晴朗，处处好风光"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            // Console.ReadKey();

            //=====================IndexOf获得某个字符或者字符串在字符串中第一次出现的位置===========
            //string s = "s";
            //int index = s.IndexOf('天');
            //Console.WriteLine(index);
            //Console.ReadKey();



            //string s = "今天天气好晴朗，处处好风光";
            //int index = s.LastIndexOf('处');
            //Console.WriteLine(index);
            //Console.ReadKey();

            //=======================LastIndexOf===============
            //string path = @"C:\Windows\AppCompat\Programs\DevInvCache\苍老苍师.wmv";
            //int index = path.LastIndexOf('\\');
            //string s = path.Substring(index+1);
            //Console.WriteLine(s);
            //Console.ReadKey();



            string str = "        abc           ";
            //str = str.Trim();
            //str = str.TrimStart();
            str = str.TrimEnd();
            Console.Write(str);
            Console.ReadKey();



        }
    }
}
