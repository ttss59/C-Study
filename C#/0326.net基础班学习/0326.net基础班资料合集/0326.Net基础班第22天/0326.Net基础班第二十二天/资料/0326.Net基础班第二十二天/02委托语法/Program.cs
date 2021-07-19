using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02委托语法
{
    public delegate void DelSayHello(string name);
    class Program
    {
        static void Main(string[] args)
        {
           
            //声明的委托必须跟指向的方法具有同样的签名

            //调用委托
            //首先创建委托对象
         //   DelSayHello del = JapaneseSayHello;//new DelSayHello(JapaneseSayHello);
         //   //Test()
         ////   del("张三");

         //   Test("张三", JapaneseSayHello);
         //   Console.ReadKey();

            ChineseSayHello("张三");
            Console.ReadKey();
        }

        public static void Test(string name,DelSayHello del)
        {
            del(name);
        }


        public static void ChineseSayHello(string name)
        {
            Console.WriteLine("你好:"+name);
        }


        public static void JapaneseSayHello(string name)
        {
            Console.WriteLine("o ha yo"+name);
        }


    }
}
