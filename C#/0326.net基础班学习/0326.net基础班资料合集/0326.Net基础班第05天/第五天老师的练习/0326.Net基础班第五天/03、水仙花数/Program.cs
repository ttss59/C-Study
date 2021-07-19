using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_水仙花数
{
    class Program
    {
        static void Main(string[] args)
        {
            //水仙花数：100-999  
            //这个百位数字 百位的立方+十位的立方+个位的立方==当前这个百位数字
           //153  1+125+27 153  i   
            //百位：153/100
            //十位：153%100/10
            //个位：153%10

            for (int i = 100; i <= 999; i++)
            {
                int bai = i / 100;
                int shi = i % 100 / 10;
                int ge = i % 10;
                if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();


        }
    }
}
