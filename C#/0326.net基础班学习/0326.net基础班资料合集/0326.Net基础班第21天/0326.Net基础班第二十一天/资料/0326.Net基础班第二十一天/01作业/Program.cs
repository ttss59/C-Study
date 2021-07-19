using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //Son son = new Son("王", 10000, "AB");
            //son.PlayGame();
            //Daughter d = new Daughter("王", 10000, "O");
            //d.Dance();
            //Console.ReadKey();

            //Truck truck = new Truck("解放牌", "绿色", 10000);
            //truck.LaHuo();
            //Car car = new Car("奔驰C级", "黑", 5);
            //car.ZaiKe();
            //Console.ReadKey();
            //Employee emp = new Manager();//new Employee();
            //emp.DaKa();
            //Console.ReadKey();

            //Animal a = new Dog();//new Cat();
            //a.Bark();
            //a.Eat();
            //Console.ReadKey();


            Shape shape = new Circle(5);
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();
            Console.WriteLine("面积是{0:0.00}，周长是{1:0.00}",area,perimeter);
            Console.ReadKey();
        }
    }


    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Circle : Shape
    {
        public double R
        {
            get;
            set;
        }

        public Circle(double r)
        {
            this.R = r;
        }

        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.R;
        }

    }

    public class Square : Shape
    {
        public double Height
        {
            get;
            set;
        }

        public double Width
        {
            get;
            set;
        }

        public Square(double heigth, double width)
        {
            this.Height = heigth;
            this.Width = width;
        }


        public override double GetArea()
        {
            return this.Height * this.Width;
        }

        public override double GetPerimeter()
        {
            return (this.Height + this.Width) * 2;
        }
    }




    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void Bark();
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("狗狗咬着吃");
        }

        public override void Bark()
        {
            Console.WriteLine("狗狗旺旺的叫");
        }
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵的叫");
        }

        public override void Eat()
        {
            Console.WriteLine("猫咪舔着吃");
        }
    }



    public class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工九点打卡");
        }
    }


    public class Manager : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("部门经理十点打卡");
        }
    }


    public class Vehicle
    {
        public string Brand
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public Vehicle(string brand, string color)
        {
            this.Brand = brand;
            this.Color = color;
        }

        public void Run()
        {
            Console.WriteLine("只要是车，就会跑");
        }
    }


    public class Truck : Vehicle
    {
        public double Weight
        {
            get;
            set;
        }

        public Truck(string brand, string color, double weight)
            : base(brand, color)
        {
            this.Weight = weight;
        }

        public void LaHuo()
        {
            Console.WriteLine("开车可以拉{0}的货物",this.Weight);
        }
    }


    public class Car : Vehicle
    {

        public Car(string brand, string color, int passenger):base(brand,color)
        {
            this.Passenger = passenger;
        }

        public int Passenger
        {
            get;
            set;
        }

        public void ZaiKe()
        {
            Console.WriteLine("我是轿车我可以拉{0}个人",this.Passenger);
        }
    }


    public class Father
    {
        string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        decimal _propert;

        public decimal Propert
        {
            get { return _propert; }
            set { _propert = value; }
        }

        string _blood;

        public string Blood
        {
            get { return _blood; }
            set { _blood = value; }
        }
        public Father(string lastName, decimal property, string blood)
        {
            this._lastName = lastName;
            this._propert = property;
            this._blood = blood;
        }
    }

    public class Son:Father
    {
        public Son(string lastName, decimal property, string blood)
            : base(lastName, property, blood)
        { 
        
        }

        public void PlayGame()
        {
            Console.WriteLine("我姓{0}，我的财产是{1},我的血型是{2},我会玩游戏",this.LastName,this.Propert,this.Blood);
        }
    }

    public class Daughter : Father
    {
        public Daughter(string lastName, decimal property, string blood)
            : base(lastName, property, blood)
        {

        }

        public void Dance()
        {
            Console.WriteLine("我姓{0}，我的财产是{1},我的血型是{2}，我会跳舞", this.LastName, this.Propert, this.Blood);
        }
    }
}
