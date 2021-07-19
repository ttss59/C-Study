using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _03字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //课上练习4：文本文件中存储了多个文章标题、
            //作者，标题和作者之间用若干空格（数量不定）隔开，每行一个，
            //标题有的长有的短，输出到控制台的时候最多标题长度10，如果超过10，
            //则截取长度8的子串并且最后添加“...”，加一个竖线后输出作者的名字。
            //string str=""
            //
            //万历十五年|张居正
            //历史就是这么回事......|袁腾飞
            //坏蛋是怎样炼成的|忘了

            //string[] str = File.ReadAllLines(@"C:\Users\SpringRain\Desktop\1.txt", Encoding.Default);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    string[] strNew = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            //    Console.WriteLine((strNew[0].Length>10?strNew[0].Substring(0,8)+"......":strNew[0])+"|"+strNew[1]);
            //}
            //Console.ReadKey();
            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"
            //string str = "abc";
            //for (int i = str.Length-1; i>=0 ; i--)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //char[] chs = str.ToCharArray();

            //for (int i = 0; i < chs.Length / 2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}

            //str = new string(chs);
            //Console.WriteLine(str);
            //  Console.ReadKey();


            //课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。"hello c sharp"→"sharp c hello"

            //string str = "hello c sharp";   //prahs c olleh    sharp c hello
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = strNew.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(strNew[i]);
            //}
            //Console.ReadKey();



            //课上练习3：从Email中提取出用户名和域名：abc@163.com。

            //string email = "285014478@qq.com";
            //int index = email.IndexOf('@');
            //string userName = email.Substring(0, index);
            //string yuMing = email.Substring(index+1);
            //Console.WriteLine(yuMing);
            //Console.WriteLine(userName);
            //Console.ReadKey();




            //让用户输入一句话,找出所有e的位置
            //   string str = "fdsfsfefsdfesfdsfefsdfesfdsfefdsfe";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'e')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();


            //int index = str.IndexOf('e');//6
            //Console.WriteLine("第一次出现e的位置是{0}", index);
            //int count = 1;
            //while (index != -1)
            //{
            //    index = str.IndexOf('e', index + 1);
            //    count++;
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次出现e的位置是{1}", count, index);
            //}
            //Console.ReadKey();


            //让用户输入一句话,判断这句话中有没有邪恶,如果有邪恶就替换成这种形式然后输出,如:老牛很邪恶,输出后变成老牛很**;

            //Console.WriteLine("请输入一句话");
            //string input = Console.ReadLine();

            //if (input.Contains("邪恶"))
            //{
            //input=     input.Replace("邪恶", "**");
            //}
            //Console.WriteLine(input);
            //Console.ReadKey();



            // 把{“诸葛亮”,”鸟叔”,”卡卡西”,”卡哇伊”}变成诸葛亮|鸟叔|卡卡西|卡哇伊,然后再把|切割掉


            string[] names = { "诸葛亮", "鸟叔", "卡卡西", "卡哇伊" };
            string s = string.Join("|", names);
            Console.WriteLine(s);
            Console.ReadKey();

            //string str = "";
            //for (int i = 0; i < names.Length - 1; i++)
            //{
            //    str += names[i] + "|";
            //}
            //str += names[names.Length - 1];
            //string[] strNew = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);


        }
    }
}
