using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //多态：一个对象能够表现出多种的状态
            //虚方法、抽象类、接口
            //虚方法：首先将父类的方法标记为虚方法，标记为虚方法就意味着这个方法可以被子类重写。
            //重写子类中的每一个方法
            Chinese cn1 = new Chinese("韩梅梅");
            Chinese cn2 = new Chinese("李明");
            Japanese j1 = new Japanese("武X兰");
            Japanese j2 = new Japanese("吉XX步");
            Korea k1 = new Korea("金x贤");
            Korea k2 = new Korea("全X贤");
            American a1 = new American("大布什");
            American a2 = new American("小布什");
            Person[] pers = { cn1, cn2, j1, j2, k1, k2, a1, a2 };
            for (int i = 0; i < pers.Length; i++)
            {
                pers[i].SayHello();
                #region Old Method
                // if (pers[i] is Chinese)
                // {
                //     ((Chinese)pers[i]).SayHello();
                // }
                // else if (pers[i] is Japanese)
                // {
                //     ((Japanese)pers[i]).SayHello();
                // }
                // else if (pers[i] is Korea)
                // {
                //     ((Korea)pers[i]).SayHello();
                // }
                // else
                // {
                //     ((American)pers[i]).SayHello();
                // }
                //// pers[i].SayHello(); 
                #endregion
            }
            Console.ReadKey();
        }
    }

    public class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string name) 
        {
            this.Name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("大家好，我是人类，我叫{0}",this.Name);
        }
    }

    public class Chinese : Person
    {
        public Chinese(string name)
            : base(name)
        { 
            
        }

        public override void SayHello()
        {
            Console.WriteLine("大家好，我是中国人，我叫{0}",this.Name);
        }
    }

    public class Japanese : Person
    {

        public Japanese(string name)
            : base(name)
        { 
            
        }
        public override void SayHello()
        {
            Console.WriteLine("大家好，我叫{0}，我是脚盆国人",this.Name);
        }
    }

    public class Korea : Person
    {

        public Korea(string name)
            : base(name)
        { 
            
        }
        public override void SayHello()
        {
            Console.WriteLine("大家好，我叫{0}兮思密达，我是韩国棒之",this.Name);
        }
    }

    public class American : Person
    {

        public American(string name)
            : base(name)
        { 
            
        }
        public override void SayHello()
        {
            Console.WriteLine("大家好，我叫{0}，我是大米国人",this.Name);
        }
    }

    
}
