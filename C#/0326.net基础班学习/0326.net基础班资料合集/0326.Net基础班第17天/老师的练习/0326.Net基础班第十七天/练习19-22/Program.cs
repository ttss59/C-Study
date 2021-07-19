using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习19_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "患者：“大夫，我咳嗽得咳 咳 咳 很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            //int index = str.IndexOf("咳嗽");//11 12
            //Console.WriteLine("第1次出现咳嗽的位置是{0}", index);
            //int i = 1;
            //while (index != -1)
            //{
            //    index = str.IndexOf("咳嗽",index+1);
            //    i++;
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次出现咳嗽的的位置是{1}",i,index);
            //}
            //Console.ReadKey();

            //将字符串"  hello      world,你  好 世界   !    "两端空格去掉，并且将其中的所有其他空格都替换成一个空格，输出结果为："hello world,你 好 世界 !"。


            //string str = "  hello      world,你  好 世界   !    ";
            ////去掉两端空格
            //str = str.Trim();
            ////Console.Write(str);
            ////   Console.ReadKey();
            ////把剩下的空格替换成一个空格
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //str = string.Join(" ", strNew);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //用来存储学生的姓名
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("请输入学生的姓名");
                string str = Console.ReadLine();//姓名 quit QUIT QuiT
                if (str.ToLower() != "quit")
                {
                    list.Add(str);
                }
                else
                {
                    break;
                }
            }
            int count=0;
            Console.WriteLine("您输入的学员的个数是{0}",list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                if (list[i][0] == '王')
                {
                    count++;
                }
            }
            Console.WriteLine("姓王的同学的个数是{0}",count);
            Console.ReadKey();

        }
    }
}
