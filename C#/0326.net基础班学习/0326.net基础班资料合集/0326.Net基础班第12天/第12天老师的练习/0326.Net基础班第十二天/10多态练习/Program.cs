using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子嘎嘎叫 木头鸭子吱吱叫 橡皮鸭子唧唧叫 用多态来实现 一个鸭子能够模拟多个鸭子去叫

            //RealDuck rd = new RealDuck();
            //rd.Bark();
            //MuDuck md = new MuDuck();
            //md.Bark();
            //XPDuck xd = new XPDuck();
            //xd.Bark();
            //Console.ReadKey();
            //MuDuck md = new MuDuck();
            //XPDuck xd = new XPDuck();
            //RealDuck rd = new RealDuck();
            //RealDuck[] rds = { md, xd, rd };
            //for (int i = 0; i < rds.Length; i++)
            //{
            //    rds[i].Bark();
            //}
            //Console.ReadKey();

            //RealDuck rd = new XPDuck();//new MuDuck();//new RealDuck();
            //rd.Bark();
            //Console.ReadKey();


            //员工早上九点打卡  经理十一点打卡  程序猿不打卡
            Employee emp = new Programmer();//new Manager();
            emp.DaKa();
            
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工九点打卡");
        }
    }

    public class Manager : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }

    public class Programmer : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序猿不打卡");
        }
    }



    public class RealDuck
    {
        public virtual void Bark()
        {
            Console.WriteLine("真的鸭子嘎嘎叫");
        }
    }


    public class MuDuck:RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("木头鸭子吱吱叫");
        }
    }


    public class XPDuck:RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }

}
