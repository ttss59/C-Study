using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06lamda表达式
{
    public delegate string DelTest(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //lamda表达式 --->匿名函数--->函数
            //DelTest del = Test;
            //string s = del("张三");
            //Console.WriteLine(s);
            //Console.ReadKey();


            //DelTest del = delegate(string name) { return name; };
            //string s = del("张三");
            //Console.WriteLine(s);
            //Console.ReadKey();

            //不明觉厉
            DelTest del = (string name) => { return name; };
            string s= del("张三");
            Console.WriteLine(s);
            Console.ReadKey();


        }

        //public static string Test(string name)
        //{
        //    return name;
        //}
    }
}
