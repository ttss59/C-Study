using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_while循环的3个练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入班级人数,然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //循环体：提示用户输入学员成绩，接收，转成int类型，累加到总成绩中
            //循环条件：循环的次数小于等于班级人数

            #region 练习1
            //Console.WriteLine("请输入班级人数");
            //int count = Convert.ToInt32(Console.ReadLine());
            //int i = 0;//声明一个循环变量，记录循环的次数
            //int sum = 0;//定义总成绩
            //while (i < count)
            //{
            //    Console.WriteLine("请输入第{0}个学员的成绩", i + 1);
            //    try
            //    {
            //        int score = Convert.ToInt32(Console.ReadLine());
            //        //将每一个学员的成绩累加到总成绩中
            //        sum += score;
            //        i++;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入有误，请重新输入");
            //    }
            //}
            //Console.WriteLine("{0}个人的班总成绩是{1}平均成绩是{2}", count, sum, sum / count);
            //Console.ReadKey(); 
            #endregion



            //            老师问学生,这道题你会做了吗?如果学生答"会了(y)",            //则可以放学.如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......            //直到学生会为止,才可以放学.            //老师给他讲了10遍还不会,都要放学

            //循环体：老师不停的讲，不停的问，学生不停的答
            //循环条件:1、学生不会 2、讲题的次数小于10遍

            //int i = 0;//记录循环次数
            //string answer = "";//学生的回答
            //while (answer != "yes" && i < 10)
            //{
            //    Console.WriteLine("这是我第{0}遍给你讲，你会了么？", i + 1);
            //    answer = Console.ReadLine();
            //    while (answer != "yes" && answer != "no")
            //    {
            //        Console.WriteLine("只能输入yes或者no");
            //        answer = Console.ReadLine();
            //    }
            //    i++;
            //}
            //Console.ReadKey();


            //2006年培养学员80000人，每年增长25%，请问按此增长速度，            //到哪一年培训学员人数将达到20万人？

            //循环体：每年增长25%
            //循环条件：总人数小于等于20万

            int year = 2006;
            double people = 80000;
            while (people <= 200000)
            {
                //每年增长25%
                people *= 1.25;
                year++;
            }
            Console.WriteLine("到{0}年的时候，人数将达到20万",year);
            Console.ReadKey();
        }
    }
}
