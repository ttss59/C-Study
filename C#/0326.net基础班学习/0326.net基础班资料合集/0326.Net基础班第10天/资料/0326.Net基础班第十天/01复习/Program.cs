using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //类 成员
            Person person = new Person('中');
            person.Name = "李四";
            person.Age = -10;
            person.SayHello();
            Person.Test();
            Console.ReadKey();
        }
    }
}
