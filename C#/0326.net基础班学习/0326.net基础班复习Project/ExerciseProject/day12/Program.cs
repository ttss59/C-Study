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

        public void Test03()
        {
            Person person1 = new Person();
            //Student student = new Student();//这句话会报错，即使父类Person的默认构造函数还存在，但是子类继承了父类后，重写了带参数的构造函数，
            //那么子类的无参构造函数就会被丢弃,因此子类在创建对象时，是无法直接用默认无参构造函数创建的
        }

        public static List<int> Test04(int[] arrays, out List<int> evenList, out List<int> oddList)
        {
            List<int> result = new List<int>();
            evenList = new List<int>();
            oddList = new List<int>();
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] % 2 == 0)
                {
                    evenList.Add(arrays[i]);
                }
                else
                {
                    oddList.Add(arrays[i]);
                }
            }
            result.AddRange(oddList);
            result.AddRange(evenList);
            //result.InsertRange(oddList.Count, evenList);
            return result;
        }

        //有一个数组，将数组中的偶数拿出来放到一个集合中。
        //再将数组中的奇数拿出来放到一个集合中。最后将两个集合合并为一个集合
        //并让奇数在左侧，偶数在右侧
        private static void Test05()
        {
            int[] arrays = new int[] { 12, 5, 6, 32, 85, 669, 51, 22, 66, 88, 57 };
            List<int> listE, listO, result;
            result = Test04(arrays, out listE, out listO);
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        //2、让用户输入一个字符串，使用foreach循环赋值给一个char数组

        public static void Test06()
        {
            Console.WriteLine("请输入一串字符");
            string str = Console.ReadLine();
            char[] chars = new char[str.Length];
            int index = 0;
            foreach (var item in str)
            {
                chars[index] = item;
                Console.WriteLine("index = {0} char = {1}", index, item);
                index++;
            }
        }

        //统计 Welcome to China中每个字符出现的次数 不考虑大小写
        //W出现了1次
        //e出现了2次
        //l出现了1次
        public static void Test07()
        {
            string str = "Welcome to China";
            str = str.Replace(" ", "");
            Dictionary<char, int> charDic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!charDic.ContainsKey(str[i]))
                    charDic.Add(str[i], 1);
                else
                {
                    charDic[str[i]]++;
                }
            }
            foreach (var item in charDic)
            {
                Console.WriteLine("字符{0}，出现了{1}次", item.Key, item.Value);
            }
        }

        private static void Main(string[] args)
        {
            //using第二个用法，定义别名,仅在同一个文件中可以使用，跨文件（.cs文件）无法使用定义的别名
            //TC testClass = new TC();
            //testClass.Show();

            //Test01();
            //Test02();//答案是不会覆盖，而是在后面添加字符
            //Test05();//AddRange添加也分先后顺序，所以不用使用InsertRange
            //Test06();
            Test07();
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string name;

        public void SayHello(string name)
        {
            Console.WriteLine("大家好，我是 " + name);
        }
    }

    public class Student : Person
    {
        public Student(string name)
        {
            this.name = name;
        }
    }
}