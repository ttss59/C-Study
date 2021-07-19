using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_调用者和被调用者的关系
{
    class Program
    {
        public static int _a = 3;//用来模拟全局变量
        static void Main(string[] args)
        {
            int a = 3;
            int aNew = Test(a);//实参
            Console.WriteLine(aNew);
            Console.ReadKey();
        }

        public static int Test(int a)//形参
        {
            a = a + 5;
            return a;
        }
        public static void TestTwo()
        {

        }

        public static void TestThree()
        {

        }
    }
}
