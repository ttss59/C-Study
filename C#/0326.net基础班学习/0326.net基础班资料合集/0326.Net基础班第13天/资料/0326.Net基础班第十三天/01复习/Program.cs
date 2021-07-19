using System;
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
            /*
             文件流
             * FileStream  StreaReader  和 StremWriter
             * 装箱和拆箱
             * 泛型集合
             * 多态
             */
            //using (FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\接口特点.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];
            //    //本次读取实际读取到的有效字节数
            //    int r = fsRead.Read(buffer, 0, buffer.Length);

            //    //将字节数组转换成字符串
            //    string s = System.Text.Encoding.Default.GetString(buffer, 0, r);
            //    Console.WriteLine(s);
            //}
            //Console.ReadKey();

            //using (FileStream fsWriter = new FileStream(@"C:\Users\SpringRain\Desktop\new.txt", FileMode.Append, FileAccess.Write))
            //{ 
            //    string s="覆盖";
            //    byte[] buffer=System.Text.Encoding.Default.GetBytes(s);
            //    fsWriter.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("写入成功");
            //Console.ReadKey();

         //   List<int> list = new List<int>();
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "张三");
            //dic.Add(2, "李四");
            //dic[3] = "王五";
            //foreach (KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine("{0}---{1}",kv.Key,kv.Value);
            //}
            //Console.ReadKey();


            //值类型：int double char decimal bool enum struct
            //引用类型：string 数组 集合  自定义类 object 接口


            //多态：一个对象 多种类型
            //虚方法 、抽象类、接口
        }
    }
}
