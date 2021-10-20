using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Hashtable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //字典  hello---->中文解释 键值对集合
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add('c', true);
            ht.Add(3.14, 100);
            ht.Add(2, "张三");
            //使用下面这种方式向集合中添加相同的键不会抛异常
            ht[2] = "李四";//键是5  值 李四
                         // ht.Clear();
            ht.Remove(1);//根据键去删除数据
            if (ht.ContainsKey(1))
            {
                Console.WriteLine("已经具有相同的键");
            }
            else
            {
                ht.Add(1, "王五");
            }
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键----{0}，值----{1}", item, ht[item]);
            }
            Console.ReadKey();

            //Console.WriteLine(ht[1]);
            //Console.WriteLine(ht['c']);
            //Console.WriteLine(ht[3.14]);
            for (int i = 0; i < ht.Count; i++)
            {
                Console.WriteLine(ht[i]);//i  0 1 2    ht[0]  ht[1] ht[2]
            }
            Console.ReadKey();
        }
    }
}