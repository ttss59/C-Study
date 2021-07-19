using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05字符串复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "123";
            //string s2 = "123";


            //字符串---》字符数组
            //string s = "abcde";
            //s[2] = 'a';
            //Console.WriteLine(s[2]);
            //Console.ReadKey();
            //字符数组---》字符串



            //=============字符串和字符数组之间的转换===========================
            //string s = "abcdefg";
            //char[] chs = s.ToCharArray();

            //s = new string(chs);

            //=====================判断是否为空或者为null======================
            //string s = null;//"";
            //if (string.IsNullOrEmpty(s))
            //{
            //    Console.WriteLine("空");
            //}
            //else 
            //{
            //    Console.WriteLine("不空");
            //}
            //Console.ReadKey();

            //===========================Equals========================
            //string s1 = "abc";
            //string s2 = "aBC";
            //if (s1.Equals(s2,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("相同");
            //}
            //else 
            //{
            //    Console.WriteLine("不同");
            //}
            //Console.ReadKey();
            //Person p=new Person();
            //Console.WriteLine(p.ToString());
            //int[] n = new int[100];
            //Console.WriteLine(n.ToString());
            //Console.ReadKey();


            //Person p1 = new Person();

            //Person p2 = new Person();

            //p1.Name = "张三";
            //p2.Name = "张三";
            //p1.Age = 19;
            //p2.Age = 32;
            ////Console.WriteLine(p1.Name);
            ////Console.WriteLine(p2.Name);
            //if (p1.Equals(p2))
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //{
            //    Console.WriteLine("不同");
            //}
            //Console.ReadKey();


            //string s = "我爱北京爱天安门";
            //int index = s.LastIndexOf("老");
            //Console.WriteLine(index);
            //Console.ReadKey();



            //string s = "abcdefg";
            //s = s.Substring(1,4);
            //Console.WriteLine(s);
            //Console.ReadKey();


            //int index = s.IndexOf('爱',5);
            //Console.WriteLine(index);
            //Console.ReadKey();


            //string s = "a   ,   -- b";
            //string[] newS = s.Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);



            //string[] names = { "张三", "李四", "王五", "赵六" };
            ////张三|李四|王五|赵六
            //string s = string.Join("|",1,3.14,true,'c',5000m,"张三");
            //Console.WriteLine(s);
            //Console.ReadKey();


            //Console.WriteLine(string.Format("{0:C3}",2));
            //Console.WriteLine("{0}--{1}",1,2);
            //Console.WriteLine(string.Format("{0}--{1}",1,2));
            //Console.ReadKey();

            string s = "1-----------2---------3-----------4--";
            //1-2-3-4
            string[] strNew = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            s = string.Join("-", strNew);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }


    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
        public void Test()
        {

        }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (this.Name == p.Name && this.Age == p.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "哈哈哈哈";
        }
    }
}
