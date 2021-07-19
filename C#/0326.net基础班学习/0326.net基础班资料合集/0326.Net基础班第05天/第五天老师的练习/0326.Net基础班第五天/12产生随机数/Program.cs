using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12产生随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            //随机数 没有规律的数字
            //产生随机数：
            //1、创建一个能够产生随机数的对象 
            while (true)
            {
                Random r = new Random();

                int rNumber = r.Next(1, 10);

                Console.WriteLine(rNumber);
                Console.ReadKey();
            }
           
        }
    }
}
