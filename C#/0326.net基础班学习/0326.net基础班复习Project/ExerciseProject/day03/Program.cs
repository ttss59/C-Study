using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03
{
    internal class Program
    {
        /*
         *1、打印100次"欢迎您来传智播客学习
         *2、输入班级人数,然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
         *3、老师问学生,这道题你会做了吗?如果学生答"会了(y)",则可以放学.如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......
             3.1、直到学生会为止,才可以放学.
             3.2、直到学生会或老师给他讲了10遍还不会,都要放学
         *4、2006年培养学员80000人，每年增长25%，请问按此增长速度，到哪一年培训学员人数将达到20万人？
         */

        private static void Main(string[] args)
        {
            //Test01();
            Test03();
            //Test04();
            //Test05();
        }

        private static void Test01()
        {
            int var1, var2 = 5, var3 = 6;
            //var1 = var2++ * --var3;
            int var4 = ++var2 * var3--;
            //Console.WriteLine("var1 = var2++ * --var3" + var1);
            Console.WriteLine("var4 = ++var2 * var3--   =  " + var4);
            Console.WriteLine("var2=" + var2);
            Console.WriteLine("var3=" + var3);
            Console.ReadKey();
        }

        /// <summary>打印100次"欢迎您来传智播客学习</summary>
        private static void Test02()
        {
            int i = 0;
            while (i < 100)
            {
                Console.WriteLine("欢迎您来传智播客学习");
                i++;
            }
        }

        /// <summary>输入班级人数,然后依次输入学员成绩，计算班级学员的平均成绩和总成绩</summary>
        private static void Test03()
        {
            Console.WriteLine("请输入班级人数:");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            double sum = 0;
            while (i <= num)
            {
                Console.WriteLine("请输入第{0}个同学成绩:", i);
                sum += Convert.ToDouble(Console.ReadLine());
                i++;
            }
            Console.WriteLine("{0}个学生的总成绩是{1}，平均成绩是{2}", num, sum, (sum / num).ToString("0.##"));////结果保留两位小数，如果结果为整数,则不显示小数，只显示整数
            Console.WriteLine("{0}个学生的总成绩是{1}，平均成绩是{2}", num, sum, (sum / num).ToString("0.00"));//结果保留两位小数，如果结果为整数，一样显示两位小数00，如2.00
            Console.WriteLine("{0}个学生的总成绩是{1}，平均成绩是{2}", num, sum, string.Format("{0:00}", (sum / num)));//结果如果大于两位则以实际的整数保存，如果不足两位，则以两位数字保存，如：1000/3=333 10/3=03
            Console.WriteLine("{0}个学生的总成绩是{1}，平均成绩是{2}", num, sum, (sum / num).ToString("f2"));//结果保留两位小数，如果结果为整数，一样显示两位小数00，如2.00
            Console.ReadKey();
        }

        /// <summary>
        /// 3、老师问学生,这道题你会做了吗?如果学生答"会了(y)",则可以放学.如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......
        /// 3.1、直到学生会为止,才可以放学.
        /// 3.2、直到学生会或老师给他讲了10遍还不会,都要放学
        /// </summary>
        private static void Test04()
        {
            Console.WriteLine("老师心理建设是否完美（完美:Y,不完美:N）:");
            string result = Console.ReadLine();
            string answer = "";
            if (result == "Y" || result == "y")
            {
                while ((answer != "y" && answer != "Y"))
                {
                    Console.WriteLine("同学，你这题会了吗？（会：y，不会：n）");
                    answer = Console.ReadLine();
                }
            }
            else if (result == "N" || result == "n")
            {
                int maxTryCount = 0;
                while ((answer != "y" && maxTryCount < 10 && answer != "Y"))
                {
                    Console.WriteLine("同学，你这题会了吗？（会：y，不会：n）");
                    answer = Console.ReadLine();
                    maxTryCount++;
                }
            }
            Console.WriteLine("终于可以不用问了");

            Console.ReadKey();
        }

        /// <summary>
        /// 4、2006年培养学员80000人，每年增长25%，请问按此增长速度，到哪一年培训学员人数将达到20万人？
        /// </summary>
        private static void Test05()
        {
            float origin = 80000;
            int count = 0;
            while (origin < 250000)
            {
                origin *= 1.25f;
                count++;
            }

            Console.WriteLine("第{0}年时培训人数会达到250000人", count);
            Console.ReadKey();
        }
    }
}