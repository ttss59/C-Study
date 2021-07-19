using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //姓名、年龄、邮箱、家庭住址,工资
            string name = "卡卡西";
            int age = 10;
            string email = "kakaxi@qq.com";
            string address = "火影村";
            decimal money = 5000m;

            Console.WriteLine("我叫{0},我今年{1}岁了，我的邮箱是{2}，我的地址是{3}，我的工资是{4}", name, age, email, address, money);
            Console.ReadKey();
            //Console.WriteLine("我叫" + name + ",我今年" + age + "岁了" + ",我的邮箱是" + email + ",我的地址是" + address + ",我的工资是" + money);
            //Console.ReadKey();


            //int age = 18;
            //age = 81;
            //Console.WriteLine("老女人，敢骗我,你都已经"+age+"岁了");
            //Console.ReadKey();
        }
    }
}