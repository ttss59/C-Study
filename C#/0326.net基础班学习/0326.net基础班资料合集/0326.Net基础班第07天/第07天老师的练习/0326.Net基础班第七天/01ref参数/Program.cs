using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //out参数  侧重于让方法返回多个值  必须在方法内赋值
            //ref 参数
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();
        }

        public static void JiangJin(ref double s)
        {
            s += 500;
        }

        public static void FaKuan(double s)
        {
            s -= 500; ;
        }

    }
}
