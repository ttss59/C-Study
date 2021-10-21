using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象类
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //使用多态来实现计算圆形和矩形的面积和周长

            Shape shape = new Square(5, 6);//new Circle(5);
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();
            Console.WriteLine("这个形状的面积是{0:0.00}，周长是{1:0.00}", area, perimeter);
            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        /// <summary>
        /// 计算面积
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();

        /// <summary>
        /// 计算周长
        /// </summary>
        /// <returns></returns>
        public abstract double GetPerimeter();
    }

    public class Circle : Shape
    {
        public Circle(double r)
        {
            this.R = r;
        }

        public double R
        {
            get;
            set;
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
        public double Chang
        {
            get;
            set;
        }

        public double Kuan
        {
            get;
            set;
        }

        public Square(double chang, double kuan)
        {
            this.Chang = chang;
            this.Kuan = kuan;
        }

        public override double GetArea()
        {
            return this.Chang * this.Kuan;
        }

        public override double GetPerimeter()
        {
            return (this.Chang + this.Kuan) * 2;
        }
    }
}