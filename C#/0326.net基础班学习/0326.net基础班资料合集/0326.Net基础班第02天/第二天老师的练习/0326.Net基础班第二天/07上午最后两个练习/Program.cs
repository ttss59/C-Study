using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07上午最后两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //2081234   010-89765432  13301264071
            string tel = "13301264071";
            string name = "张三";
            int age = 19;
            char gender = '男';
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的电话是{3}", name, age, gender, tel);
            Console.ReadKey();
        }
    }
}
