using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07超市收银系统
{
    public class ProductFather
    {
        public double Price
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string ID
        {
            get;
            set;
        }

        public ProductFather(string name, string id, double price)
        {
            this.Name = name;
            this.ID = id;
            this.Price = price;
        }
    }
}
