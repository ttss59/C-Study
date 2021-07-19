using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_静态和非静态的区别
{
    public class Person
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        static int _age;

        public static int Age
        {
            get { return Person._age; }
            set { Person._age = value; }
        }
        public void M1()
        { 
           
        }

        public static void M2()
        { 
           
        }
    }
}
