using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _01ProcessToOpenFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            ////    item.Kill();
            //    Console.WriteLine(item);
            //}


            //Start打开的是应用程序
            //Process.Start("notepad");
            //Process.Start("calc");

            //我现在要通过Process打开我指定的文件
            //ProcessStartInfo psi=new ProcessStartInfo(@"D:\1.txt");
            //Process.Start(psi);
            //Process p = new Process();
            //p.StartInfo=psi;
            //p.Start();
            //Console.ReadKey();


            Console.WriteLine("请输入要进入的磁盘");
            string filePath = Console.ReadLine();
            Console.WriteLine("请输入要打开的文件");
            string fileName = Console.ReadLine();
            //获得用户输入的文件的后缀名
            string extension = Path.GetExtension(fileName);

            CommonFile cf = GetFile(extension, fileName);
            cf.OpenFile(filePath);
            Console.ReadKey();
        }

        public static CommonFile GetFile(string extension, string fileName)
        {
            CommonFile cf = null;
            switch (extension)
            {
                case ".txt": cf = new TxtFile(fileName);
                    break;
                case ".avi": cf = new AviFile(fileName);
                    break;
            }



            return cf;
        }
    }


    /// <summary>
    /// 文件类型的父类
    /// </summary>
    public abstract class CommonFile
    {
        public string FileName
        {
            get;
            set;
        }
        /// <summary>
        /// 打开文件的方法
        /// </summary>
        public abstract void OpenFile(string filePath);
    }


    public class TxtFile : CommonFile
    {
        //创建txt对象的时候  将要打开的txt文件名传递给构造函数
        public TxtFile(string fileName)
        {
            this.FileName = fileName;
        }
        /// <summary>
        /// 打开文本文件
        /// </summary>
        /// <param name="filePath"></param>
        public override void OpenFile(string filePath)
        {
            ProcessStartInfo psi = new ProcessStartInfo(filePath + "\\" + this.FileName);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }


    }



    public class AviFile : CommonFile
    {
        public AviFile(string fileName)
        {
            this.FileName = fileName;
        }

        public override void OpenFile(string filePath)
        {
            ProcessStartInfo psi = new ProcessStartInfo(filePath + "\\" + this.FileName);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }



}
