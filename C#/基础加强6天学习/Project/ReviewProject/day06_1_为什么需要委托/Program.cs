using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06_1_为什么需要委托
{
    internal class Program
    {
        /// <summary>
        /// 定义一个返回值为string，参数为string的委托（也就是定义了一个方法变量的类型）
        /// </summary>
        /// <param name="strArray"></param>
        /// <returns></returns>
        private delegate string DelStr(string strArray);

        private static void Main(string[] args)
        {
            string[] strArray = new string[] { "daGDHasd", "FESsfa", "dsfaesd" };
            //三个需求：
            //将所有元素转换成大写
            //将所有元素转换成小写
            //将所有元素两边加上一个双引号

            //如果没有委托，那么得写三个类似的方法去执行，如：TestToUp,TestToUp,TestToLower
            //有委托，那么就可以将方法作为参数传递给指定的函数

            //TestToUp(strArray);
            ////匿名函数的写法
            //DealWithStr(strArray, delegate (string item) { return item.ToUpper(); });
            ////lambda表达式写法
            //DealWithStr(strArray, (string item) => { return item.ToUpper(); });

            //TestToLower(strArray);
            ////匿名函数的写法
            //DealWithStr(strArray, delegate (string item) { return item.ToLower(); });
            ////lambda表达式写法，可以不写变量类型的关键字，但是匿名函数不能不写
            DealWithStr(strArray, (item) => { return item.ToLower(); });

            //TestAdd(strArray);
            ////匿名函数的写法
            //DealWithStr(strArray, delegate (string item) { return "\"" + item + "\""; });
            //DealWithStr(strArray, (item) => { return "\"" + item + "\""; });

            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }
            Console.ReadLine();
        }

        private static bool DealWithStr(string[] arrays, DelStr delStr)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = delStr(arrays[i]);
            }
            return true;
        }

        /// <summary>
        ///将数组中所有元素转换为大写
        /// </summary>
        /// <param name="arrays"></param>
        /// <returns></returns>
        private static bool TestToUp(string[] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = arrays[i].ToUpper();
            }
            return true;
        }

        /// <summary>
        /// 将数组中所有元素转换为小写
        /// </summary>
        /// <param name="arrays"></param>
        /// <returns></returns>
        private static bool TestToLower(string[] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = arrays[i].ToLower();
            }
            return true;
        }

        /// <summary>
        /// 将字符传转换为小写
        /// </summary>
        /// <param name="arrays"></param>
        /// <returns></returns>
        private static bool TestAdd(string[] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = "\"" + arrays[i] + "\"";
            }
            return true;
        }
    }
}