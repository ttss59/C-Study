﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04求数组的最大值
{
    public delegate int DelCompare(object o1, object o2);
    class Program
    {
        static void Main(string[] args)
        {
           // object[] o = { 1, 2, 3, 4, 5 };
            object[] o = { "fdsfdsf", "123", "dsfdsf214321321321" };
            // DelCompare del=Compare;
            object max = GetMax(o, Compare2);
            Console.WriteLine(max);
            Console.ReadKey();
        }

        public static object GetMax(object[] nums, DelCompare del)
        {
            object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                //if (nums[i] > max)
                //{
                //    max = nums[i];
                //}
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static int Compare(object o1, object o2)
        {
            int n1 = (int)o1;//拆箱
            int n2 = (int)o2;
            return n1 - n2;
        }

        public static int Compare2(object o1, object o2)
        {
            string s1 = (string)o1;
            string s2 = (string)o2;
            return s1.Length - s2.Length;
        }



        //public static object GetMax(object[] names)
        //{
        //    object max = names[0];
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i].Length > max.Length)
        //        {
        //            max = names[i];
        //        }
        //    }
        //    return max;
        //}
    }
}
