using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_值传递和引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            //int n2 = n1;

            //Person p1 = new Person();
            //p1.Name = "张三";
            //Person p2 = p1;
            //p2.Name = "李四";
            //Console.WriteLine(p1.Name);
            //Console.ReadKey();

            int n1 = 10;
            Test(ref n1);
            Console.WriteLine(n1);
            Console.ReadKey();
        }

        public static void Test(ref int num)
        {
            int n2 = 20;
            num = n2;
        }

    

    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
}
