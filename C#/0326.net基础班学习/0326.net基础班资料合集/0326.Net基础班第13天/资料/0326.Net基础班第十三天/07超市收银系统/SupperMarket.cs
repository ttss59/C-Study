using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07超市收银系统
{
    public class SupperMarket
    {
        CangKu ck = new CangKu();
        public SupperMarket()
        {
            ck.DaoRuPros("Iphone100", 1000);
            ck.DaoRuPros("BananaCamera", 1000);
            ck.DaoRuPros("Acer", 1000);
            ck.DaoRuPros("TeaEggs", 1000);
        }

        public void AskBuying()
        {
            Console.WriteLine("aniasaiyo,您需要些什么？");
            Console.WriteLine("我们这有 Iphone100 、BananaCamera、Acer、TeaEggs");
            string strType = Console.ReadLine();
            Console.WriteLine("你要多少个？");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货物
            ProductFather[] pros = ck.DaoChuPros(strType, count);
            //算钱
            double totalMoney = GetMoney(pros);
            Console.WriteLine("您本次消费合计{0}元", totalMoney);
            Console.WriteLine("请选择打折方式 1、不打折 2、打95折  3、打85折、4、买300送50 5、买500送100");
            string input = Console.ReadLine();
            CalFather cf = GetCal(input);
            double realMoney = cf.GetMoney(totalMoney);
            Console.WriteLine("打完折后，你总计应付{0}元", realMoney);
            //打印小票
            foreach (ProductFather item in pros)
            {
                Console.Write("商品名称：" + item.Name + "\t" + "商品编号:" + item.ID + "\t" + "商品价格:" + item.Price + "\r\n");
            }
        }

        public void ShowPros()
        {
            string str = ck.ShowPros();
            Console.WriteLine(str);
        }


        /// <summary>
        /// 简单工厂设计模式 根据用户的输入 返回一个打折对象
        /// </summary>
        /// <param name="input">用户的输入</param>
        /// <returns>返回打折对象</returns>
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1": cal = new CalNormal();
                    break;
                case "2": cal = new CalRate(0.95);
                    break;
                case "3": cal = new CalRate(0.85);
                    break;
                case "4": cal = new CalMN(300, 50);
                    break;
                case "5": cal = new CalMN(500, 100);
                    break;
            }
            return cal;
        }

        /// <summary>
        /// 计算打折前应付多少钱
        /// </summary>
        /// <param name="pros">买的货物</param>
        /// <returns>总价钱</returns>
        public double GetMoney(ProductFather[] pros)
        {
            double sum = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                sum += pros[i].Price;
            }
            return sum;
        }

    }
}
