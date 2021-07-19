using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    public enum Gender
    {
        男,
        女
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 19;
            zsPerson._gender = Gender.男;

            /*
             for 循环 已知循环次数
             * 枚举 规范程序员开发
             * int.tryParse false
             * int.parse 抛异常
             * 枚举和int之间的转换
             * 枚举和string之间的转换
             * 三元表达式 表达式1?表达式2:表达式3
             * 常量 const 一旦声明就不能被重新赋值
             * 数组 声明相同类型的变量
             * 结构 声明不同类型的变量
             */

            int[] nums = new int[10];
            string[] str = new string[10];
            bool[] bools = new bool[10];
            int[] numsTwo = { 1, 2, 3, 4, 5 };
        }
    }
}