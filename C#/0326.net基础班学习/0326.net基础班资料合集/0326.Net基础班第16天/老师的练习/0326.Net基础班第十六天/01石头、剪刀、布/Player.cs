using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01石头_剪刀_布
{
    public class Player
    {

        /// <summary>
        /// 出拳的方法 返回一个数字
        /// </summary>
        /// <param name="fist">出的拳头</param>
        /// <returns></returns>
        public int ShowFist(string fist)
        {
            int num = 0;
            switch (fist)
            {
                case "石头": num = 0;
                    break;
                case "剪刀": num = 1 ;
                    break;
                case "布": num= 2;
                    break;
            }
            return num;
        }
    }
}
