using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17_3_控制台练习题
{
    internal class Program
    {
        /// <summary>
        /// 1.	编写一段程序，运行时向用户提问“你考了多少分？（0~100）”，接受输入后判断其等级并显示出来。
        /// 判断依据如下：等级={优 （90~100分）；良 （80~89分）；中 （60~69分）；差 （0~59分）；}
        /// </summary>
        private static void Question01()
        {
            Console.WriteLine("你考了多少分？（0~100）");
            string inp = Console.ReadLine();
            float result = 0;
            while (!(float.TryParse(inp, out result) && result >= 0 && result <= 100))
            {
                Console.Write("你的输入非法！请输入正确分数：");
                inp = Console.ReadLine();
            }
            if (result >= 90)
                Console.WriteLine("你的等级为优");
            else if (result >= 80 && result < 90)
                Console.WriteLine("你的等级为良");
            else if (result >= 60 && result < 69)
                Console.WriteLine("你的等级为中");
            else
                Console.WriteLine("你的等级为差");
        }

        /// <summary>
        /// 编程绘出99乘法表
        /// </summary>
        private static void Question02()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i != j)
                        Console.Write(string.Format("{0}*{1}={2}\t", i, j, i * j));
                    else
                        Console.WriteLine(string.Format("{0}*{1}={2}", i, j, i * j));
                }
            }
        }

        /// <summary>
        /// 3.	定义长度50的数组,随机给数组赋值,并可以让用户输入一个数字n,按一行n个数输出数组  int[]  array = new int[50];
        /// Random r = new Random();  r.Next();
        /// </summary>
        private static void Question03()
        {
            int[] array = new int[50];
            Random rd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next();
            }

            Console.WriteLine("请确定按多少个数字来输出数组：");
            int inp = int.Parse(Console.ReadLine());//不去判断输入是否非法

            for (int i = 0; i < array.Length; i++)
            {
                //随机的数字长度不一样，导致有时候无法对齐，暂时不管了
                if (i % inp != 0 || i == 0)
                    Console.Write(string.Format("{0}\t", array[i].ToString()));
                else
                    Console.Write(string.Format("\n{0}\t", array[i].ToString()));
            }
        }

        /// <summary>
        /// 4.	编写一个函数,接收一个字符串,把用户输入的字符串中的第一个字母转换成小写然后返回(命名规范  骆驼命名)
        /// name       s.SubString(0,1)      s.SubString(1);
        /// </summary>
        private static void Question04()
        {
            //不考虑健壮性，比如输入的第一个字符不是字母而是数字
            Console.WriteLine("请输入一个字符串：");
            string inp = Console.ReadLine();
            string head = inp[0].ToString().ToUpper();
            string newStr = head + inp.Substring(1);
            Console.WriteLine("新的字符串为：" + newStr);
        }

        /// <summary>
        /// 5.	编写一个函数,接收一个字符串,把用户输入的字符串中的第一个字母转换成大小然后返回（命名规范  帕斯卡）
        /// 没看懂啥意思，不写了
        /// </summary>
        private static void Question05()
        {
        }

        /// <summary>
        /// 6.	声明两个变量：int n1 = 10, n2 = 20;要求将两个变量交换，最后输出n1为20,n2为10。扩展（*）：不使用第三个变量如何交换？
        /// </summary>
        private static void Question06()
        {
            ///看了网上的思路
            int n1 = 18, n2 = 16;
            Console.WriteLine("交换前： n1 = " + n1 + " n2 = " + n2);
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("交换后：n1 = " + n1 + " n2 = " + n2);
        }

        /// <summary>
        /// 7.	用方法来实现：将上题封装一个方法来做。提示：方法有两个参数n1,n2,在方法中将n1与n2进行交换，使用ref。（*）
        /// </summary>
        private static void Question07()
        {
            int n1 = 56, n2 = 58;
            Console.WriteLine("交换前： n1 = " + n1 + " n2 = " + n2);
            Question07_Swap(ref n1, ref n2);
            Console.WriteLine("交换后：n1 = " + n1 + " n2 = " + n2);
        }

        private static void Question07_Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        /// <summary>
        /// 8.	请用户输入一个字符串，计算字符串中的字符个数，并输出。
        /// </summary>
        private static void Question08()
        {
            Console.WriteLine("请输入一个字符串：");
            string inp = Console.ReadLine();
            Console.WriteLine("输入字符串中的字符个数为：" + inp.Length);
        }

        /// <summary>
        /// 9.	用方法来实现：计算两个数的最大值。思考：方法的参数？返回值？扩展（*）：计算任意多个数间的最大值（提示：params）。
        /// </summary>
        private static void Question09(params int[] num)
        {
            if (num.Length <= 0) return;
            int max = num[0];
            string str = null;//用于打印有那些数字
            for (int i = 0; i < num.Length; i++)
            {
                str += num[i] + "  ";
                if (num[i] > max)
                {
                    max = num[i];
                }
            }

            Console.WriteLine(str + "中数字最大的是：" + max);
        }

        /// <summary>
        /// 10.	用方法来实现：计算1-100之间的所有整数的和。
        /// 11.	用方法来实现：计算1-100之间的所有奇数的和。
        /// 结果：5050，2500
        /// </summary>
        private static void Question10()
        {
            int sum = 0, sumJS = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += i;
                if (i % 2 != 0)
                    sumJS += i;
            }
            Console.WriteLine("1-100的整数和为 = " + sum + "  奇数和 = " + sumJS);
        }

        /// <summary>
        /// 12.	用方法来实现：判断一个给定的整数是否为“质数”。
        /// </summary>
        private static bool Question12(int num = 0)
        {
            int result;
            if (num == 0)
            {
                Console.WriteLine("请输入一个大于1的整数：");
                result = int.Parse(Console.ReadLine());
            }
            else
                result = num;
            for (int i = 2; i < result; i++)
            {
                if (result % i == 0)
                {
                    Console.WriteLine(result + "不是质数");
                    return false;
                }
            }
            Console.WriteLine(result + "是质数");
            return true;
        }

        /// <summary>
        /// 13.	用方法来实现：计算1-100之间的所有质数（素数）的和。
        /// 结果：1060
        /// </summary>
        private static void Question13()
        {
            int sum = 0;
            for (int i = 2; i < 100; i++)
            {
                if (Question12(i))
                    sum += i;
            }
            Console.WriteLine("1-100内的质数和 = " + sum);
        }

        /// <summary>
        /// 15.	用方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
        /// </summary>
        private static void Question15()
        {
            string[] strArray = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            int count = strArray[0].Length;
            string maxStr = strArray[0];
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > count)
                {
                    count = strArray[i].Length;
                    maxStr = strArray[i];
                }
            }
            Console.WriteLine("最长字符串为：" + maxStr);
        }

        /// <summary>
        /// 16.	用方法来实现：请计算出一个整型数组的平均值。{ 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 }。
        /// 要求：计算结果如果有小数，则显示小数点后两位（四舍五入）。
        /// </summary>
        private static void Question16()
        {
            //不想写，练习下保存小数吧
            Console.WriteLine(string.Format("1/3={0:f2}", 1 / 3.0f));//不记得就查一下吧
        }

        /// <summary>
        /// 17.	请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
        /// </summary>
        private static void Question17()
        {
            int[] array = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + "  ";
            }
            Console.WriteLine(str);
        }

        /// <summary>
        /// 18.	为教师编写一个程序，该程序使用一个数组存储30个学生的考试成绩，并给各个数组元素指定一个1-100的随机值，然后计算平均成绩。
        /// 看不懂啥意思，不写了
        /// </summary>
        private static void Question18()
        {
        }

        /// <summary>
        /// 19.	有如下字符串：【"患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”"】。
        /// 需求：请统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现的索引位置。
        /// 结果：7次，分别在：第1次咳嗽在：8，64，73，90，106，123，133出现
        /// </summary>
        private static void Question19()
        {
            string str = "患者：“大夫，我咳嗽得咳 咳 咳 很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            int index = 0;
            int count = 0;
            while (str.Contains("咳嗽"))
            {
                count++;
                int num = str.IndexOf("咳嗽");
                if (count == 1)//第一次不加2
                    index = num;
                else
                    index += num + 2;
                str = str.Remove(0, num + 2);
                Console.WriteLine(string.Format("第{0}次咳嗽在：" + index, count));
            }
            Console.WriteLine("咳嗽一共出现了：" + count + " 次");
        }

        /// <summary>
        /// 20.	将字符串"  hello      world,你  好 世界   !    "两端空格去掉，并且将其中的所有其他空格都替换成一个空格，
        /// 输出结果为："hello world,你 好 世界 !"。
        /// </summary>
        private static void Question20()
        {
            string str = "  hello      world,你  好 世界   !    ";
            str = str.Trim();
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            Console.WriteLine("处理后字符串：" + str);
        }

        /// <summary>
        /// 21.	制作一个控制台小程序。要求：用户可以在控制台录入每个学生的姓名，当用户输入quit（不区分大小写）时，
        /// 程序停止接受用户的输入，并且显示出用户输入的学生的个数，以及每个学生的姓名
        /// 22.	题目内容同上题，再增加一个显示姓“王”的同学的个数，此处不考虑复姓问题。效果如图：
        /// </summary>
        private static void Question21()
        {
            string inp = null;
            List<string> studentList = new List<string>();
            List<string> wangList = new List<string>();
            Console.WriteLine("请输入姓名：");
            inp = Console.ReadLine();
            while (inp.ToLower() != "quit")
            {
                if (inp.StartsWith("王"))
                    wangList.Add(inp);
                studentList.Add(inp);
                Console.WriteLine("请输入姓名：");
                inp = Console.ReadLine();
            }

            Console.WriteLine("一共输入了：" + studentList.Count + " 个学生，姓名分别是：");
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(studentList[i]);
            }
            Console.WriteLine("姓王的同学个数：" + wangList.Count);
        }

        /// <summary>
        ///23.	请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。然后输出反转后的数组。不能用数组的Reverse()方法。
        /// </summary>
        private static void Question23()
        {
            string[] array = { "中国", "美国", "巴西", "澳大利亚", "加拿大", "俄罗斯" };
            //array = array.Reverse().ToArray();//根据要求不用这个方法

            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// 24.	创建一个Person类，属性：姓名、性别、年龄；方法：SayHi() 。再创建一个Employee类继承Person类，扩展属性Salary,重写SayHi方法。
        /// </summary>
        private static void Question24()
        {
            //这个不想写
        }

        /// <summary>
        /// 25.	请编写一个类：ItcastClass,该类中有一个私有字段_names,数据类型为：字符串数组，长度为5，并且有5个默认的姓名。要求：为ItcastClass类编写一个索引器，要求该索引器能够通过下标来访问_names中的内容。
        /// </summary>
        private static void Question25()
        {
        }

        private static void Main(string[] args)
        {
            //Question01();
            //Question02();
            //Question03();
            //Question06();
            //Question07();
            //Question08();
            //Question09(52, 66, 86, 888, 99, 665, 22, 666666, -95, -1800021, 55, 1);
            //Question10();
            //Question12();
            //Question13();//结果：
            //Question15();
            //Question16();
            //Question17();
            Question19();
            //Question20();
            //Question21();
            //Question23();
            Console.ReadKey();
        }
    }
}