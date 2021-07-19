using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool b;
            string s = Test(out n, out b);
            Console.WriteLine(s);
            Console.WriteLine(n);
            Console.WriteLine(b);
            Console.ReadKey();
        }

        public static string Test(out int number, out bool b)//我想再返回一个int类型的100
        {
            number = 100;
            b = false;
            return "张三";
        }
    }
}
