using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //封装、继承、多态
            Student s = new Student("学生", 11, '男', 19);
            Programmer p = new Programmer();

            Person pp = new Person("人类");
           
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

        public Person(string name)
        {
            this.Name = name;
        }
        private double _height;


        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //public Person()
        //{ 

        //}

        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }

    }

    public class Student : Person
    {
        public int ID
        {
            get;
            set;
        }
        public void Study()
        {
            Console.WriteLine("会学习");
        }


        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {

            this.ID = id;
        }

    }



    public class Programmer:Student
    { 
        
    }

    public class Teacher : Person
    {
        public Teacher(string name, int age, char gender, double salary)
            : base(name, age, gender)
        {
            this.Salary = salary;
        }


        public double Salary
        {
            get;
            set;
        }
        public void Teach()
        {
            Console.WriteLine("讲课");
        }
    }



    public class Driver:Person
    {

        public Driver(string name, int age, char gender, int driveTime)
            : base(name, age, gender)
        {
            this.DriveTime = driveTime;
        }

        public int DriveTime
        {
            get;
            set;
        }
    }



}
