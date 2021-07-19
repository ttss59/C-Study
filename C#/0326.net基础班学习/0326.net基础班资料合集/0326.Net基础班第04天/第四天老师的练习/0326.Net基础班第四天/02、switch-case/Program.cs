using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入几个人的名字,计算这几个人上辈都是干什么的?（老杨,老苏,老邹,老虎,老牛,老蒋,老王,老马）
            //Console.WriteLine("请输入要计算的人的姓名");
            //string name = Console.ReadLine();
            //switch (name)
            //{
            //    case "老杨": Console.WriteLine("老杨上辈子是折翼的天屎");
            //        break;
            //    case "老苏": Console.WriteLine("老苏上辈子是老鸨子");
            //        break;
            //    case "老邹": Console.WriteLine("老邹上辈子是老苏手下的头牌");
            //        break;
            //    case "老虎": Console.WriteLine("上辈子被武松挂了");
            //        break;
            //    case "老牛": Console.WriteLine("上辈子是Cow");
            //        break;
            //    default: Console.WriteLine("上辈子没这个人");
            //        break;
            //}
            //Console.ReadKey();


            //对学员的结业考试成绩评测(改成用Switch来做)             //     成绩>=90 ：A             //90>成绩>=80 ：B 	             //80>成绩>=70 ：C             //70>成绩>=60 ：D             //         成绩<60   ：E       //     switch(score/10)//0-100  9 10  A

            Console.WriteLine("请输入考试成绩");
            int score = Convert.ToInt32(Console.ReadLine());


            //请用户输年份,再输入月份,输出该月的天数.(结合之前如何判断闰年来做)
            switch (score / 10)
            {
                case 10://当连续的几个case中所带的代码一样的时候，可以省略前面的，只写最后一个case中的代码
                case 9: Console.WriteLine("A");
                    break;
                case 8: Console.WriteLine("B");
                    break;
                case 7: Console.WriteLine("C");
                    break;
                case 6: Console.WriteLine("D");
                    break;
                default: Console.WriteLine("E");
                    break;            }
            Console.ReadKey();
        }
    }
}
