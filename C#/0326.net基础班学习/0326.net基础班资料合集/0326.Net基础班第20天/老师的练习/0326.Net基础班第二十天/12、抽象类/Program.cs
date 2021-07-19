using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、父类不需要创建对象
            //2、不知道父类中的方法如何去实现

            Animal a = new Cat();// new Dog();
            a.Bark();
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public string Name
        {
            get;
            set;
        }


        public Animal()
        {

        }

        public Animal(string name)
        {
            this.Name = name;
        }
        public abstract void Bark();
    }

    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗狗旺旺的叫");
        }
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵的叫");
        }
    }


}
