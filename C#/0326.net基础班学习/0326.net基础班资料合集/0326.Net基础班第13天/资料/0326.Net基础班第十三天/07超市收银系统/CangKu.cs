using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07超市收银系统
{
    public class CangKu
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        //list[0]这个货架存储Iphone100手机
        //list[1]这个货架存储BananaCamera
        //list[2]这个货架存储Acer
        //list[3]这个货架存储TeaEggs
        public CangKu()
        {
            //在构造函数当中  给仓库导入货架
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }


        //展示货物
        public string ShowPros()
        {
            string str = null;
            foreach (var item in list)
            {
                str += "商品名称：" + item[0].Name + "\t" + "商品价格：" + item[0].Price + "\t" + "商品数量：" + item.Count+"\r\n";
            }
            return str;
        }



        /// <summary>
        /// 给仓库导入货物
        /// </summary>
        /// <param name="strType">要导入的货物的类型</param>
        /// <param name="count">要导入的货物的数量</param>
        public void DaoRuPros(string strType, int count)//100个茶叶蛋
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Iphone100": list[0].Add(new Iphone100("苹果100", Guid.NewGuid().ToString(), 5000));
                        break;
                    case "BananaCamera": list[1].Add(new BananaCamera("香蕉照相机", Guid.NewGuid().ToString(), 2000));
                        break;
                    case "Acer": list[2].Add(new Acer("鸿基笔记本", Guid.NewGuid().ToString(), 200));
                        break;
                    case "TeaEggs": list[3].Add(new TeaEggs("茶叶蛋", Guid.NewGuid().ToString(), 1000000));
                        break;
                }
            }
        }


        /// <summary>
        /// 从仓库中向外导出货物
        /// </summary>
        /// <param name="strType">导出货物的类型</param>
        /// <param name="count">导出货物的个数</param>
        /// <returns>返回一个商品父类数组</returns>
        public ProductFather[] DaoChuPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    //每次都拿货架的第一个
                    case "Iphone100": pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "BananaCamera": pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "Acer": pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "TeaEggs": pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }





        //.......
    }
}
