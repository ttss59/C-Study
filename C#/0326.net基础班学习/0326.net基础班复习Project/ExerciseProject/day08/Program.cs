using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08
{
    /// <summary>
    /// 飞行棋
    /// </summary>
    internal class Program
    {
        private static int[] mapInfo = new int[100];
        private static int[] playersIndex = new int[2];
        private static string[] playerName = new string[2];
        private static string[] playerTags = new string[2];

        private static bool isGameEnd = false;
        private static int playGameCount = -1;
        private static bool gamePause=false;
        private static int pasueIndex = -1;

        private static void Main(string[] args)
        {
            DrawHead();
            InitPlayers();
            InitMapInfo();
            while (!isGameEnd)
            {
               
                playGameCount++;
                int currentIndex = playGameCount % 2;
                
                if (gamePause==true&& pasueIndex != -1 && currentIndex == pasueIndex)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0}玩家此轮游戏暂定，继续由玩家{1}游戏",playerName[currentIndex], playerName[1 - currentIndex]);
                    currentIndex = 1 - currentIndex;
                    gamePause = false;
                    pasueIndex = -1;
                    //保证下回合该暂停的玩家掷色子，避免同一个玩家连续掷色子三次
                    playGameCount++;
                }
                PlayGame(currentIndex);
            }
         
            Console.ReadKey();
        }

        private static void DrawGameInfo()
        {
            Console.WriteLine("{0} 的士兵用A表示", playerName[0]);
            Console.WriteLine("{0} 的士兵用B表示", playerName[1]);
            Console.WriteLine("图例: 幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
        }

        private static void InitPlayers()
        {
            string name;
            Console.WriteLine("请输入玩家A的姓名：");
            name = Console.ReadLine();
            while (name == "")
            {
                Console.WriteLine("玩家姓名A不能为空，请重新输入：");
                name = Console.ReadLine();
            }
            playerTags[0] = "Ａ";
            playerName[0] = name;
            Console.WriteLine("请输入玩家B的姓名：");
            name = Console.ReadLine();
            while (name == "")
            {
                Console.WriteLine("玩家姓名B不能为空，请重新输入：");
                name = Console.ReadLine();
            }
            playerTags[1] = "Ｂ";
            playerName[1] = name;
        }

        private static void DrawHead()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**************飞行棋_v0.1*************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("**************************************");
        }

        private static void PlayGame(int index)
        {
            Console.WriteLine();
            Console.WriteLine("请玩家 {0} 按输入任意键掷色子:",playerName[index]);
            Console.ReadKey(true);
            int count = new Random().Next(1, 7);
            Console.WriteLine("玩家 {0} 掷出的色子点数为:{1}，请输入任意键开始行动。",playerName[index],count);
            Console.ReadKey(true);
            Console.Clear();
            DrawHead();
            DrawGameInfo();
            playersIndex[index] += count;
            if (playersIndex[index] >= 99)
            {
                //赢了
                Win(index);
                return;
            }
            else if (playersIndex[index] == playersIndex[1 - index])
            {
                playersIndex[1 - index] = playersIndex[1 - index] > 6 ? playersIndex[1 - index] - 6 : 0;
                Console.WriteLine("哦豁，{0}玩家你踩到玩家{1}了，玩家{2}必须向后退6格,按任意键开始行动。", playerName[index],playerName[1-index], playerName[1-index]);
                Console.ReadKey(true);
            }
            else
            {
                switch (mapInfo[playersIndex[index]])
                {
                    case 1:
                        //踩到了幸运轮盘 1交换位置  2 轰炸对方 使对方退6格
                        Console.WriteLine("恭喜，{0} 踩到幸运轮盘，请选择操作:  1=>交换位置  2=>轰炸对方",playerName[index]);
                        string op = Console.ReadLine();
                        while (op != "1" && op != "2")
                        {
                            Console.WriteLine("输入的操作非法！请输入：\"1\"或者\"2\"");
                            op = Console.ReadLine();
                        }
                        if (op == "1")
                        {
                            int tempIndex = playersIndex[index];
                            playersIndex[index] = playersIndex[1 - index];
                            playersIndex[1 - index] = tempIndex;
                        }
                        else
                        {
                            playersIndex[1 - index] = playersIndex[1 - index] > 6 ? playersIndex[1 - index] - 6 : 0;
                        }
                        break;

                    case 2:
                        //踩到了地雷 退6格
                        Console.WriteLine("抱歉，{0}玩家你踩到地雷了，必须向后退6格,按任意键开始行动。", playerName[index]);
                        Console.ReadKey(true);
                        playersIndex[index] = playersIndex[index] > 6 ? playersIndex[index] - 6 : 0;
                        break;

                    case 3:
                        //踩到了暂停  暂停一回合
                        gamePause = true;
                        pasueIndex = index;
                        Console.WriteLine("抱歉，{0}踩到暂停，下回合掷色子暂停,按任意键开始行动。", playerName[index]);
                        Console.ReadKey(true);
                        break;

                    case 4:
                        //踩到了时空隧道 进10格
                        playersIndex[index] += 10;
                        Console.WriteLine("恭喜，{0}踩到时空隧道，向前进10格,按任意键开始行动。", playerName[index]);
                        Console.ReadKey(true);
                        if (playersIndex[index] > 99)
                        {
                            Win(index);
                            return;
                        }
                        break;

                    default:
                        break;
                }
            }

            DrawLine();
        }

        private static void DrawLine()
        {
            //画第一行
            for (int i = 0; i <= 29; i++)
            {
                DrawItem(i);
            }

            for (int i = 30; i <= 34; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                DrawItem(i);
            }
            Console.WriteLine();
            for (int i = 64; i >= 35; i--)
            {
                DrawItem(i);
            }
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine();
                DrawItem(i);
            }
            Console.WriteLine();
            for (int i = 70; i <= 99; i++)
            {
                DrawItem(i);
            }
        }

        private static void DrawItem(int i)
        {
            if (playersIndex[0] == i && playersIndex[0] == playersIndex[1])
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("<>");
            }
            else if (playersIndex[0] == i && playersIndex[0] != playersIndex[1])
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(playerTags[0]);
            }
            else if (playersIndex[1] == i && playersIndex[0] != playersIndex[1])
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(playerTags[1]);
            }
            else
            {
                switch (mapInfo[i])
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("◎");
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("☆");
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("▲");
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("卐");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("□");
                        break;
                }
            }
        }

        private static void InitMapInfo()
        {
            int[] tempArray;
            tempArray = new int[] { 6, 23, 40, 55, 69, 83 };// 1 幸运轮盘◎;
            InsetMap(tempArray, 1);
            tempArray = new int[] { 5, 13, 17, 33, 38, 50, 64, 80, 94 };// 2 地雷☆
            InsetMap(tempArray, 2);
            tempArray = new int[] { 9, 27, 60, 93 };// 3 暂停▲
            InsetMap(tempArray, 3);
            tempArray = new int[] { 20, 25, 45, 63, 72, 88, 90 };// 4 时空隧道卐
            InsetMap(tempArray, 4);

            Console.Clear();
            DrawHead();
            DrawGameInfo();
            DrawLine();
        }

        private static void InsetMap(int[] info, int index)
        {
            for (int i = 0; i < info.Length; i++)
            {
                mapInfo[info[i]] = index;
            }
        }

        /// <summary>
        /// 胜利啦！！！
        /// </summary>
        public static void Win(int index)
        {
            isGameEnd = true;
            playersIndex[index] = 99;
            Console.WriteLine("{0} 在这次游戏中取得胜利！", playerName[index]);
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