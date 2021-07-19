using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            //索引器：方便去实用类中的集合
            Person p = new Person();
            p[0] = 1;
            p[1] = 2;
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
            Console.ReadKey();
        }
    }
    public class Person
    {
        int[] nums = new int[100];
        public int this[int index]
        {
            get { return nums[index]; }
            set { nums[index] = value; }
        }
    }
}
