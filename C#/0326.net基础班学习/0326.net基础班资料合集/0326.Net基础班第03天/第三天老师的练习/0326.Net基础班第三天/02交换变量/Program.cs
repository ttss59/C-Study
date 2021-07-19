using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02交换变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;

            //int temp = n1;
            //n1 = n2;
            //n2 = temp;


            n1 = n1 - n2;   //n1=-10 n2=20 
            n2 = n1 + n2;//n1=-10 n2=10;
            n1 = n2 - n1;
            Console.WriteLine("交换后，n1的值是{0},n2的值是{1}", n1, n2);
            Console.ReadKey();

            //交换两个类型的变量  但是不能声明第三方变量
        }
    }
}
