using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17枚举类型和string类型_int类型之间的转换
{
    public enum QQState
    {
        OnLine=1,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {

            #region 将枚举类型强制转换为int类型
            //枚举类型和int类型互相兼容
            //int n1 = (int)QQState.OnLine;
            //Console.WriteLine(n1);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion


            #region 将int类型强制转换为枚举类型
            //int n1 = 10;
            //QQState s1 = (QQState)n1;
            //Console.WriteLine(s1);
            //Console.ReadKey();
            #endregion


            #region 将枚举类型转换为字符串类型 调用ToString()
            //QQState s = QQState.OnLine;
            //Console.WriteLine(s.ToString());
            //Console.ReadKey();
            #endregion


            #region 将字符串类型转换为枚举类型
            //QQState s1 = (QQState)Enum.Parse(typeof(QQState), "Hello");
            //Console.WriteLine(s1);
            //Console.ReadKey();
            #endregion


            Console.WriteLine("请选择您的qq在线状态  1--OnLine,2--OffLine 3--Leave 4--Busy 5--QMe ");
            string input = Console.ReadLine();//1-5

            switch (input)
            {
                case "1": QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择在线状态是{0}",s1);
                    break;
                case "2": QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                      Console.WriteLine("您选择在线状态是{0}",s2);
                    break;

                case "3": QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                      Console.WriteLine("您选择在线状态是{0}",s3);
                    break;
                case "4": QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择在线状态是{0}", s4);
                    break;
                case "5": QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择在线状态是{0}", s5);
                    break;
            }
            Console.ReadKey();


        }
    }
}
