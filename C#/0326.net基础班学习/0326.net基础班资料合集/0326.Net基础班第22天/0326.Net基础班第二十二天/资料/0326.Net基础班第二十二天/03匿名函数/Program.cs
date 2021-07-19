using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03匿名函数
{
    public delegate string DelTest(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //DelTest del = Test;
            //string s = del("张三");
            //Console.WriteLine(s);
            //Console.ReadKey();

            DelTest del = delegate(string name) {
                return name;
            };

            string s = del("张三");
            Console.WriteLine(s);
            Console.ReadKey();
        }

        //public static string Test(string name)
        //{
        //    return name;
        //}
    }
}
