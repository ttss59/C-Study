using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ArrayList集合的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //给集合添加单个元素
            //list.Add(1);
            //list.Add(3.14);
            //list.Add(5000m);
            //list.Add(true);
            //list.Add("张三");
            //list.Add('男');
            ////给集合添加集合
            //list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            //list.AddRange(new string[] { "张三", "李四", "王五", "赵六", "田七" });

            //list.Add("IV");
            //list.Add("V");
            //list.Add("I");
            //list.Sort();
           // list.AddRange(list);
            //删除集合中所有的元素
           // list.Clear();
            //删除单个元素
           // list.Remove("abcd");
           // list.RemoveAt(6);
           // list.RemoveRange(6, 5);
            //向集合中插入元素
            //list.Insert(1, "我是新来的");
            //list.InsertRange(0, new string[] { "哇哈哈", "科比布莱恩提", "林书豪", "老杨" });
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
