using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_方法的由来
{
    class Program
    {
        static void Main(string[] args)
        {
            //超级玛丽  魂斗罗   长高的 加人的  花朵  五角星  无敌

            PlayGame();
            WuDi();

            PlayGame();
            PlayGame();
            PlayGame();
            WuDi();
            Console.ReadKey();


            string str = Console.ReadLine();
            int number = Convert.ToInt32("123");
        }


        /// <summary>
        /// 玩游戏
        /// </summary>
        public static void PlayGame()
        {
            Console.WriteLine("玛丽走呀走，顶呀顶");
            Console.WriteLine("玛丽走呀走，顶呀顶");
            Console.WriteLine("玛丽走呀走，顶呀顶");
            Console.WriteLine("玛丽走呀走，顶呀顶");
            Console.WriteLine("玛丽走呀走，顶呀顶");
            Console.WriteLine("突然顶到了一个无敌");
        }
        /// <summary>
        /// 顶到无敌后要执行的代码
        /// </summary>
        public static void WuDi()
        {
            Console.WriteLine("让人物角色在空中暂停");
            Console.WriteLine("让屏幕开始闪烁");
            Console.WriteLine("播放一段洋气的背景音乐");
            Console.WriteLine("主人公无敌了");
        }

    }
}
