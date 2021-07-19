using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _10操作文件夹
{
    class Program
    {
        static void Main(string[] args)
        {

            //创建文件夹
            //Directory.CreateDirectory(@"C:\a");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();
            //for (int i = 0; i < 100; i++)
            //{
            //    Directory.CreateDirectory(@"C:\a\" + i);
            //}
            //Console.WriteLine("成功");
            //Console.ReadKey();


            //删除文件夹
            //Directory.Delete(@"C:\a",true);
            //Console.WriteLine("删除成功");
            //Console.ReadKey();


            //剪切文件夹
            //Directory.Move(@"C:\a\b", @"C:\d");
            //Console.WriteLine("剪切成功");
            //Console.ReadKey();

            //string[] path = Directory.GetFiles(@"G:\2014年Net学科班级资料\14年3月26号基础班\0326.Net基础班视频\0326.Net基础班第十天\资料","*.txt");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    int index = path[i].LastIndexOf('\\');
            //    string newPath = path[i].Substring(index + 1);
            //    Console.WriteLine(newPath);
            //}

            //string[] path = Directory.GetDirectories(@"G:\2014年Net学科班级资料\14年3月26号基础班\0326.Net基础班视频");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();
        }
    }
}
