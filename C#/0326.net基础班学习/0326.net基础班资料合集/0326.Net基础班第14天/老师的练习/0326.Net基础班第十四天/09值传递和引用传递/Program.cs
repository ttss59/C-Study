using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09值传递和引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型：int double decimal char bool struct enum  valueType--->object
            //引用类型：string 数组 集合 自定义类 object 接口  object

            //值传递：值类型在赋值的时候 传递的是值得本身
            //引用类型：引用类型在赋值的时候 传递的是引用 (地址)

            //int n = 10;
            ////int n2 = n;
            ////n2 = 20;
            ////Console.WriteLine(n);
            ////Console.WriteLine(n2);
            //Test(n);
            //Console.WriteLine(n);
            //Console.ReadKey();

            Person p1 = new Person();
            p1.Name = "张三";
            Test(p1);
            Console.WriteLine(p1.Name);
            Console.ReadKey();


        }


        public static void Test(Person p)
        {
            Person pp = p;
            pp.Name = "李四";
        }



        //public static void Test(int n1)
        //{
        //    n1 += 5;
        //}
    }


    public class Person
    {
        public string Name
        {
            get;
            set;
        }
    }

}
