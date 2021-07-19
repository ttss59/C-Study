using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP继承
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Student
             * 姓名  性别 年龄 学号  吃喝拉撒睡 学习
             * Teacher
             * 姓名 性别  年龄 工资 吃喝拉撒睡 讲课
             * Driver
             * 姓名 性别 年龄 驾龄 吃喝拉撒睡 开车
             * 
             * 姓名 性别 年龄 吃喝拉撒睡 Person
             * 
             */

            Student s = new Student();
            

        }
    }

    public class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public void CHLSS()
        {
            Console.WriteLine("人类可以吃喝拉撒睡");
        }

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        //public Person()
        //{ 
            
        //}
     
    }


    public class Teacher : Person
    {

        public Teacher(string name, int age, char gender, double salary):base(name,age,gender)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
            this.Salary = salary;
        }


        double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public void Teach()
        {
            Console.WriteLine("老师讲课");
        }
    }


    public class Student : Person
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Student(string name, int age, char gender, int id):base(name,age,gender)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
            this.Id = id;
        }

        public void Study()
        {
            Console.WriteLine("学生会学习");
        }
    }


    public class Driver : Person
    {

        public Driver(string name, int age, char gender, int driveTime)
            : base(name, age, gender)
        {
            this.DriveTime = driveTime;
        }


        int _driveTime;
        public int DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }

        public void Drive()
        {
            Console.WriteLine("司机会开车");
        }
    }

}
