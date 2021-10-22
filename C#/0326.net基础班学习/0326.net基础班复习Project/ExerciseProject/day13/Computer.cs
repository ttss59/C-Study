using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal class Computer : ProductFather
    {
        public Computer(ProductType productType, string name, string id, int price) : base(productType, name, id, price)
        {
        }
    }
}