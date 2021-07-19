using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {

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

    public class Student : Person
    {

    }
}
