﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _09File类的读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] str = File.ReadAllLines(@"C:\Users\SpringRain\Desktop\4.txt",Encoding.Default);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //string str = File.ReadAllText(@"C:\Users\SpringRain\Desktop\0326远程班学员机器码.txt",Encoding.Unicode);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //byte[] buffer = File.ReadAllBytes(@"C:\Users\SpringRain\Desktop\0326远程班学员机器码.txt");
            ////将字节数组转换成字符串
            ////189 89 76   189 89 76    woaini
            ////把字节数组解码成我们认识的字符串
            //string str = System.Text.Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(str);

            ////for (int i = 0; i < buffer.Length; i++)
            ////{
            ////    Console.WriteLine(buffer[i].ToString());
            ////}
            //Console.ReadKey();

            //1024byte=1kb
            //1024kb=1M
            //1024M=1G
            //1024G=1T
            //1024T=1PT
            // File.readall

            //会覆盖源文件
            //File.WriteAllLines(@"C:\Users\SpringRain\Desktop\new.txt", new string[] { "1", "2", "3" });

            //也会覆盖源文件内容
            // File.WriteAllText(@"C:\Users\SpringRain\Desktop\new.txt", "今天");



            //这三种写入方式都会覆盖源文件
            //string str="今天天气好晴朗，处处好风光";
            ////将字符串转换成字节数组
            //byte[] buffer=    System.Text.Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\SpringRain\Desktop\new.txt", buffer);
            //Console.WriteLine("写入成功");
            //Console.ReadKey();


            //追加着向文件中写入数据
            //File.AppendAllText(@"C:\Users\SpringRain\Desktop\new.txt", "我是新来的",Encoding.GetEncoding("gb2312"));
            //Console.WriteLine("追加成功");
            //Console.ReadKey();


            //byte[] buffer = File.ReadAllBytes(@"C:\Users\SpringRain\Desktop\1、复习.wmv");

            //File.WriteAllBytes(@"D:\new.wmv", buffer);
            //Console.WriteLine("复制成功");
            //Console.ReadKey();
        }
    }
}
