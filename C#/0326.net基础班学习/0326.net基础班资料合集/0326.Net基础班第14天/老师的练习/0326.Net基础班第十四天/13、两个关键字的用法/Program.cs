using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_两个关键字的用法
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //partial  sealed
            //sealed:表示密封类，一旦被次关键字修饰，将表示这个类不能被继承.密封类不可以被其他类继承，
            //但是，可以去继承其他类

            //partial：部分类
            //部分类，便于多人协作
        }
    }

    public partial class Person
    {
        private string _name;
    }

    public partial class Person
    {
    }

    //public sealed class Person:Student
    //{
    //}

    //public class Student
    //{
    //}
}