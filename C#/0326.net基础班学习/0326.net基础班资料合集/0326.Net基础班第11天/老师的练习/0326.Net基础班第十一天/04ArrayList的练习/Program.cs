using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ArrayList的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //像ArrayList集合中添加一个整数类型的数组
            //求这个集合中的最大值、最小值、总和、平均值
            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            //int max = (int)list[0];
            //int min = (int)list[0];
            //int sum = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if ((int)list[i] > max)
            //    {
            //        max = (int)list[i];
            //    }
            //    if ((int)list[i] < min)
            //    {
            //        min = (int)list[i];
            //    }
            //    sum += (int)list[i];
            //}

            //int avg = sum / list.Count;
            //Console.WriteLine("{0}--{1}--{2}--{3}",max,min,sum,avg);
            //Console.ReadKey();

            //写一个长度为10的集合，要求在里面随机地存放10个数字（0-9），            //但是要求所有的数字不重复

            Random r = new Random();
            ArrayList list = new ArrayList();

            for (int i = 0; i <10; i++)
            {
                int rNumber = r.Next(0, 10);
                if (!list.Contains(rNumber))
                {
                    list.Add(rNumber);
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
