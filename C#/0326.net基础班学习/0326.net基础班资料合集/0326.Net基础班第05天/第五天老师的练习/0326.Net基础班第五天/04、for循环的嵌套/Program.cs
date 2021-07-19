using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_for循环的嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
          //  int count = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //count++;
                    Console.WriteLine("外面循环了{0}次，里面循环了{1}次",i,j);
                }
            }
            Console.ReadKey();
        }
    }
}
