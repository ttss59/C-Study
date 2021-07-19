using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13out参数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法判断用户是否登陆成功
            //如果登陆成功返回一个true，并且返回一条登陆信息
            //如果登陆失败 返回一个false 返回一条错误信息
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();
            string msg;
            bool b = IsLogin(name, pwd, out msg);
            Console.WriteLine("登陆结果:{0}", b);
            Console.WriteLine("登陆信息:{0}",msg);
            Console.ReadKey();
        }

        /// <summary>
        /// 判断登陆是否成功
        /// </summary>
        /// <param name="userName">用户输入的用户名</param>
        /// <param name="userPwd">密码</param>
        /// <param name="msg">多余要返回的登陆信息</param>
        /// <returns>登陆是否成功</returns>
        public static bool IsLogin(string userName, string userPwd, out string msg)
        {
            if (userName == "admin" && userPwd == "admin")
            {
                msg = "登陆成功";
                return true;
            }
            else if (userName == "admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (userPwd == "admin")
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
    }
}
