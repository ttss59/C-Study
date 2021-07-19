using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //张三 男 18  三科成绩为:90 95 80
            //Student zsStudent = new Student();
            Student s = new Student("张三",180,'男');
            s.SayHello();
            Console.ReadKey();
            //zsStudent.SayHello();
            //zsStudent.GetScore();            //小兰 女 16  三科成绩为:95 85 100
            //Student xlStudent = new Student();
            //xlStudent.Name = "小兰";
            //xlStudent.Age = 19;
            //xlStudent.Gender = '中';
            //xlStudent.Chinese = 100;
            //xlStudent.English = 100;
            //xlStudent.Math = 100;
            //xlStudent.GetScore();
            //xlStudent.SayHello();
            Console.ReadKey();
        }
    }
}
