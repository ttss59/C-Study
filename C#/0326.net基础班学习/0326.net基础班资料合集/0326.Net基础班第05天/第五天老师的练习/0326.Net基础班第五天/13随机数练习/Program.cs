using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13随机数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入名字随机显示这个人上辈是什么样的人
            Random r = new Random();
            while (true)
            {
                int rNumber = r.Next(1, 7);
                Console.WriteLine("请输入姓名，我们将显示这个人上辈子的职业");
                string name = Console.ReadLine();
                switch (rNumber)
                {
                    case 1: Console.WriteLine("{0}上辈子是太监",name);
                        break;
                    case 2: Console.WriteLine("{0}上辈子是拉皮条的",name);
                        break;
                    case 3: Console.WriteLine("{0}上辈子是孙中山转世",name);
                        break;
                    case 4: Console.WriteLine("{0}上辈子是拉大粪的，最后被熏屎了",name);
                        break;
                    case 5: Console.WriteLine("{0}上辈子是抽大烟的",name);
                        break;
                    case 6: Console.WriteLine("{0}上辈子是折翼的狗屎",name);
                        break;
                }
                Console.ReadKey();
            }
           
        }
    }
}
