﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_属性的作用
{
    public class Person
    {
       private  string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
         char _gender;
         public char Gender
         {
             get {
                 if (_gender != '男' && _gender != '女')
                 {
                     return _gender = '男';
                 }
                     return _gender;
                 
             }
             set { _gender = value; }
         }
         int _age;
         public int Age
         {
             get { return _age; }
             set {
                 if (value < 0 || value > 100)
                 {
                     value = 0;
                 }
                 
                 _age = value; }
         }
        public void SayHello()
        {
            Console.WriteLine("{0}---{1}--{2}",this.Name,this.Age,this.Gender);
        }
    }
}
