using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //File
            //byte[] buffer=new byte[1024*1024*1024];
            //File.WriteAllBytes(@"C:\Users\SpringRain\Desktop\1.wmv",buffer);
            //Console.WriteLine("成功");
            //Console.ReadKey();
            //string str = File.ReadAllText(@"C:\Users\SpringRain\Desktop\1.wmv");
            //Console.ReadKey();
            //FileStream   StreamReader StreamWriter

            //使用FileStream来读取一个文件


            //第一步：首先创建一个FileStream的对象
            //第一个参数表示要操作文件的路径
            //第二个参数表示对文件做一个怎样的操作
            //第三个参数表示对文件中的数据进行怎样的操作
            //FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\抽象类特点.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 2];
            ////返回这个int类型表示这次读取实际读取到的字节数
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            //fsRead.Close();
            //fsRead.Dispose();
            ////将字节数组转换成字符串
            //string str = System.Text.Encoding.Default.GetString(buffer, 0, r);
            //Console.WriteLine(str);
            //Console.ReadKey();


            //使用FileStream来写入数据
            using (FileStream fsWrite = new FileStream(@"C:\Users\SpringRain\Desktop\new.txt", FileMode.Append, FileAccess.Write))
            {
                string s = "看看是否把元数据覆盖";
                //将字符 串转换成字节数组
                byte[] buffer = System.Text.Encoding.Default.GetBytes(s);
                fsWrite.Write(buffer, 0, buffer.Length);
                Console.WriteLine("写入成功");
            }

            Console.ReadKey();




        }
    }
}
