using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16_剪刀石头布
{
    public enum FistRusult
    {
        玩家赢,
        电脑赢,
        平局
    }

    internal class Judger
    {
        public static Judger _instance;
        public static readonly object lockObj = new object();

        private Judger()
        {
        }

        public static Judger GetInstance()
        {
            if (_instance == null)
            {
                lock (lockObj)
                {
                    if (_instance == null)
                        _instance = new Judger();
                }
            }
            return _instance;
        }

        public FistRusult JudgeResult(int playerFist, int computerFist)
        {
            FistRusult fistRusult;
            int num = playerFist - computerFist;
            if (num == -1 || num == 2)
                fistRusult = FistRusult.玩家赢;
            else if (num == 0)
                fistRusult = FistRusult.平局;
            else
                fistRusult = FistRusult.电脑赢;
            return fistRusult;
        }
    }
}