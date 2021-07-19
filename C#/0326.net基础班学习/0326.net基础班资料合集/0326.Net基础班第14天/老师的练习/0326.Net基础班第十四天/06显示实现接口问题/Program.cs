using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06显示实现接口问题
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Person : M
    {

        public void Test()
        {
            
            Console.WriteLine("我是Person类中的Test");
        }

        //public string Test(string name)
        //{
        //    return name;
        //}

        string M.Test(string name)
        {
            return name;
        }
    }


    public interface M
    {
        string Test(string name);
    }
}
