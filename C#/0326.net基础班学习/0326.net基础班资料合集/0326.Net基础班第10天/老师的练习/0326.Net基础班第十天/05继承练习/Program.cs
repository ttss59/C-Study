using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个Reporter类和一个Programmer类, Driver类,
            //他们都有一个打招呼的方法,
            //不同的是 Reporter 打招呼是说"大家好,我叫XX,我今年XX岁了，我是XX生,我的爱好是XXX",
            //Programmer 的打招呼的方法是说"大家好,我叫XX,我今年XX岁了，我是XX生,我已经工作XX年了"
            //Driver:我叫XX，我今年XX岁了，我是XX生，我的驾龄是XX年


            Reporter r = new Reporter("狗仔", 19, '男', "偷拍");
            Programmer p = new Programmer("程序猿", 22, '男', 3);
            Driver d = new Driver("司机", 19, '女', 2);
            r.ReporterSayHello();
            p.ProgrammerSayHello();
            d.DriverSayHello();
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


        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }

    public class Reporter : Person
    {
        public string Hobby
        {
            get;
            set;
        }
        public Reporter(string name, int age, char gender, string hobby)
            : base(name, age, gender)
        {
            this.Hobby = hobby;
        }

        public void ReporterSayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的爱好是{3}", this.Name, this.Age, this.Gender, this.Hobby);
        }
    }


    public class Programmer : Person
    {
        public int WorkTime
        {
            get;
            set;
        }

        public Programmer(string name, int age, char gender, int worktime)
            : base(name, age, gender)
        {
            this.WorkTime = worktime;
        }


        public void ProgrammerSayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的工作年限是{3}", this.Name, this.Age, this.Gender, this.WorkTime);
        }


    }


    public class Driver : Person
    {
        public int DriveYear
        {
            get;
            set;
        }
        public Driver(string name, int age, char gender, int driveYear)
            : base(name, age, gender)
        {
            this.DriveYear = driveYear;
        }


        public void DriverSayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的驾龄是{3}", this.Name, this.Age, this.Gender, this.DriveYear);
        }
    }
}
