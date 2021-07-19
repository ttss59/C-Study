using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
           //C#中的访问修饰符
            Person p = new Person();
            //p.gen
        }
    }

    public class Person
    {
        private string _name;
        protected int _age;
        internal char _gender;
    }

    public class Student : Person
    {
        public void Test()
        { 
            
        }
    }

    
}
