using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07超市收银系统
{
    public class CalNormal:CalFather
    {
        public override double GetMoney(double totalMoney)
        {
            return totalMoney;
        }
    }
}
