using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList   Hashtable  List<T>  Dictionary<T,T>

            ArrayList list = new ArrayList();//数组
            //集合的长度可以任意改变
            list.Add(1);
            list.Add(10.5);
            list.Add(true);
            list.Add("张三");
            Person p = new Person();
            list.Add(p);
            list.Add(new int[] { 1, 2, 3, 4, 5 });
            list.Add(list);
           
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Person)
                {
                    ((Person)list[i]).SayHello();
                }
                else if (list[i] is int[])
                {
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        Console.WriteLine(((int[])list[i])[j]);
                    }
                }
                else if (list[i] is ArrayList)
                { 
                    
                }
                else
                {
                    Console.WriteLine(list[i]);
                }
                // Console.WriteLine(list[i]);
            }

        
            Console.ReadKey();



            // int[] nums = new int[10];
        }
    }


    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
}
