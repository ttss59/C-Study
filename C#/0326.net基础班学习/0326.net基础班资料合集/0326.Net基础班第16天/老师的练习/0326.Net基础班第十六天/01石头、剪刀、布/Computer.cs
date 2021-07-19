using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01石头_剪刀_布
{
    public class Computer
    {
        Random r = new Random();
        public string Fist
        {
            get;
            set;
        }

        public int ShowFist()
        {
            int rNumber = r.Next(0, 3);
            switch (rNumber)
            {
                case 0: this.Fist = "石头";
                    break;
                case 1: this.Fist = "剪刀";
                    break;
                case 2: this.Fist = "布";
                    break;
            }
            return rNumber;
        }
    }
}
