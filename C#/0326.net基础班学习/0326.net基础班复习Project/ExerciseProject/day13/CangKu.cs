using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    public enum ProductType
    {
        Iphone,
        TeaEgg,
        Computer,
        Cammer
    }

    internal class CangKu
    {
        private Dictionary<string, ProductType> productManifist = new Dictionary<string, ProductType>();
        private Dictionary<ProductType, Dictionary<string, List<ProductFather>>> productsJia = new Dictionary<ProductType, Dictionary<string, List<ProductFather>>>();

        public void ShowProducts()
        {
            foreach (var gui in productsJia.Values)
            {
                foreach (var pro in gui)
                {
                    if (pro.Value.Count > 0)
                        Console.WriteLine("商品名称:{0}\t商品价格:{1}\t商品数量:{2}", pro.Value[0].name, pro.Value[0].price, pro.Value.Count);
                }
            }
        }

        public int GetProductsCount()
        {
            int result = 0;
            foreach (var gui in productsJia.Values)
            {
                foreach (var pro in gui)
                {
                    if (pro.Value.Count > 0)
                        result += pro.Value.Count;
                }
            }
            return result;
        }

        /// <summary>
        /// 根据货物名称导出货物
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public ProductFather[] ExportProducts(string productName, int count)
        {
            if (!productManifist.ContainsKey(productName))
            {
                Console.WriteLine("仓库中没有货架存放{0}", productName);
                return null;
            }

            ProductType productType = productManifist[productName];
            if (!productsJia[productType].ContainsKey(productName))
            {
                Console.WriteLine("仓库的{0}货架中没有存放{1}的货柜", productType, productName);
                return null;
            }

            if (productsJia[productType][productName].Count < count)
            {
                Console.WriteLine("仓库中{0}只有{1}个", productName, count);
                return null;
            }

            ProductFather[] productFathers = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                productFathers[i] = productsJia[productType][productName][0];
                productsJia[productType][productName].RemoveAt(0);
            }
            return productFathers;
        }

        /// <summary>
        /// 导入货物
        /// </summary>
        /// <param name="productType"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="count"></param>
        public void ImportProducts(ProductType productType, string name, int price, int count)
        {
            //将货物根据名字匹配对应的类型
            if (!productManifist.ContainsKey(name))
                productManifist.Add(name, productType);

            //生成要导入的货物
            List<ProductFather> products = new List<ProductFather>();
            for (int i = 0; i < count; i++)
            {
                products.Add(new ProductFather(productType, name, Guid.NewGuid().ToString(), price));
            }

            //如果仓库中没有此类货物的货架
            if (!productsJia.ContainsKey(productType))
            {
                //根据货物名字分类存放的货柜
                Dictionary<string, List<ProductFather>> productsGui = new Dictionary<string, List<ProductFather>>();
                productsGui.Add(name, products);
                productsJia.Add(productType, productsGui);
            }
            else
            {
                //将新进的货物根据名称放到对应货柜中
                if (!productsJia[productType].ContainsKey(name))
                    productsJia[productType].Add(name, products);
                else
                    productsJia[productType][name].AddRange(products);
            }
        }
    }
}