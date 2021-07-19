using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01石头_剪刀_布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayGame(str);
        }



        /// <summary>
        /// 玩游戏的方法
        /// </summary>
        /// <param name="str"></param>
        private void PlayGame(string str)
        {
            lblPlayer.Text =str;
            //创建玩家对象
            Player player = new Player();
            int playerNumber = player.ShowFist(str);

            Computer cpu = new Computer();
            int cpuNumber = cpu.ShowFist();
            //将属性的值赋值给label
            lblComputer.Text = cpu.Fist;

            Result res = CaiPan.GetResult(playerNumber, cpuNumber);

            lblResult.Text = res.ToString();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayGame(str);
        }

        private void btnBu_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGame(str);
        }
    }
}
