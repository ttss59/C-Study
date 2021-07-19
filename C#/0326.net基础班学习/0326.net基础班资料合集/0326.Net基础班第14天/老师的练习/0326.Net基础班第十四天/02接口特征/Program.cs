using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02接口特征
{
    class Program
    {
        static void Main(string[] args)
        {
         //接口一般表示一种规范 同时也表示一种能力，继承了这个接口，也就有了这个能力
            //所以在给接口起名字的时候 一般都以I开头，以able结尾
        
        }
    }

    public class Person:IFlyable
    {

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    public interface IFlyable
    {
        // string _name;
         void Fly();
        // void Drink();
    }


    public interface M1
    {
        void Test1();
    }

    public interface M2
    {
        void Test2();
    }
    public interface M3
    {
        void Test3();
    }

    public interface M4 : M1, M2, M3
    { 
        
    }

    public class Student : Person,M4
    {

        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            throw new NotImplementedException();
        }
    }
}
