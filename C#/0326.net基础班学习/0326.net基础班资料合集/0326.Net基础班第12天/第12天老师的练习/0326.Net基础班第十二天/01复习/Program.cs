using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable ht = new Hashtable();
            //ht.Add();
            //ht[1] = 1;
            /*
             ArrayList
             * Hastable
             * var 推断类型
             * foreach
             * File
             * ReadAllLines
             * ReadAllTexts
             * ReadAllBytes
             * 
             * Append
             * 
             * Path 操作路径
             * Directory 文件夹
             */
            //Directory
            //Directory
            byte[] buffer = File.ReadAllBytes(@"C:\Users\SpringRain\Desktop\抽象类特点.txt");
            //需要将字节数组解码成字符串

            string str = Encoding.Default.GetString(buffer);
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
