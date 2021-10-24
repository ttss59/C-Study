using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01接口
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //虚方法 抽象类 接口
            //为什么会有接口
            //Student s = new Student();
            //s.KouLan();
            //s.Fly();
            //Console.ReadKey();

            //NBAPlayer nba = new NBAPlayer();//接口无法new成对象
            NBAPlayer nba = new Teacher();//new Student();
            nba.KouLan();//这个方法被子类实现了

            SuperMan sm = new Teacher();//new Student();
            sm.Fly();
            Console.ReadKey();
        }
    }

    public class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("人类可以吃喝拉撒睡");
        }
    }

    public class Student : Person, NBAPlayer, SuperMan
    {
        public void KouLan()
        {
            Console.WriteLine("学生可以扣篮啦");
        }

        public void Fly()
        {
            Console.WriteLine("学生可以飞啦");
        }
    }

    public class Teacher : NBAPlayer, SuperMan
    {
        public void KouLan()
        {
            Console.WriteLine("老师可以扣篮啦");
        }

        public void Fly()
        {
            Console.WriteLine("老师可以飞啦");
        }
    }

    public interface NBAPlayer
    {
        void KouLan();
    }

    public interface SuperMan
    {
        void Fly();
    }

    //public class NBAPlayer
    //{
    //    public void KouLan()
    //    {
    //        Console.WriteLine("NBA球员可以扣篮");
    //    }
    //}

    //public class SuperMan
    //{
    //    public void Fly()
    //    {
    //        Console.WriteLine("我是超人我会飞");
    //    }
    //}
}