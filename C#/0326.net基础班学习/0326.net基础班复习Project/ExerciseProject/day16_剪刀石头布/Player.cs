using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16_剪刀石头布
{
    internal class Player
    {
        #region 单例

        private static readonly object lockObj = new object();
        private static Player _instance;

        private Player()
        {
        }

        public static Player GetInstance()
        {
            if (_instance == null)
            {
                lock (lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new Player();
                    }
                }
            }
            return _instance;
        }

        #endregion 单例

        /// <summary>
        /// 玩家的猜拳方法，返回一个整型数字结果，裁判最后用数字来比较输赢
        /// </summary>
        /// <param name="fist"></param>
        /// <returns></returns>
        public int ShowFist(string fist)
        {
            switch (fist)
            {
                case "石头":
                    return 0;

                case "剪刀":
                    return 1;

                case "布":
                    return 2;

                default:
                    return 0;
            }
        }
    }
}