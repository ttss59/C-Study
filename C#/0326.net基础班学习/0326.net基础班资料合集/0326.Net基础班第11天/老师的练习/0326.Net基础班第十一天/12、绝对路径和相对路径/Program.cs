using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _12_绝对路径和相对路径
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = File.ReadAllText(@"code.txt",Encoding.Default);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
