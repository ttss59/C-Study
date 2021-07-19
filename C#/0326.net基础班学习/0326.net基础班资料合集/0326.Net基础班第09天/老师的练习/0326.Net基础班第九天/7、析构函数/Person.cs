using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_析构函数
{
    class Person
    {
        ~Person()
        {
            Console.WriteLine("我是析构函数，你看我什么时候被调用");
        }
    }
}
