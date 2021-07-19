using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01面向对象
{
    public class Person
    {
        public string _name;
        public int _age;
        public char _gender;

        public void SayHello()
        {
            Console.WriteLine("大家好，我是{0},我今年{1}岁了，我是{2}生",this._name,this._age,this._gender);
        }


        //public void Test()
        //{
        //    string _name = "网吧吧";
        //    Console.WriteLine(this._name);
        //}

    }
}
