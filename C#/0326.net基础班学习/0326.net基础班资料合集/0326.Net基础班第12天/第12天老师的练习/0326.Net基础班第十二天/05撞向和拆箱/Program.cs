using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace _05撞向和拆箱
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //装箱：将值类型转换为引用类型
            //拆箱：将引用类型转换为值类型
            //值类型:int double decimal enum struct bool char
            //引用类型：数组 集合 自定义类 string object

            //int n = 10;
            //object o = n;//值类型---》引用类型  装箱

            //double nn = (double)o;//引用类型---》值类型 拆箱
            ////装箱的时候 使用的什么类型 拆箱的时候也得使用对应的类型
            //Console.WriteLine(n);

            //ArrayList listArr = new ArrayList();
            //List<int> list = new List<int>();
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            ////00:00:02.4847316
            ////00:00:00.2637815
            //for (int i = 0; i < 10000000; i++)
            //{
            //    list.Add(i);
            //   // listArr.Add(i);//装箱
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.ReadKey();

            //string s = "123";
            //int n = Convert.ToInt32(s);//拆箱？这个地方并没有发生任何的装箱或者拆箱

            //看两个类型发生装箱或者拆箱，首先我们要观察的是发生类型转换的这个两个类型
            //是否存在继承关系。

            int n = 10;
            IComparable i = n;//值类型---》引用类型  装箱
        }
    }
}