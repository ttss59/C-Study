using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多播委托
{
    public delegate void DelTest();
    class Program
    {
        static void Main(string[] args)
        {
            DelTest del = Test1;
            //多播委托：一个委托执行N个方法
            del += Test2;
            del += Test3;
            del = Test4;
            del();
            //事件
            Console.ReadKey();
        }

        public static void Test1()
        {
            Console.WriteLine("我是方法1");
        }

        public static void Test2()
        {
            Console.WriteLine("我是方法2");
        }

        public static void Test3()
        {
            Console.WriteLine("我是方法3");
        }


        public static void Test4()
        {
            Console.WriteLine("我是方法4");
        }
    }
}
