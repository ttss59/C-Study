using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal class SuperMarket
    {
        private CangKu cangKu = new CangKu();

        public SuperMarket()
        {
            cangKu.ImportProducts(ProductType.Iphone, "苹果13", 6, 10000);
            cangKu.ImportProducts(ProductType.Cammer, "小米相机", 8, 1000);
            cangKu.ImportProducts(ProductType.Computer, "联想笔记本", 9, 100);
            cangKu.ImportProducts(ProductType.Iphone, "王者茶叶蛋", 10, 100);
        }

        public void AsynBuying()
        {
            Console.WriteLine("欢迎光临国际的大超市，超市还有如下商品:");
            cangKu.ShowProducts();
            Console.WriteLine("请问需要点什么:");
            string proName = Console.ReadLine();
            Console.WriteLine("请问需要多少个：");
            int proCount = int.Parse(Console.ReadLine());
            ProductFather[] pros = cangKu.ExportProducts(proName, proCount);
            double normalSum = GetNormalMoney(pros);
            Console.WriteLine("{0}个{1}一共需要{2}元", proCount, proName, normalSum);
            double saleSum;
            string saleType = GetSaleType(normalSum, out saleSum);
            Console.WriteLine("由于您一共消费{0}元，采用最优惠的方案({1})计算后，您仅需支付{2}元", normalSum, saleType, saleSum);
        }

        public bool IsSellOver()
        {
            bool result = false;
            if (cangKu.GetProductsCount() <= 0)
                result = true;
            return result;
        }

        private string GetSaleType(double money, out double result)
        {
            result = new CalMN(1000, 88).GetMoney(money);
            if (result > new CalRate(0.95).GetMoney(money))
            {
                result = new CalRate(0.95).GetMoney(money);
                return "原价95折优惠";
            }
            else
            {
                return "原价满300减88";
            }
        }

        public double GetNormalMoney(ProductFather[] pros)
        {
            double sum = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                sum += pros[i].price;
            }
            return sum;
        }
    }
}