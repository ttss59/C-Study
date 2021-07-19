using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06
{
    internal class Program
    {
        private enum QQState
        {
            Hide,
            Show,
            GoAway
        }

        private static void Test01()
        {
            foreach (var item in Enum.GetValues(typeof(QQState)))
            {
                Console.WriteLine("{0}类型的值为{1}", item.ToString(), (int)item);
            }

            Console.WriteLine("请输入你的QQ状态值：");
            string state = Console.ReadLine();
            QQState currentState = (QQState)Enum.Parse(typeof(QQState), state);
            //如果输入的是数字1，则打印结果为1，Show；
            //如果输入的是Show，则打印结果为Show，Show；
            Console.WriteLine("当前输入的QQ状态值为：{0},对应的QQ状态为：{1}", state, currentState);
        }

        /*练习1：从一个整数数组中取出最大的整数,最小整数,总和,平均值
         * 练习2：计算一个整数数组的所有元素的和。
         * 练习3:数组里面都是人的名字,分割成:例如:老杨|老苏|老邹…”(老杨,老苏,老邹,老虎,老牛,老蒋,老王,老马)
         * 练习4：将一个整数数组的每一个元素进行如下的处理：如果元素是正数则将这个位置的元素的值加1，如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变。
         * 练习5：将一个字符串数组的元素的顺序进行反转。{“我”,“是”,”好人”} {“好人”,”是”,”我”}。
         */

        /// <summary>
        /// 练习1：从一个整数数组中取出最大的整数,最小整数,总和,平均值
        /// </summary>
        private static void Test02()
        {
            Console.WriteLine("请输入5个数字：");
            int[] array = new int[5];
            int max = 0;
            int min = 0;
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                //避免出现初始值0为最大值或者最小值
                if (i == 0)
                {
                    min = array[i];
                    max = array[i];
                }
                else
                {
                    max = max > array[i] ? max : array[i];
                    min = min < array[i] ? min : array[i];
                }
                sum += array[i];
            }
            avg = sum / array.Length;
            Console.WriteLine("你输入的数字中最大值为{0}，最小值为：{1}，总和为：{2}，平均值为:{3}", max, min, sum, avg);
        }

        /// <summary>
        ///  练习5：将一个字符串数组的元素的顺序进行反转。{“我”,“是”,”好人”} {“好人”,”是”,”我”}。
        /// </summary>
        private static void Test03()
        {
            string[] array = new string[] { "我", "真的", "是", "一个", "好人" };

            int limit = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                string temp;
                if (i < limit)
                {
                    temp = array[i];
                    array[i] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = temp;
                    limit--;
                }
            }

            //老师的写法
            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp;
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private struct MyColor
        {
            public int red;
            public int blue;
            public int green;
        }

        private static void Test04()
        {
            //测试代码04
            MyColor myColor = new MyColor();
            myColor.red = 1;
            myColor.green = 0;
            myColor.blue = 0;
        }

        private static void Main(string[] args)
        {
            const float pi = 3.14f;
            //Test01();
            //Test02();
            Test03();
            Console.ReadKey();
        }
    }
}