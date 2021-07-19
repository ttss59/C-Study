using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "5 4 3 2 1 ";// 1 5 4 3 2
            str = str.Substring(str.Length - 2)+str.Substring(0,str.Length-2);
            Console.Write(str);
            Console.ReadKey();
        }
    }
}
