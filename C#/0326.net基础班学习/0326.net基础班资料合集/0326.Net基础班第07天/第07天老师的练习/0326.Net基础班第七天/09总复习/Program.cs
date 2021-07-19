using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09总复习
{
    public enum Sesons
    { 
        春,
        夏,
        秋,
        冬
    }

    public enum Gender
    { 
        男,
        女
    }

    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Sesons s = Sesons.春;
            //将字符串的1转成Sesons类型
            //Sesons s = (Sesons)Enum.Parse(typeof(Sesons), "1");
            //Console.WriteLine(s);
            //Console.ReadKey();
            //Person zsPerson;
            //zsPerson._name = "张三";
            //zsPerson._age = 19;
            //zsPerson._gender = Gender.男;

            int[] nums = new int[5];
            nums[0] = 1;
            nums[1] = 2;

        }
    }
}
