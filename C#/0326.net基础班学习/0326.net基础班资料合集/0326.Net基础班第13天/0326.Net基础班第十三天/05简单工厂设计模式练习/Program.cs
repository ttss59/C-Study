using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05简单工厂设计模式练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1--不打折  2--打N折   3--买M元减N元
            Console.WriteLine("请输入你要选择的打折方式");
            Console.WriteLine("1--不打折  2--打95折 3打85折  4买300减50 5买500送100");
            string input = Console.ReadLine();
            Console.WriteLine("您打折应付500元");
            DZFather dz = GetDZ(input);
            double realMoney = dz.GetMoney(500);
            Console.WriteLine("打折后应付{0}元",realMoney);
            Console.ReadKey();
        }

        public static DZFather GetDZ(string input)
        {
            DZFather dz = null;
            switch (input)
            {
                case "1": dz = new NormalDZ();
                    break;
                case "2": dz = new RateDZ(0.95);
                    break;
                case "3": dz = new RateDZ(0.85);
                    break;
                case "4": dz = new MNDZ(300, 50);
                    break;
                case "5": dz = new MNDZ(500, 100);
                    break;
            }
            return dz;
        }
    }

    public abstract class DZFather
    {
        public abstract double GetMoney(double totalMoeny);
    }
    public class NormalDZ : DZFather
    {

        /// <summary>
        /// 打折前多少钱 打折后就多少钱
        /// </summary>
        /// <param name="totalMoeny">打折前应付的价钱</param>
        /// <returns>打折后应付的价钱</returns>
        public override double GetMoney(double totalMoeny)
        {
            return totalMoeny;
        }
    }
    public class RateDZ : DZFather
    {
        public double Rate
        {
            get;
            set;
        }

        /// <summary>
        /// 传入折扣率
        /// </summary>
        /// <param name="rate">要打的折扣</param>
        public RateDZ(double rate)
        {
            this.Rate = rate;
        }
        public override double GetMoney(double totalMoeny)
        {
            return totalMoeny * this.Rate;
        }
    }
    public class MNDZ : DZFather
    {
        public double M
        {
            get;
            set;
        }

        public double N
        {
            get;
            set;
        }

        public MNDZ(double m, double n)
        {
            this.M = m;
            this.N = n;
        }

        //500 100 1300  2.6   260
        public override double GetMoney(double totalMoeny)
        {
            if (totalMoeny > this.M)
            {
                return totalMoeny - ((int)(totalMoeny / this.M)) * this.N;
            }
            else
            {
                return totalMoeny;
            }
        }
    }
}
