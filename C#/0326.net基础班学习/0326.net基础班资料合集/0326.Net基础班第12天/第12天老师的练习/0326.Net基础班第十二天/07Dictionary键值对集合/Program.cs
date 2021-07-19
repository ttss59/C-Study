using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Dictionary键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "张三");
            dic.Add(2, "李四");
            dic.Add(3, "王五");
            dic[4] = "赵六";
            dic[2] = "哈哈";
            //lamda表达式
            foreach (KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine("{0}-------{1}",item.Key,item.Value);
            }
            //foreach (var item in dic.Keys)
            //{
            //    Console.WriteLine("{0}---{1}",item,dic[item]);
            //}
            Console.ReadKey();
            //for (int i = 0; i < dic.Count; i++)
            //{
            //    Console.WriteLine(dic[i]);
            //}
           // dic.Add(1, "赵六");
        }
    }
}
