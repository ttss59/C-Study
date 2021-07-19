using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_属性的作用
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person();
            zsPerson.Name = "张三";
            zsPerson.Age = -10;
            zsPerson.Gender = '中';
            //zsPerson._name = "张三";
            //zsPerson._age = -10;
            //zsPerson._gender = '中';
            zsPerson.SayHello();
            Console.ReadKey();
        }
    }
}
