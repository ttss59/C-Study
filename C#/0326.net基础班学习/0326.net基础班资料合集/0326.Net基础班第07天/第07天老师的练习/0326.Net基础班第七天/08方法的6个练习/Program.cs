using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08方法的6个练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //95、接受输入后判断其等级并显示出来。判断依据如下：等级={优 （90~100分）；良 （80~89分）
            //；中 （60~69分）；差 （0~59分）；}
            //Console.WriteLine("请输入学员考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //string level = GetLevel(score);
            //Console.WriteLine(level);
            //Console.ReadKey();

            //97、请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转


            //如果写一个方法要对数组进行改变，这个方法不需要返回值，外面的数组也会随之而改变。
            //string[] names = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //Change(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadKey();


            //98写一个方法 计算圆的面积和周长  面积是 pI*R*R  周长是 2*Pi*r
            //double area;
            //double perimeter;
            //GetAreaPerimeter(5, out area, out perimeter);
            //Console.WriteLine(area);
            //Console.WriteLine(perimeter);
            //Console.ReadKey();


            //100、计算任意多个数间的最大值（提示：params）。
            //int max = GetMax(4, 5, 6, 7, 8, 9);
            //Console.WriteLine(max);
            //Console.ReadKey();


            //101、请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
            //int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //MaoPao(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();



            //用方法来实现：请计算出一个整型数组的平均值。
            //{ 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 }。
            //要求：计算结果如果有小数，则显示小数点后两位（四舍五入）。
            //int[] nums = { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            //double avg = GetAvg(nums);
            //avg = Convert.ToDouble(avg.ToString("0.00"));
            //Console.WriteLine(avg);

            ////Console.WriteLine("{0:0.00}",avg);
            ////Console.WriteLine(avg);
            //Console.ReadKey();


            //102将一个字符串数组输出为|分割的形式，比如“梅西|卡卡|郑大世”(用方法来实现此功能)
            string[] names = { "梅西", "卡卡", "郑大世", "金秀贤", "金贤秀" };
            string str = ProcessString(names);
            Console.WriteLine(str);
            Console.ReadKey();
        }


        public static string ProcessString(string[] names)
        {
            string str = "";
            for (int i = 0; i < names.Length-1; i++)
            {
                str += names[i] + "|";
            }
            return str + names[names.Length - 1];
        }

        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }


        public static void MaoPao(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }


        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }



        public static void GetAreaPerimeter(double r, out double area, out double perimeter)
        {
            area = 3.14 * r * r;
            perimeter = 2 * 3.14 * r;
        }

        public static void Change(string[] names)
        {
            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }
        }

        public static string GetLevel(int score)
        {
            string level = "";
            switch (score / 10)
            {
                case 10:
                case 9: level = "优";
                    break;
                case 8: level = "良";
                    break;
                case 7: level = "中";
                    break;
                case 6: level = "差";
                    break;
                default: level = "不及格";
                    break;
            }
            return level;
        }
    }
}
