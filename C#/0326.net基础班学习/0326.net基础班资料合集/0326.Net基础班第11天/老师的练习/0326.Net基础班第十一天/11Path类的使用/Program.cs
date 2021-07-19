using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _11Path类的使用
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string s1 = @"G:\2014年Net学科班级资料\14年3月26号基础班\0326.Net基础班视频\0326.Net基础班第十天\资料\1.txt";
            //获得文件的名称
            Console.WriteLine(Path.GetFileName(s1));
            //获得文件的名称但是不包含扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(s1));
            //获得文件的扩展名
            Console.WriteLine(Path.GetExtension(s1));
            //获得文件所在的文件夹的路径
            Console.WriteLine(Path.GetDirectoryName(s1));
            //获得文件的绝对路径
            Console.WriteLine(Path.GetFullPath(s1));
            //拼接路径
            Console.WriteLine(Path.Combine(@"C:\a\","b.txt"));
            Console.WriteLine(Path.ChangeExtension(@"C:\Users\SpringRain\Desktop\code.txt",".jpg"));
            Console.ReadKey();

        }
    }
}
