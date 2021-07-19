using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07抽象类实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //当一个抽象类实现接口的时候，需要子类去实现接口。
            //Person p = new Person();
            //p.Test();
            //M m = new Person();
            //m.Test();
            //Console.ReadKey();
            //Student s = new Student();
            //s.Test();

            M m = new Student();
            m.Test();
            Console.ReadKey();
        }
    }

    public interface M
    {
        void Test();
    }

    public abstract class Person:M
    {
        public void Test()
        {
            Console.WriteLine("抽象父类实现的接口成员");
        }
    }

    public class Student : Person
    { 
        
    }
}
