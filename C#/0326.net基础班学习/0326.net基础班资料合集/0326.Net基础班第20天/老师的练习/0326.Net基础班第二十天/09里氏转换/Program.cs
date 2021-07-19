using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student();
            // is as
            //if (person is Teacher)
            //{
            //    Console.WriteLine("成功");
            //}
            //else
            //{
            //    Console.WriteLine("失败");
            //}

          //  Student s = person as Student;
            Teacher s = person as Teacher;
            if (s != null)
            {
                Console.WriteLine("成功");
            }
            else
            {
                Console.WriteLine("失败");
            }
            Console.ReadKey();
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
