using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07超市收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            SupperMarket sm = new SupperMarket();
            //展示货物
            sm.ShowPros();
            //跟用户交互
            sm.AskBuying();
            Console.ReadKey();
        }
    }
}
