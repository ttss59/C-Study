using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IEatable eat = new MQBird();
            eat.Eat();
            Console.ReadKey();
        }
    }

    public class MQBird:IEatable
    {
        public void Eat()
        {
            Console.WriteLine("麻雀会吃");
        }

        void IEatable.Eat()
        {
            Console.WriteLine("接口中的吃");
        }
    }

    public class QQBird:IEatable
    {
        public void Eat()
        {
            Console.WriteLine("企鹅也会吃");
        }

        void IEatable.Eat()
        {
            Console.WriteLine("接口中的吃方法");
        }
    }



    public interface IEatable
    {
        void Eat();
       // void Fly();
    }


}
