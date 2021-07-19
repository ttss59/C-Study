using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06new的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SayHello();
            Student s = new Student();
            
        }
    }

    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }


    public class Student:Person
    {
        public new void SayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

    public class Teacher : Person
    {
        public new void SayHello()
        {
            Console.WriteLine("我是老师");
        }
    }

    public class Test : Person
    {
        public new void SayHello()
        { 
            
        }
    }
}
