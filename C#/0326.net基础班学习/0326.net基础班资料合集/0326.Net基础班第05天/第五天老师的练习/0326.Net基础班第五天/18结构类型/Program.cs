using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18结构类型
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
            //首先声明一个结构类型的变量
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 19;
            zsPerson._gender = Gender.男;
            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 20;
            lsPerson._gender = Gender.女;

            ////大学管理系统 姓名 性别 年龄
            //string name1 = "张三";
            //char gender1 = '男';
            //int age1 = 15;
        }
    }
}
