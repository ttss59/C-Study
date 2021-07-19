using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08接口问题
{
    class Program
    {
        static void Main(string[] args)
        {
            M1 m = new Student();//new Person();
            m.M1();
            Console.ReadKey();
        }
    }

    public class Person:M1
    {
        public void M1()
        {
            Console.WriteLine("实现接口");
        }
    }

    public class Student : Person
    { 
        
    }

    public interface M1
    {
        void M1();
    }
}
