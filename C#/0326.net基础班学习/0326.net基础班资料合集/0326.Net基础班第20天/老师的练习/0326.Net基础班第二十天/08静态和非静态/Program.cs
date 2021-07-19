using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08静态和非静态
{
    class Program
    {
        //private static string _name;
        //private int _age;
        static void Main(string[] args)
        {
            // Person p = new Person();
            Person p = new Person();
            Person p2 = new Person();
            Person p3 = new Person();
            Console.ReadKey();
        }

        void Test()
        {

        }
    }


    public class Person
    {
        //public Person(string name)
        //{
        //    this.Name = name;
        //}

        public Person()
        { 
            
        }
        static Person()
        {
          //  Person.Age = age;
        }
        private string _name="张三";

      

        private static int _age=20;

    
        public void Test1()
        {
            Console.WriteLine("我是非静态的");
        }

        public static void Test2()
        {
            Console.WriteLine("我是静态的");
        }
    }


    public static class Student
    {

    }
}
