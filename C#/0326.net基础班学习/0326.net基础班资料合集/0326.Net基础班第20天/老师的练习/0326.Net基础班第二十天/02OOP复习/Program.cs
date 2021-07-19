﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OOP复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个类的对象
            Person p1 = new Person("李四",190,'春');
            Person p2 = new Person(11, '中');
            p2.SayHello();
            Console.ReadKey();
        }
    }

    public class Person
    { 
        //字段、属性、方法、构造函数
        string _name;

        public string Name
        {
            get { return _name; }
            set {
                if (value != "张三")
                {
                    value = "张三";
                }
                _name = value; }
        }



        int _age;

        public int Age
        {
            get {
                if (_age < 0 || _age > 100)
                {
                    return _age = 0;
                }
                return _age; }
            set { _age = value; }
        }


        char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            if (gender != '男' && gender != '女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }

        public Person(string name):this(name,0,'\0')
        {
           // this.Name = name;  
        }

        public Person(int age, char gender):this(null,age,gender)
        {
            //this.Age = age;
            //this.Gender = gender;
        }


        public void SayHello()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了，我是{2}生",this.Name,this.Age,this.Gender);
        }
    }
}
