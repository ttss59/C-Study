﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05泛型委托
{
    //泛型委托
    public delegate int DelCompare<T>(T t1, T t2);
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5 };
            //string[] names = { "2131", "fdsfdsfdsf", "21321321321321321321" };
            //string max = GetMax<string>(names, Compare2);
            //Console.WriteLine(max);
            //Console.ReadKey();
            //int max = GetMax<int>(nums, Compare1);
            //Console.WriteLine(max);
            //Console.ReadKey();


            Person[] pers = { new Person() { Age = 18 }, new Person() { Age = 29 } };
            Person p = GetMax<Person>(pers, Compare3);
            Console.WriteLine(p.Age);
            Console.ReadKey();
        }
        public static T GetMax<T>(T[] nums, DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }


        public static int Compare1(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Compare2(string s1, string s2)
        {
            return s1.Length - s2.Length;
        }


        public static int Compare3(Person p1, Person p2)
        {
            return p1.Age - p2.Age;
        }
    }


    public class Person
    {
        public int Age
        {
            get;
            set;
        }
    }
}
