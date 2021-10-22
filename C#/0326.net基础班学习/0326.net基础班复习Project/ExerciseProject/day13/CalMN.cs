using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal class CalMN : CalBase
    {
        private double m, n;

        public CalMN(double M, double N)
        {
            m = M;
            n = N;
        }

        public override double GetMoney(double money)
        {
            return money - ((int)(money / m)) * n;
        }
    }
}