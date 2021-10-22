using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal class ProductFather
    {
        public ProductType productType
        {
            set;
            get;
        }

        public string name

        {
            set;
            get;
        }

        public string id
        {
            set;
            get;
        }

        public int price
        {
            set;
            get;
        }

        public ProductFather(ProductType productType, string name, string id, int price)
        {
            this.productType = productType;
            this.name = name;
            this.id = id;
            this.price = price;
        }
    }
}