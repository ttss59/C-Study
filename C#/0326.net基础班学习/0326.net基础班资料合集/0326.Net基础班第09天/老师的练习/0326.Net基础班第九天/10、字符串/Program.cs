using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //   string str = "";
            //StringBuilder sb = new StringBuilder();
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 1000000; i++)
            //{
            //    sb.Append(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.ReadKey();


            string str = "abcdefg";//bbcdefg
            str = "bbcdefg";
            //我们需要将字符串转换成char类型的数组
            //char[] chs = str.ToCharArray();
            //chs[0] = 'b';
            ////再将char数组转换成字符串
            //str = new string(chs);
            //Console.WriteLine(str);
            ////   str[0] = 'b';
            //// Console.WriteLine(str[0]);
            Console.ReadKey();
        }
    }
}
