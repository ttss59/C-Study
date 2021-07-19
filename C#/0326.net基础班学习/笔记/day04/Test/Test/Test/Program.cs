using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = 18;
            int sum = num++ - 10;
            Console.WriteLine("num++=" + num + " sum++=" + sum);
            Console.ReadKey();
            Test01();
        }

        private static void Test01()
        {
            int num = 18;
            int sum = ++num - 10;
            Console.WriteLine("++num=" + num + " ++sum=" + sum);
            Console.ReadKey();
        }
    }
}