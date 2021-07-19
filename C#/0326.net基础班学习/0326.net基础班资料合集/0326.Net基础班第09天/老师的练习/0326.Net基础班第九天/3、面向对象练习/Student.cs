using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_面向对象练习
{
    public class Student
    {
        string _name;//private 私有的
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set
            { _age = value; }
        }

        char _gender;

        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }


        double _chinese;

        public double Chinese
        {
            get { return _chinese; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 50;
                }
                _chinese = value;
            }
        }

        double _math;

        public double Math
        {
            get { return _math; }
            set { _math = value; }
        }

        double _english;

        public double English
        {
            get { return _english; }
            set { _english = value; }
        }


        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我是{1}生，我今年{2}岁了", this.Name, this.Gender, this.Age);
        }


        public void GetScore()
        {
            Console.WriteLine("我叫{0}，我的总成绩是{1}，平均成绩是{2}", this.Name, this.Chinese + this.Math + this.English, (this.Chinese + this.Math + this.English) / 3);
        }



        //public Student(string name, int age, char gender, double chinese, double math, double english)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //    this.Gender = gender;
        //    this.Chinese = chinese;
        //    this.Math = math;
        //    this.English = english;
        //}


        public Student(string name, int age, char gender)
        {
            this.Name = name;
            if (age < 0 || age > 100)
            {
                age = 0;
            }
            this.Age = age;
            this.Gender = gender;
        }

        public Student()
        {
            Console.WriteLine("我是新的构造函数");
        }




    }
}
