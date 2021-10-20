using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11
{
    internal class Program
    {
        private static void Test01()
        {
            string[] strs = File.ReadAllLines(@"D:\Desktop\test.txt");
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine("strs[{0}] = {1}", i, strs[i]);
            }
        }

        private static void Test02()
        {
            byte[] buffer = File.ReadAllBytes(@"D:\Desktop\test.txt");
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.WriteLine("buffer[{0}] = {1}", i, buffer[i]);
                Console.WriteLine("buffer str = " + buffer[i].ToString());
            }
            string str = Encoding.UTF8.GetString(buffer);
            Console.WriteLine("str = " + str);
        }

        private static void Test03()
        {
            string str = "现在开始要加油努力了，要持续下去，不能三天打鱼两天晒网！";
            byte[] buffer = Encoding.Default.GetBytes(str);
            if (File.Exists(@"D:\Desktop\new.txt"))
                File.WriteAllBytes(@"D:\Desktop\new.txt", buffer);
            else
            {
                Console.WriteLine("新建new.txt");
                //这种方式创建文件后立即写入，写入时会报错：另一程序正在访问该文件
                //File.Create(@"D:\Desktop\new.txt");
                //File.WriteAllBytes(@"D:\Desktop\new.txt", buffer);

                FileStream fs = new FileStream(@"D:\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                string str2 = Encoding.Default.GetString(buffer);
                sw.Write(str2);
                sw.Close();
            }
            Console.WriteLine("写入new.txt ok !");
        }

        private static void Test04()
        {
            //获取文件夹中所有文件
            string[] filePaths = Directory.GetFiles(@"D:\Desktop\Test", "*.txt");//找出.txt结尾的文件
            for (int i = 0; i < filePaths.Length; i++)
            {
                Console.WriteLine("filePath = " + filePaths[i]);
            }
            //获取文件夹中所有文件夹
            string[] dictPaths = Directory.GetDirectories(@"D:\Desktop\Test", "1*");//找出以1开头命名的文件夹
            for (int i = 0; i < dictPaths.Length; i++)
            {
                Console.WriteLine("dictPath = " + dictPaths[i]);
            }
        }

        /// <summary>Path类文件测试 </summary>
        private static void Test05()
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
            Console.WriteLine(Path.Combine(@"C:\a\", "b.txt"));
            Console.WriteLine(Path.ChangeExtension(@"C:\Users\SpringRain\Desktop\code.txt", ".jpg"));
        }

        /// <summary>相对路径和绝对路径均可以读取写入相应的文件 ,注：相对路径指的是程序.exe所在的路径</summary>
        private static void Test06()
        {
            string str = File.ReadAllText(@"D:\Desktop\Test\test.txt");
            Console.WriteLine("绝对路径下读取的 str = " + str);
            str = File.ReadAllText(@"相对路径Debug文件夹下.txt");
            Console.WriteLine("相对路径下读取的str " + str);
        }

        private static void Main(string[] args)
        {
            //Test02();
            //Test03();
            //Test04();
            //Test05();
            Test06();
            day12.TestClass testClass = new day12.TestClass();
            //day12.TestClass2 testClass2 = new day12.TestClass2();//interal修饰的TestClass2就无法跨项目访问
            Console.ReadKey();
        }
    }
}