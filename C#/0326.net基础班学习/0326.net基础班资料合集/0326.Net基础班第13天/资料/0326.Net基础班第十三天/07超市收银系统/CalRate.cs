using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07超市收银系统
{
    public class CalRate:CalFather
    {
        public double Rate
        {
            get;
            set;
        }

        public CalRate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetMoney(double totalMoney)
        {
            return totalMoney * this.Rate;
        }
    }
}
