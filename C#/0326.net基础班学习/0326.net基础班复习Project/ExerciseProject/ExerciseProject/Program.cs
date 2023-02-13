using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    internal class Program
    {
        public static void AddFiveDebuger(int num)
        {
            Console.WriteLine("输入的数字是:" + num);
            Console.WriteLine("加5后的结果是:" + num + 5);
        }

        private static void Main(string[] args)
        {
            //Test01();
            Test02();
            Console.ReadKey();
        }

        #region 泛型测试

        /// <summary>声明一个动物类型的接口<summary>
        private interface Animal
        {
            void Dark();//这种动物必须会叫
        }

        /// <summary>抽象类</summary>
        private abstract class Dog : Animal
        {
            public abstract void Dark();
        }

        private class HaShiQi : Dog
        {
            public override void Dark()
            {
                Console.WriteLine("呜呜呜");
            }
        }

        private class HomeDog : Dog
        {
            public override void Dark()
            {
                Console.WriteLine("汪汪汪");
            }
        }

        private static void AnimalBark<T>(T animal) where T : Dog
        {
            (animal as Dog).Dark();
        }

        private static void Test02()
        {
            HaShiQi haShiQi = new HaShiQi();
            AnimalBark<HaShiQi>(haShiQi);

            HomeDog homeDog = new HomeDog();
            AnimalBark<HomeDog>(homeDog);
        }

        #endregion 泛型测试

        #region 测试委托

        //定义 一个ChangerNumber类型的委托
        public delegate void ChangerNumber(int nume);

        /// <summary>测试委托的创建方式</summary>
        private static void Test01()
        {
            //声明 一个ChangerNumber委托变量 changerNumber
            ChangerNumber changerNumber;
            //创建 一个ChangerNumber委托对象
            changerNumber = new ChangerNumber(AddFiveDebuger);//赋值方式1:通过new的方式创建ChangerNumber委托对象
            //changerNumber = AddFiveDebuger;//赋值方式2:直接将对应的方法通过赋值运算符=，将方法赋值给声明的委托对象
            changerNumber(10);
        }

        #endregion 测试委托
    }
}