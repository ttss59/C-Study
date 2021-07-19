using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ref参数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //交换两个int类型的变量
            int n1 = 10;
            int n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;



            //n1 = n1 - n2;
            //n2 = n1 + n2;
            //n1 = n2 - n1;
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            // Change(out n1, out n2);

            Change(ref n1, ref  n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();
        }

        public static void Change(ref  int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
