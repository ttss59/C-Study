using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_抽象类
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //虚方法、抽象类、接口

            //编程实现:猫和狗都会叫,但猫是喵喵的叫,狗是汪汪的叫?—猪

            // Animal a = new Animal();

            Animal a = new Dog();//new Cat();
            a.Bark("123");
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        //存在的意义就是让子类去重写
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

        public Animal(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Animal()
        {
        }

        public abstract string Bark(string name);

        // public abstract void Test();
        //public void Bark()
        //{
        //}
        //public void Bark()
        //{
        //    Console.WriteLine("动物会叫");
        //}
    }

    //public abstract class Bird:Animal
    //{
    //}

    public class Cat : Animal
    {
        public override string Bark(string name)
        {
            Console.WriteLine("猫咪喵喵的叫");
            return name;
        }
    }

    public class Dog : Animal
    {
        public override string Bark(string name)
        {
            Console.WriteLine("狗会旺旺的叫");
            return name;
        }
    }
}