using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ref参数和out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //double salary = 5000;
            //JiangJin(ref salary);
            //Console.WriteLine(salary);
            //Console.ReadKey();
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int min;
            //int max = GetMaxMin(nums, out min);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.Read();
            //

            //判断用户是否登录成功 如果成功返回true 并且返回一条信息 登录成功
            //如果失败 返回false  并且也返回一条信息 告诉用户哪错了

            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();
            string msg;
            bool b = IsLogin(name, pwd, out msg);
            Console.WriteLine("登录结果{0}",b);
            Console.WriteLine("登录信息{0}",msg);
            Console.ReadKey();
        }

        public static bool IsLogin(string name, string pwd, out string msg)
        {
            if (name == "admin" && pwd == "888888")
            {
                msg = "登录成功";
                return true;
            }
            else if (name == "admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (pwd == "888888")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }
        }


        public static int GetMaxMin(int[] nums,out int min)
        { 
            //out参数在方法内必须为其赋值
              min = nums[0];
              int max = nums[0];
              for (int i = 0; i < nums.Length; i++)
              {
                  if (nums[i] > max)
                  {
                      max = nums[i];
                  }
                  if (nums[i] < min)
                  {
                      min = nums[i];
                  }
              }
              return max;
        }

        public static void JiangJin(ref double s)
        {
            s += 500;
        }
    }
}
