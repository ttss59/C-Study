using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal class Program
    {
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
                set;
                get;
            }

            public string Gender
            {
                set;
                get;
            }
        }

        //序列化和反序列化
        private static void Test01()
        {
            Person person = new Person();
            person.Name = "马冬梅";
            person.Gender = "女";
            person.Age = 26;

            using (FileStream fs = new FileStream(@"D:\Desktop\person.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, person);
            }
            Person result;
            using (FileStream fr = new FileStream(@"D:\Desktop\person.txt", FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                result = (Person)binaryFormatter.Deserialize(fr);
            }

            if (result != null)
            {
                Console.WriteLine("result.Name = " + result.Name);
                Console.WriteLine("result.Age = " + result.Age);
                Console.WriteLine("result.Gender = " + result.Gender);
            }
        }

        private static void TestSuperMarket()
        {
            SuperMarket superMarket = new SuperMarket();
            while (!superMarket.IsSellOver())
            {
                superMarket.AsynBuying();
            }
        }

        private static void Main(string[] args)
        {
            //Test01();
            TestSuperMarket();
            Console.ReadKey();
        }
    }
}