using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15_小闹钟
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("修改闹钟时间：" + clockTime.Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labTxt1.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTxt1.Text = DateTime.Now.ToString();
            //由于有毫秒的差距，导致每秒判断时无法保证相等，所以需将时间格式统一
            //if (DateTime.Compare(DateTime.Now, clockTime.Value) == 0)
            //TimeSpan timeSpan = DateTime.Now - clockTime.Value;
            //if (timeSpan.Seconds > 1)

            DateTime t1 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            DateTime t2 = Convert.ToDateTime(clockTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (DateTime.Compare(t1, t2) == 0)
            {
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = @"1.wav";//只能播放wav格式的音频，相对路径（Debug文件夹中的1.wav文件）
                soundPlayer.PlayLooping();//循环播放语音
                Console.WriteLine("闹钟响了");
                DialogResult result = MessageBox.Show("闹钟都响了，该起床了！", "闹钟提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); ;
                if (result == DialogResult.Yes)
                {
                    soundPlayer.Stop();
                    this.Close();
                }
                else
                {
                    clockTime.Value = DateTime.Now.AddSeconds(10);//当前时间的10秒后继续闹铃
                    soundPlayer.Stop();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labTxt2.Text = textBox1.Text;
        }
    }
}