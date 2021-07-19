using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace _06序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //序列化：就是将对象转换为二进制
            //反序列化：就是将二进制转换为对象
            //作用：传输数据     01010101    1 0


            //服务器端
            //序列化：1、将要序列化的对象所在的类标记为可以被序列化
            //Person p = new Person();
            //p.Name = "张三";
            //p.1Age = 19;
            //p.Gender = '男';
            //using (FileStream fsWrite = new FileStream(@"C:\Users\SpringRain\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //序列化的对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();

            //在客户端将这一坨二进制转换成对象
            Person per;
            using (FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                per = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(per.Name);
            Console.WriteLine(per.Age);
            Console.WriteLine(per.Gender);
            Console.ReadKey();


        }
    }


    [Serializable]
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
    }
}
