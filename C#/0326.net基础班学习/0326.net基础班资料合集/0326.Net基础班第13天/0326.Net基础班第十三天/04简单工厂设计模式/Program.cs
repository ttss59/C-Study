using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //生产笔记本  IBM Lenovo Dell Acer

            //写一个方法  来模拟工厂生产笔记本
            Console.WriteLine("请问你需要什么品牌的笔记本");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();
        }

        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "IBM": nb = new IBM();
                    break;
                case "Lenovo": nb = new Lenovo();
                    break;
                case "Acer": nb = new Acer();
                    break;
                case "Dell": nb = new Dell();
                    break;
            }
            return nb;
        }
    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }

    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM笔记本");
        }
    }

    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本，你联想也别想");
        }
    }

    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是鸿基笔记本，垃圾中的战斗机");
        }
    }

    public class Dell : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是Dell笔记本，可以煮鸡蛋哟");
        }
    }
}
