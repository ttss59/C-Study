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

        private static int[] Test01(int[] nums)
        {
            //定义一个规则，返回数组的第一个元素为最大值，第二个元素为最小值，第三个元素为总和，第四个元素为平均值
            int result = new int[4];
            result[0] = nums[0];
            result[1] = nums[0];
            result[2] = 0;
            result[3] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (result[0] > nums[i])
                {
                    result[0] = nums[i];
                }

                if (result[1] < nums[i])
                {
                    result[1] = nums[i];
                }
                result[2] += nums[i];
            }

            result[3] = result[2] / nums.Length;
            //return result;
        }

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

        //private static int OutInput()
        //{
        //    int num;
        //    try
        //    {
        //        Console.WriteLine("请输入一个数字：");
        //        num=int.Parse(Console.ReadLine());
        //        //return num;
        //    }
        //    catch
        //    {
        //        Console.WriteLine("输入不合法 ！");
        //        //return 0;
        //    }
        //}

        private static int OutInput()
        {
            int num;
            try
            {
                Console.WriteLine("请输入一个数字：");
                num = int.Parse(Console.ReadLine());
                //return num;
            }
            catch
            {
                Console.WriteLine("输入不合法 ！");
                //return 0;
            }
        }

        /*
         * //写一个方法判断用户是否登陆成功
         * //如果登陆成功返回一个true，并且返回一条登陆信息
         * //如果登陆失败 返回一个false 返回一条错误信息
         */

        /// <summary>
        /// 判断登录是否成功，并返回登录信息
        /// </summary>
        /// <param name="loginMessage">登录信息</param>
        /// <returns></returns>
        private static bool TryuLogin(string user, string password, out string loginMessage)
        {
            if (user == "admin" && password == "password")
            {
                loginMessage = "登录成功！";
                return true;
            }
            else if (password != "password")
            {
                loginMessage = "密码错误，登录失败！";
                return false;
            }
            else if (user != "admin")
            {
                loginMessage = "用户名错误，登录失败";
                return false;
            }
            else
            {
                loginMessage = "用户名错误，密码错误，登录失败！";
                return false;
            }
        }

        /*
         * 方法的重载不看返回值的类型。参赛类型完全一样，仅返回值类型不同，是会报错的，因为这种不是重载；
         */
        public static int IsLogin(int index)
        {
            return 0;
        }

        //public static bool IsLogin(int index)
        //{
        //    return false;
        //}

        private static void TestOut()
        {
            int num;//可以不赋值，在Test中赋值
            Test(out num);

            int num2;//必须先赋值num2，才可以使用
            Test(num2);
        }

        private static void TestOut()
        {
            int num;
            int num2 = 0;
            int num3;
            Test(out num2);
            Test(out num);
            Test(num2);
            //Test(num3);//必须先赋值num2，才可以使用,不然报错
            Test2(ref num2);
            //Test2(ref num3);//必须先赋值num3，才可以使用,不然报错
        }

        private static int Test(out int num)
        {
            // num = 0; //由于num被out修饰，所以num是返回值，若方法中不先对num进行赋值，则num无法使用！
            num++;
            return num;
        }

        private static int Test2(ref int num)
        {
            num++;//num被ref修饰，所以num是返回值，由于传入的ref参数必须先赋值，所以函数中，num可以定义也可以不定义直接使用
            return num;
        }

        private static int Test(int num)
        {
            num++;//num没有被out修饰，所以num是形参，方法中可以不赋值！
            return num;
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