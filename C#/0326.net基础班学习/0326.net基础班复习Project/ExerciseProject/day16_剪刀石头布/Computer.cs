using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16_剪刀石头布
{
    internal class Computer
    {
        private static Computer _computer;
        private static readonly object lockObj = new object();

        private Computer()
        {
        }

        public static Computer GetInstance()
        {
            if (_computer == null)
            {
                lock (lockObj)
                {
                    if (_computer == null)
                    {
                        _computer = new Computer();
                    }
                }
            }
            return _computer;
        }

        public string fistRsult;

        public int ShowFist()
        {
            Random random = new Random();
            int result = random.Next(0, 3);
            switch (result)
            {
                case 0:
                    fistRsult = "石头";
                    break;

                case 1:
                    fistRsult = "剪刀";
                    break;

                case 2:
                    fistRsult = "布";
                    break;

                default:
                    fistRsult = "石头";
                    break;
            }
            return result;
        }
    }
}