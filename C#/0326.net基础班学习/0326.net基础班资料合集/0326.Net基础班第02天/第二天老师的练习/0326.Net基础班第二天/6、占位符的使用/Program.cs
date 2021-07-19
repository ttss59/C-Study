using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_占位符的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 10;
            int numberTwo = 20;
            int numberThree = 30;
            Console.WriteLine("第一个值是{0}，第二个值是{1}，第三个值是{2}",numberThree,numberOne,numberTwo);
          //  Console.WriteLine("第一个值是" + numberOne + ",第二个值是" + numberTwo + ",第三个值是" + numberThree);
            Console.ReadKey();
        }
    }
}
