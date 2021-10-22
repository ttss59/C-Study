using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal class CalRate : CalBase
    {
        private double rate;

        public CalRate(double rate)
        {
            this.rate = rate;
        }

        public override double GetMoney(double money)
        {
            return money * rate;
        }
    }
}