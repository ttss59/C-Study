using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19结构练习
{
    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    public enum Gender
    { 
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 18;
            zsPerson._gender = Gender.男;
            Person xlPerson;
            xlPerson._name = "小兰";
            xlPerson._age = 16;
            xlPerson._gender = Gender.女;
        }
    }
}
