using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20随机数的时间种子
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                    
                int rNumber = r.Next(1, 100);
                Console.WriteLine(rNumber);
            }
            Console.ReadKey();
        }
    }
}
