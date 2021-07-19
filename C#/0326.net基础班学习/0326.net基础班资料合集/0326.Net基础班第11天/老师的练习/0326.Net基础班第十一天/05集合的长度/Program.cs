using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05集合的长度
{
    class Program
    {
        static void Main(string[] args)
        {
            //Count Capcity
            //Count:集合中实际包含的元素个数
            ArrayList list = new ArrayList();
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();
        }
    }
}
