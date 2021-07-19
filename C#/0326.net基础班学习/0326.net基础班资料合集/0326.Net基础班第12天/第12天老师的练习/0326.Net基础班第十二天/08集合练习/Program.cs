using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> listJi = new List<int>();
            //List<int> listOu = new List<int>();
            //listJi.Add(1);
            //listJi.Add(3);
            //listJi.Add(5);
            //listOu.Add(2);
            //listOu.Add(4);
            //listOu.Add(6);

            //listOu.AddRange(listJi);
            //for (int i = 0; i < listOu.Count; i++)
            //{
            //    Console.WriteLine(listOu[i]);
            //}
            //Console.ReadKey();
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //string str = "Welcome to China";
            //listJi.AddRange(listOu);
            //for (int i = 0; i < listJi.Count; i++)
            //{
            //    Console.WriteLine(listJi[i]);
            //}
            //Console.ReadKey();
            //List<int> listSum = new List<int>();
            
            //listSum.AddRange(listOu);
            //listSum.AddRange(listJi);
            //for (int i = 0; i < listSum.Count; i++)
            //{
            //    Console.WriteLine(listSum[i]);
            //}
            //Console.ReadKey();



            // //1、有一个数组，将数组中的偶数拿出来放到一个集合中。
            //再将数组中的奇数拿出来放到一个集合中。最后将两个集合合并为一个集合
            //，并让奇数在左侧，偶数在右侧
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listJi = new List<int>();//存放奇数
            //List<int> listOu = new List<int>();//存放偶数
            //List<int> listSum = new List<int>();
          
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 != 0)
            //    {
            //        listJi.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listOu.Add(nums[i]);
            //    }
            //}

            //listJi.AddRange(listOu);
            //foreach (var item in listJi)
            //{
            //    Console.WriteLine(item);
            //}

            ////listSum.AddRange(listJi);
            ////listSum.AddRange(listOu);
            ////foreach (var item in listSum)
            ////{
            ////    Console.Write(item + "\t");
            ////}
            //Console.ReadKey();


            //   //2、让用户输入一个字符串，使用foreach循环赋值给一个char数组

            //Console.WriteLine("请输入一个字符串");
            //string input = Console.ReadLine();
            //char[] chs=new char[input.Length];
            ////for (int i = 0; i < input.Length; i++)
            ////{
            ////    chs[i] = input[i];
            ////}
            //int i = 0;
            //foreach (var item in input)
            //{
            //    chs[i] = item;
            //    i++;
            //}
            //foreach (var item in chs)
            //{
            //    Console.Write(item);
            //}
            //Console.ReadKey();



            //3、经典的面试题
            //统计 Welcome to China中每个字符出现的次数 不考虑大小写
            //W出现了1次
            //e出现了2次
            //l出现了1次

            string str = "Welcome to China";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                // 键值对集合中的键不包含当前循环到的这个字符
                //就说明当前这个字符在键值对集合中第一次出现
                if (!dic.ContainsKey(str[i]))
                {
                    dic.Add(str[i], 1);
                }
                else//包含当前循环到的这个字符
                {
                    dic[str[i]]++;
                }
            }



            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("字符{0}出现了{1}次",kv.Key,kv.Value);
            }
            Console.ReadKey();
        }
    }
}
