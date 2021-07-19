using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _10File类的操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool b = File.Exists(@"C:\Users\SpringRain\Desktop\1.txt");
            //Console.WriteLine(b);
            //Console.ReadKey();
            //if (!File.Exists(@"C:\Users\SpringRain\Desktop\new.jpg"))
            //{
            //    File.Create(@"C:\Users\SpringRain\Desktop\new.jpg");
            //    Console.WriteLine("创建成功");
            //}
            //else//存在
            //{
            //    Console.WriteLine("该文件已经存在！！！");
            //}

            //File.Delete(@"C:\Users\SpringRain\Desktop\new.txt");
            //File.Delete(@"C:\Users\SpringRain\Desktop\new.jpg");
            //Console.WriteLine("删除成功");
            //Console.ReadKey();
            //File.Copy(@"C:\Users\SpringRain\Desktop\1.txt", @"C:\Users\SpringRain\Desktop\new.txt");
            //Console.WriteLine("复制成功");
            //Console.ReadKey();

            File.Move(@"C:\Users\SpringRain\Desktop\new.txt", @"D:\1.txt");
            Console.WriteLine("剪切成功");
            Console.ReadKey();



        }

    }
}
