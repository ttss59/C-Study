using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07超市收银系统
{
    public class CalMN : CalFather
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

        public CalMN(double m, double n)
        {
            this.M = m;
            this.N = n;
        }




        public override double GetMoney(double totalMoney)
        {
            if (totalMoney > this.M)
            {
                return totalMoney - ((int)(totalMoney / this.M)) * this.N;
            }
            else
            {
                return totalMoney;
            }
        }
    }
}
