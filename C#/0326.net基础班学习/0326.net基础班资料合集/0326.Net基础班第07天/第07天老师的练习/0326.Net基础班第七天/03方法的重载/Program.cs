using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine()
           // M()
        }


        public static void M(int n1, int n2)
        {
            int sum = n1 + n2;
        }

        //public static int M(int n1, int n2)
        //{ 
            
        //}
        public static double M(int n1, double n2)
        {
            return n1 + n2;
        }
        public static string M(string s1, string s2)
        {
            return s1 + s2;
        }
        public static void M(int n1, int n2, int n3)
        {
            int sum = n1 + n2 + n3;
        }


    }
}
