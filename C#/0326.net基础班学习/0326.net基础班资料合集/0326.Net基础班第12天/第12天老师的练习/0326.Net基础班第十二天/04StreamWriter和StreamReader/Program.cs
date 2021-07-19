using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04StreamWriter和StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            //使用StreamReader来读取数据
            //using (StreamReader sr = new StreamReader(@"C:\Users\SpringRain\Desktop\抽象类特点.txt",Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string str = sr.ReadLine();
            //        Console.WriteLine(str);
            //    }
            //}
            //Console.ReadKey();


            //使用StreamWriter来写入数据
            using (StreamWriter sw = new StreamWriter(@"C:\Users\SpringRain\Desktop\ooo.txt",true))
            {
                sw.Write("lalalaala");
            }
            Console.WriteLine("写入成功");
            Console.ReadKey();
        }
    }
}
