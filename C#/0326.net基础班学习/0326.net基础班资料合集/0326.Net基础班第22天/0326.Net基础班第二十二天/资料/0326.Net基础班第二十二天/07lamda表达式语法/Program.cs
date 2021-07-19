using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07lamda表达式语法
{
    public delegate void DelTest1();
    public delegate void DelTest2(string s);
    public delegate string DelTest3(string s);
    class Program
    {
        static void Main(string[] args)
        {
        //    DelTest1 del = () => { };
        //    DelTest2 del2 = (string s) => { };
        //    DelTest3 del3 = (string s) => { return s; };

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            list.RemoveAll(n=>n>2);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();

        }
    }
}
