using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的递归  在方法内部自己调用自己
            //找一个文件夹下所有的文件
            TellStory();
            Console.ReadKey();
        }
        public static int i = 0;
        public static void TellStory()
        {
            i++;
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有个庙");
            Console.WriteLine("庙里有个小和尚和老和尚");
            Console.WriteLine("有一天，小和尚哭了，老和尚给小和尚讲了一个故事");
            if (i >= 5)
            {
                return;
            }
            TellStory();
        }
    }
}
