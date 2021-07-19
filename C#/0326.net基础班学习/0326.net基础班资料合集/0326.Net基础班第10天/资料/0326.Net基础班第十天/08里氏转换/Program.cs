using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)、子类对象可以赋值给父类。（如果有一个地方需要一个父类作为参数，我们可以给一个子类代替）
            //Student s = new Student();
            //Person p = s;
            //2)、如果这个父类中装的是子类对象，那么可以将这个父类强转为对应的子类对象
            Person p = new Student();
            Teacher t = p as Teacher;
            Student s = p as Student;
            Console.ReadKey();
            //if (p is Student)
            //{
            //    Student s = (Student)p;
            //    Console.WriteLine("成功");
            //}
            //else
            //{
            //    Console.WriteLine("不能转换!!!");
            //}
            //Console.ReadKey();

            //string s = string.Join("|", new int[] { 1, 2, 3, 4, 5 });
            //string s = string.Join("|", new bool[] { false, true, false, true });

            //string s = string.Join("|", 1, 3.14, true, 'c', "张三");
            //Console.WriteLine(s);
            //Console.ReadKey();
        }
    }

    public class Person
    {

    }


    public class Student : Person
    {

    }

    public class Teacher : Person
    {

    }
}
