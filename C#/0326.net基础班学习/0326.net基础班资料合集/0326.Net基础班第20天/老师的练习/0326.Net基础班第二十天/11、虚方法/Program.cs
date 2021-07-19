using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //虚方法：
            //1、父类需要被实例化
            //2、父类中的方法有实际意义
            RealDuck rd = new XPDuck();//new MuDuck();//new RealDuck();
            rd.Bark();
            Console.ReadKey();


        }
    }

    public class RealDuck
    {
        public virtual  void Bark()
        {
            //Console.WriteLine("真的鸭子嘎嘎叫");
        }
    }

    public class MuDuck : RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("木头鸭子吱吱叫");
        }
    }

    public class XPDuck : RealDuck
    {
        public  void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }
}
