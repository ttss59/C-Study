using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    public class Person//public internal
    {
        //成员
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


        public void SayHello()
        {
            Console.WriteLine("{0}---{1}--{2}",this.Name,this.Age,this.Gender);
        }

        /// <summary>
        /// 初始化对象
        /// </summary>
        public Person(char gender)
        {
            if (gender != '男' && gender != '女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }

        public Person()
        { 
            
        }

        public static void Test()
        {
            Console.WriteLine("我是静态方法");
        }

    }
}
