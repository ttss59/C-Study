using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06字符串的4个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba“.
            //string str = "abc";//cba
            ////将str转换成字符数组
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length / 2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}


            ////将改变后的字符数组转换成字符串
            //str = new string(chs);
            //Console.WriteLine(str);
            ////for (int i = str.Length-1; i >= 0; i--)
            ////{
            ////    Console.WriteLine(str[i]);
            ////}
            ////Console.WriteLine(str);
            //Console.ReadKey();



            ////课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。      “I love you"→“I evol uoy"
            //string str = "I love you";
            ////获得这个字符串中的每一个单词
            //string str3 = null;
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    string str2 = ReverseString(strNew[i]);
            //    str3 += str2 + "\t";
            //}
            //Console.WriteLine(str3);
            //Console.ReadKey();
            //把每一个单词转换成字符数组

            //翻转每一个字符数组

            //将字符串转换成字符串
            //课上练习3：”2012年12月21日”从日期字符串中把年月日分别取出来，打印到控制台
            //string str = "2012年12月21日";

            //string[] date = str.Split(new char[] { '年', '月', '日' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}--{1}--{2}",date[0],date[1],date[2]);
            //Console.ReadKey();



            //姓名：张三  电话：15001111113
            string res=null;
            string[] str = File.ReadAllLines(@"C:\Users\SpringRain\Desktop\tel.txt", Encoding.Default);
            for (int i = 0; i < str.Length; i++)
            {
                string[] strNew = str[i].Split(new char[] { ',', ';', '\"' }, StringSplitOptions.RemoveEmptyEntries);

                res+="姓名：" + strNew[0] + strNew[1] + "\t" + "电话:" + strNew[2]+"\r\n";

               

            }
            File.WriteAllText(@"C:\Users\SpringRain\Desktop\new.txt", res);
            Console.WriteLine("写入成功");
            Console.ReadKey();
        }


        public static string ReverseString(string str)
        {
            char[] chs = str.ToCharArray();
            for (int i = 0; i < chs.Length / 2; i++)
            {
                char temp = chs[i];
                chs[i] = chs[chs.Length - 1 - i];
                chs[chs.Length - 1 - i] = temp;
            }
            str = new string(chs);
            return str;
        }
    }
}
