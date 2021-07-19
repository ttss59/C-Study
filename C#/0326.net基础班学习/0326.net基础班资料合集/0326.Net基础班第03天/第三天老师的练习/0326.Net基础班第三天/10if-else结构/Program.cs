using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10if_else结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //老苏买了一筐鸡蛋，如果坏蛋少于5个，他就吃掉，否则他就去退货
            Console.WriteLine("请输入坏蛋的个数");
            int eggs = Convert.ToInt32(Console.ReadLine());

            if (eggs < 5)
            {
                Console.WriteLine("忍了，吃掉吧");
            }
            else//eggs>=5
            {
                Console.WriteLine("坑爹呀，退货");
            }
            Console.ReadKey();
        }
    }
}
