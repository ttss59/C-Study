using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //什么时候使用接口？
            IFlyable fly = new YingWu();//new MaQue();
            fly.Fly();
            Console.ReadKey();
        }
    }

    interface IFlyable
    {
        void Fly();
    }


    public class Bird
    {
        public int Wings
        {
            get;
            set;
        }
    }


    public class YingWu : Bird,IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉会飞");
        }
        //显示实现接口的方法
        void IFlyable.Fly()
        {
            Console.WriteLine("接口中的飞方法");
        }
    }

    public class QQ : Bird
    { 
    
    }

    public class TuoNiao : Bird
    { 
    
    }

    public class MaQue : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }
    }
}
