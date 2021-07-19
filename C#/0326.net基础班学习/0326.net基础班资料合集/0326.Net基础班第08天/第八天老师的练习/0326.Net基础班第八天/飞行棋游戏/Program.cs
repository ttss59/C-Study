using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 飞行棋游戏
{
    class Program
    {
        public static int[] Maps = new int[100];//存储地图的数组
        public static int[] PlayerPos = new int[2];//PlayerPos[0]A的坐标 玩家坐标
        public static string[] PlayerName = new string[2];//存储玩家姓名
        public static bool[] Flags = new bool[2];
        static void Main(string[] args)
        {
            GameHead();
            #region 输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名");
            PlayerName[0] = Console.ReadLine();
            while (PlayerName[0] == "")
            {
                Console.WriteLine("玩家A的姓名不能为空，请重新输入");
                PlayerName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerName[1] = Console.ReadLine();
            while (PlayerName[1] == "" || PlayerName[1] == PlayerName[0])
            {
                if (PlayerName[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空，请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能跟玩家A的姓名相同，请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
            }
            #endregion
            Console.Clear();//清屏
            //清屏完成后，再讲游戏头画一遍
            GameHead();
            Console.WriteLine("{0}的士兵用A表示",PlayerName[0]);
            Console.WriteLine("{0}的士兵用B表示",PlayerName[1]);
            InitialMap();
            DrawMap();
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);//A 第一次玩的时候踩到了暂停
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}",PlayerName[0],PlayerName[1]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerName[1], PlayerName[0]);
                    break;
                }
            }//while
            Win();
            Console.ReadKey();
        }
        /// <summary>
        /// 画游戏头
        /// </summary>
        public static void GameHead()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************");
            Console.WriteLine("***0326版骑士飞行棋游戏--v1.0*");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******************************");
        }
        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitialMap()
        {
            //我用0表示普通,显示给用户就是 □
            //....1...幸运轮盘,显示组用户就◎ 
            //....2...地雷,显示给用户就是 ☆
            //....3...暂停,显示给用户就是 ▲
            //....4...时空隧道,显示组用户就 卐
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }
        public static void DrawMap()
        {
            Console.WriteLine("图例:幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
            #region 第一横行
            for (int i = 0; i <= 29; i++)
            {
                Console.Write(DrawStringMap(i));
            }//for
            #endregion
            //画完第一横行后应该换行
            Console.WriteLine();

            #region 第一竖行
            for (int i = 30; i <= 34; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion


            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            //画完第二横行后应该换行
            Console.WriteLine();
            #region 第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion

            #region 第三横行
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            //画完最后一行后应该换行
            Console.WriteLine();
        }
        /// <summary>
        /// 抽象出来的画地图的方法  返回一个要画的字符串
        /// </summary>
        /// <param name="i">当前地图坐标</param>
        /// <returns></returns>
        public static string DrawStringMap(int i)
        {
            string str = "";
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
            {
                str="<>";
            }
            else if (PlayerPos[0] == i)
            {
              str="Ａ";//shift+空格 切换全角/半角
            }
            else if (PlayerPos[1] == i)
            {
             str="Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                      str="□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                       str="◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                       str="☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str="▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                       str="卐";
                        break;
                }//switch
            }//else
            return str;
        }//方法的结束括号
        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="playerNumber"></param>
        public static void PlayGame(int playerNumber)
        {
            #region 玩游戏的过程
            Random r = new Random();
            int rNumber=r.Next(1,7);
            Console.WriteLine("玩家{0}按任意键开始掷骰子", PlayerName[playerNumber]);
            Console.ReadKey(true);//按下的任意键不在控制台中显示
            Console.WriteLine("玩家{0}掷出了{1}", PlayerName[playerNumber],rNumber);
            PlayerPos[playerNumber] += rNumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}按任意键开始行动", PlayerName[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}行动完了", PlayerName[playerNumber]);
            Console.ReadKey(true);
            //如果玩家A踩到了玩家B
            if (PlayerPos[playerNumber] == PlayerPos[1-playerNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退6格", PlayerName[playerNumber], PlayerName[1 - playerNumber], PlayerName[1 - playerNumber]);
                Console.ReadKey(true);
                PlayerPos[1 - playerNumber] -= 6;
                ChangePos();
                Console.WriteLine("玩家{0}退了5格", PlayerName[1 - playerNumber]);
                Console.ReadKey(true);
            }
            else//玩家A并没有踩到玩家B,而是踩到了特殊的关卡上
            {
                switch (Maps[PlayerPos[playerNumber]])
                {
                    case 0: Console.WriteLine("玩家{0}踩到了方块，什么都不发生", PlayerName[playerNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1: Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择 1--交换位置 2--轰炸对方", PlayerName[playerNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择了跟玩家{1}交换位置", PlayerName[playerNumber], PlayerName[1 - playerNumber]);
                                int temp = PlayerPos[playerNumber];
                                PlayerPos[playerNumber] = PlayerPos[1 - playerNumber];
                                PlayerPos[1 - playerNumber] = temp;
                                ChangePos();
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择了轰炸玩家{1}，玩家{2}退6格", PlayerName[playerNumber], PlayerName[1 - playerNumber], PlayerName[1 - playerNumber]);
                                PlayerPos[1 - playerNumber] -= 6;
                                ChangePos();
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("输入有误，请重新输入 1--交换位置 2--轰炸对方");
                                input = Console.ReadLine();
                            }

                        }
                        break;
                    case 2: Console.WriteLine("玩家{0}踩到了地雷，退6格", PlayerName[playerNumber]);
                        PlayerPos[playerNumber] -= 6;
                        ChangePos();
                        Console.ReadKey(true);
                        break;
                    case 3: Console.WriteLine("玩家{0}踩到了暂停,暂停一回合", PlayerName[playerNumber]);
                        Flags[playerNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4: Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerName[playerNumber]);
                        PlayerPos[playerNumber] += 10;
                        ChangePos();
                        Console.ReadKey(true);
                        break;
                }
            }


            Console.Clear();
            DrawMap();
            #endregion
        }
        /// <summary>
        /// 当玩家坐标发生改变的时候 判断玩家的坐标  让玩家一直保持在这个地图上
        /// </summary>
        public static void ChangePos()
        {
            if (PlayerPos[0] <= 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] <= 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }
        }
        /// <summary>
        /// 胜利啦！！！
        /// </summary>
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }
    }
}
