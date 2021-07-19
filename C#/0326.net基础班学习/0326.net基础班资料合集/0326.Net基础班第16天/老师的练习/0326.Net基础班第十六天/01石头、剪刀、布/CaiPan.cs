using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01石头_剪刀_布
{
    public enum Result
    {
        玩家赢,
        电脑赢,
        平手
    }

    public class CaiPan
    {
        //写一个方法用来计算谁赢 谁输

        public static Result GetResult(int playerNumber,int cpuNumber)
        {
            Result res = 0;
            if (playerNumber - cpuNumber == -1 || playerNumber - cpuNumber == 2)
            {
                res = Result.玩家赢;
            }
            else if (playerNumber - cpuNumber == 0)
            {
                res = Result.平手;
            }
            else
            {
                res = Result.电脑赢;
            }
            return res;
        }
    }
}
