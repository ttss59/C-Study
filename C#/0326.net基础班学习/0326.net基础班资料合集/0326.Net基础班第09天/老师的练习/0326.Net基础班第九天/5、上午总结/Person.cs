using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_上午总结
{
    public class Person
    {
        //字段、属性、方法、构造函数
        //字段：存储数据
        //属性：保护字段
        //方法：行为
        //构造函数:初始化对象(给对象的每个属性依次的赋值)

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

        public Person()
        { 
            
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生",this.Name,this.Age,this.Gender);
        }

    }
}
