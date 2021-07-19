using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08接收用户的输入
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("美女，你喜欢吃啥子水果哟~~~~");
            ////将用户输入的内容存到一个字符串变量中
            //string fruit = Console.ReadLine();
            //Console.WriteLine("哈哈，那么巧呀，我也喜欢吃{0}",fruit);
            //Console.ReadKey();

            //2.练习:请用户输入姓名性别年龄,当用户按下某个键子后在屏幕上显示
            //：您好:XX您的年龄是XX是个X生
            Console.WriteLine("请输入您的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的年龄");
            string age = Console.ReadLine();
            Console.WriteLine("请输入性别");
            string gender = Console.ReadLine();

            Console.WriteLine("{0}你的年龄是{1}是个{2}生", name, age, gender);
            Console.ReadKey();
        }
    }
}
