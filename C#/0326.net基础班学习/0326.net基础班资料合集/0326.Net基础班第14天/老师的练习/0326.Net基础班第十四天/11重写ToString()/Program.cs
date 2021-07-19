using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11重写ToString__
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //Console.WriteLine(p.ToString());
            //int[] n = new int[10];
            //Console.WriteLine(n.ToString());

            //int nn = 10;
            //Console.WriteLine(nn.ToString());

            //List<int> list = new List<int>();
            //Console.WriteLine(list.ToString());
            //Console.ReadKey();
            Person p = new Person();
            Person pp = new Person();
            p.Age = 190;
            pp.Age = 20;
            bool b = p.Equals(pp);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
    public class Person
    {

        public int Age
        {
            get;
            set;
        }
        public override bool Equals(object obj)
        {
            Person pp = (Person)obj;
            if (this.Age > pp.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return "Hello World";
        }
    }


}
