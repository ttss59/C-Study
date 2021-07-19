using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _03使用FileStream读写大文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\SpringRain\Desktop\2、FileStream的读写文件.wmv";
            string target = @"D:\new.wmv";
            CopyFile(source, target);
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }

        public static void CopyFile(string source, string target)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    while (true)
                    {
                        //本次读取实际读取到的有效字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //在写入的时候 应该写入实际读取到的有效字节数
                        fsWrite.Write(buffer, 0,r);
                        if (r == 0)
                        {
                            break;
                        }
                    }
                   
                }
            }
        }
    }
}
