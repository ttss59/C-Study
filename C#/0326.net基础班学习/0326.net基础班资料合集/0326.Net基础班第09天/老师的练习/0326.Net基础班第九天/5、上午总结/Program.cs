using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_上午总结
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("李四",190,'中');
            person.SayHello();
            Console.ReadKey();
        }
    }
}
