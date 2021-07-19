using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //List  Dictionary
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            list.AddRange(list);
            //将集合转换成数组
            //List<string> listTwo = new List<string>();
            //listTwo.ToArray()

            //List<byte> list1 = new List<byte>();
            //list1.ToArray()


            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
         //   ArrayList listArr = new ArrayList();
        }
    }
}
