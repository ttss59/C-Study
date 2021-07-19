using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07this的用法
{
    class Program
    {
        static void Main(string[] args)
        {
       
        }
    }

    public class Student
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

        public int ID
        {
            get;
            set;
        }


        public Student(string name, int age, char gender, int id)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.ID = id;
        }

        public Student(string name, int age, char gender):this(name,age,gender,0)
        {
        }


        public Student(int age, char gender, int id):this(null,age,gender,id)
        {
           
        }
    }
}
