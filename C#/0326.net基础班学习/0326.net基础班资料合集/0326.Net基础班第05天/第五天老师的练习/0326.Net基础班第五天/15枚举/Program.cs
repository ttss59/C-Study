using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15枚举
{
    public enum Gender
    { 
        男,
        女
    }


    public enum Sesons
    { 
        春,
        夏,
        秋,
        冬
    }

    class Program
    {

        static void Main(string[] args)
        {
            //int number=10;
            Gender gender = Gender.女;
            Sesons seson = Sesons.春;
        }
    }
}
