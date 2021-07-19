using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //继承  为了解决代码冗余
            //子类继承了父类的 属性 方法  
            //子类会默认调用父类那个无参数的构造函数
            //单根性 传递性


          //  Student s = new Student();
            //里氏转换
            //1、子类可以赋值给父类
            //2、如果父类装的是子类对象，那么可以讲这个父类强转为子类对象

            Person p = new Student("学生", 11, '男', 90);

            //is as
            if (p is Teacher)
            {
                ((Teacher)p).CHLSS();
                Console.WriteLine("成功");
            }
            else {
                Console.WriteLine("不成功");
            }
            Console.ReadKey();
        }
    }


    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
    public class Student : Person
    {
        public int ID
        {
            get;
            set;
        }

        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
            this.ID = id;
        }
    }
    public class Teacher : Person
    {
        public double Salary
        {
            get;
            set;
        }


        public Teacher(string name, int age, char gender, double salary)
            : base(name, age, gender)
        {
            this.Salary = salary;
        }
    }

}
