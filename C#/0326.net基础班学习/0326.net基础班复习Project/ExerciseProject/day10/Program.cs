using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class Person
    {
        private string _name;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Person()
        {
            Console.WriteLine("Person Init base");
        }

        public Person(string name)
        {
            Console.WriteLine("Person Init base name = " + name);
            this.name = name;
        }

        public void Introduce()
        {
            Console.WriteLine("我是一个人类，我的名字叫： " + name);
        }
    }

    internal class Student : Person
    {
        public Student()
        {
            Console.WriteLine("Student Init ！");
        }

        public Student(string stName)
        {
            name = stName;
            Console.WriteLine("Student name = " + name);
        }

        public new void Introduce()
        {
            Console.WriteLine("我是一个学生，我的名字叫： " + name);
        }
    }

    internal class Teacher : Person
    {
        public Teacher(string thName) : base(thName)
        {
            name = thName;
            Console.WriteLine("Teacher name = " + name);
        }

        public new void Introduce()
        {
            Console.WriteLine("我是一个老师，我的名字叫： " + name);
        }
    }

    internal class Program
    {
        private static void TestString()
        {
            string st = "";
            //创建计时器计时
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                st += i.ToString();
            }
            stopwatch.Stop();
            Console.WriteLine("st = " + st);
            Console.WriteLine("String 用时(秒) ：" + stopwatch.Elapsed.TotalSeconds);
        }

        private static void TestStringBudiler()
        {
            StringBuilder st = new StringBuilder();
            //创建计时器计时
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                st.Append(i.ToString());
            }
            stopwatch.Stop();
            Console.WriteLine("st = " + st.ToString());
            Console.WriteLine("StringBuilder 用时(秒) ：" + stopwatch.Elapsed.TotalSeconds);
        }

        private static void TestClass()
        {
            //Teacher teacher = new Teacher();//汇报错，因为Teacher中的无参构造函数已经被干掉了

            //即使是子类重写的是有参的构造函数，并且父类也重写了有参构造函数，
            //但是new子类调用子类有参构造函数时仍会执行父类的无参构造函数
            //除非子类用base关键字指定调用父类的构造函数
            Teacher teacher = new Teacher("Tim");
            Student student1 = new Student();
            Student student2 = new Student("Tom");

            Person person = new Person("Tena");

            List<Person> people = new List<Person>();
            people.Add(teacher);
            people.Add(student1);
            people.Add(student2);
            people.Add(person);
            for (int i = 0; i < people.Count; i++)
            {
                people[i].Introduce();
            }

            Console.WriteLine("--------------------------");
            teacher.Introduce();
            ((Person)teacher).Introduce();
            if (person is Teacher)
                ((Teacher)person).Introduce();
        }

        private static void Main(string[] args)
        {
            //TestString();//用时约为：0.0018
            //TestStringBudiler();//用时约为：0.078左右
            TestClass();
            Console.ReadKey();
        }
    }
}