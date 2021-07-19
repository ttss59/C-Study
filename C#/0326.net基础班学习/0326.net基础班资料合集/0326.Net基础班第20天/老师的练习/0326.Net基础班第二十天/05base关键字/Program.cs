using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05base关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Test();
            Console.ReadKey();
           
        }
    }

    public class Person
    {
        public void Test()
        {
            Console.WriteLine("我是父类");
        }
    }

    public class Student:Person
    {
        public  void Test()
        {
            base.Test();
            Console.WriteLine("我是子类");
        }
    }
}
