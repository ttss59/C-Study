using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15自动动手写TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            // int.TryParse()
            int result = 100;
            bool b = MyTryParse("123abc", out result);
            Console.WriteLine(b);
            Console.WriteLine(result);
            Console.ReadKey();
            //无--有   总结
            //有--很多
        }



        /// <summary>
        /// 将字符串转换成int类型
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <param name="result">转换成功后的整数</param>
        /// <returns></returns>
        public static bool MyTryParse(string s, out int result)
        {
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }
    }
}
