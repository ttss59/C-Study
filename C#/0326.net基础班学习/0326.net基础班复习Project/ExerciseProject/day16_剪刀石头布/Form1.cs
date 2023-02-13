using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day16_剪刀石头布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayGame(string playerFist)
        {
            lblPlayer.Text = playerFist;
            int playResult = Player.GetInstance().ShowFist(playerFist);
            int computerResult = Computer.GetInstance().ShowFist();
            lblComputer.Text = Computer.GetInstance().fistRsult;
            FistRusult result = Judger.GetInstance().JudgeResult(playResult, computerResult);
            lblJudger.Text = result.ToString();
        }

        private void butST_Click(object sender, EventArgs e)
        {
            PlayGame("石头");
        }

        private void butJD_Click(object sender, EventArgs e)
        {
            PlayGame("剪刀");
        }

        private void butB_Click(object sender, EventArgs e)
        {
            PlayGame("布");
        }
    }
}