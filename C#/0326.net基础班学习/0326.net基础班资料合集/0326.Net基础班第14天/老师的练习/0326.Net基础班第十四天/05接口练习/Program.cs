using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //直升飞机 会飞  喷气式战斗机会飞  麻雀会飞  
            //用多态实现

            IFlyable fly = new MQBird();// new PQPlane();//new ZSPlane();
            fly.Fly();
            Console.ReadKey();
        }
    }

    public class ZSPlane:IFlyable
    {

        public void Fly()
        {
            Console.WriteLine("直升飞机可以旋转螺旋桨来飞行");
        }
    }

    public class PQPlane:IFlyable
    {

        public void Fly()
        {
            Console.WriteLine("喷气式飞机可以喷气飞行");
        }
    }

    public class MQBird:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀可以挥动翅膀飞行");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

}
