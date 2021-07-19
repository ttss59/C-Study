using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01委托
{
    public delegate string DelProStr(string str);
    class Program
    {
        static void Main(string[] args)
        {

            //1、把一个字符串中所有的字符都转换成大写
            //2、把一个字符串中所有的字符都转换成小写
            //3、把一个字符串中所有的字符两边都加上一个双引号
            //string s = ProSYH("abCDefdsfd");
            //Console.WriteLine(s);
            //Console.ReadKey();

            //我们创建委托对象去指向一个方法
            //DelProStr del = StrToSYH;
            //string s = ProcessStr("abDEfdfdEFD", StrToSYH);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //使用匿名函数
            //DelProStr del = delegate(string str)
            //{
            //    return str.ToUpper();
            //};
            //不明觉厉
            DelProStr del = (str) => { return str.ToUpper(); };
            //lamda表达式 本质上就是匿名函数  函数
            string s = del("abCDefg");
            Console.WriteLine(s);
            Console.ReadKey();

        }


        /// <summary>
        /// 转换成大写、小写或者加双引号
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ProcessStr(string str, DelProStr del)
        {
            string strNew = null;
            char[] chs = str.ToCharArray();
            for (int i = 0; i < chs.Length; i++)
            {
                strNew += del(chs[i].ToString()); //chs[i].ToString().ToUpper();
            }
            return strNew;
        }

        public static string StrToUpper(string str)
        {
            return str.ToUpper();
        }

        public static string StrToLower(string str)
        {
            return str.ToLower();
        }

        public static string StrToSYH(string str)
        {
            return "\"" + str + "\"";
        }

        /// <summary>
        /// 转换成小写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>

        //public static string ProToLower(string str)
        //{
        //    string strNew = null;
        //    char[] chs = str.ToCharArray();
        //    for (int i = 0; i < chs.Length; i++)
        //    {
        //        strNew += chs[i].ToString().ToLower();
        //    }
        //    return strNew;
        //}
        ///// <summary>
        ///// 加双引号
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //public static string ProSYH(string str)
        //{
        //    string strNew = null;
        //    char[] chs = str.ToCharArray();
        //    for (int i = 0; i < chs.Length; i++)
        //    {
        //        strNew += "\"" + chs[i] + "\"";
        //    }
        //    return strNew;
        //}

















        //public static void Change(Test)
        //{
        //    Console.WriteLine();
        //}

        public static void Test()
        {

        }
    }
}
