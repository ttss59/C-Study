using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TC = day12.TestClass;

namespace day12
{
    public class TestClass
    {
        public void Show()
        {
            Console.WriteLine("Init day12.TestClass");
        }
    }

    internal class TestClass2
    {
        public TC tC = new TC();

        public void Show()
        {
            tC.Show();
            Console.WriteLine("TestClass2Show !");
        }
    }

    internal class Program
    {
        private static void Test01()
        {
            //第一步：首先创建一个FileStream的对象
            //第一个参数表示要操作文件的路径
            //第二个参数表示对文件做一个怎样的操作
            //第三个参数表示对文件中的数据进行怎样的操作
            FileStream fsRead = new FileStream(@"D:\Desktop\抽象类特点.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] buffer = new byte[1024 * 1024 * 2];
            //返回这个int类型表示这次读取实际读取到的字节数
            int r = fsRead.Read(buffer, 0, buffer.Length);
            Console.WriteLine("r = " + r);
            string str = "天天向上，好好学习!坚持不懈，不懒惰";
            byte[] buffer1 = Encoding.Default.GetBytes(str);
            fsRead.Write(buffer1, 0, buffer1.Length);
            fsRead.Close();
            fsRead.Dispose();
            //将字节数组转换成字符串
            string str2 = System.Text.Encoding.Default.GetString(buffer, 0, r);
            Console.WriteLine(str2);
            Console.ReadKey();
        }

        private static void Test02()
        {
            //使用FileStream来写入数据
            //using 第三个用法：定义一个范围，在范围结束时处理对象，
            //是用来简化资源释放的，在一定的范围内有效，出了这个范围时，自动调用IDisposable释放掉，当然并不是所有的类都适用，只有实现了IDisposable接口的类才可以使用
            //要达到这样的目的，用try...catch来捕捉异常也是可以的，但用using也很方便。
            using (FileStream fsWrite = new FileStream(@"D:\Desktop\new.txt", FileMode.Append, FileAccess.Write))
            {
                string s = "看看是否把元数据覆盖";
                //将字符 串转换成字节数组
                byte[] buffer = System.Text.Encoding.Default.GetBytes(s);
                fsWrite.Write(buffer, 0, buffer.Length);
                Console.WriteLine("写入成功");
            }
        }

        private static void Main(string[] args)
        {
            //using第二个用法，定义别名,仅在同一个文件中可以使用，跨文件无法使用定义的别名
            //TC testClass = new TC();
            //testClass.Show();

            //Test01();
            Test02();//答案是不会覆盖，而是在后面添加字符
            Console.ReadKey();
        }
    }
}