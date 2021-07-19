using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ref
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref就是将一个值传递变成引用传递
            int n = 10;
            Test(ref n);
            Console.WriteLine(n);
            Console.ReadKey();
        }

        public static void Test(ref int nn)
        {
            nn += 10;
        }
    }
}
