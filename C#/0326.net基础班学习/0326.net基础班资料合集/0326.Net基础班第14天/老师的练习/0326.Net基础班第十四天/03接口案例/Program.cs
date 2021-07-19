using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03接口案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //鸵鸟 鹦鹉 麻雀  企鹅
            IFlyable fly = new MQBird();//new YWBird();
            fly.Fly();
            Console.ReadKey();
        }
    }


    public interface IFlyable
    {
        void Fly();
    }

    public class Bird
    {
        public void Drink()
        {
            Console.WriteLine("鸟都可以喝水");
        }

        public void Eat()
        {
            Console.WriteLine("鸟都可以吃饭");
        }
    }
    public class TuoBird : Bird
    { 
    
    }

    public class YWBird : Bird,IFlyable
    {

        //public void Fly()
        //{
        //    Console.WriteLine("鹦鹉在飞");
        //}
        void IFlyable.Fly()
        {
            throw new NotImplementedException();
        }
    }

    public class MQBird : Bird,IFlyable
    {

        public void Fly()
        {
            Console.WriteLine("麻雀在飞");
        }
    }

    public class QQBird : Bird
    { 
        
    }



















    public class Person
    {
        public void Fly()
        {
            Console.WriteLine("可以飞");
        }

        public void KouLan()
        {
            Console.WriteLine("扣篮的方法");
        }
    }

    public class Student : Person
    { 
        
    }

    //public interface IFlyable
    //{
    //    void Fly();
    //}


    public interface IKouLanable
    {
        void KouLan();
    }
}
