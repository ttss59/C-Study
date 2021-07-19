using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "123";
            ////int n = Convert.ToInt32(s);
            //int n = int.Parse(s);
            //Console.WriteLine(n);
            //Console.ReadKey();



            int result;// = 100;
            bool b = int.TryParse("12abc3", out result);
            Console.WriteLine(result);
            Console.WriteLine(b);
            Console.ReadKey();
            //函数  方法   找个人帮你做一件事情  参数 返回值
        }
    }
}
