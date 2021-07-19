using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 播放器项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //musicPlayer.URL = @"F:\老赵生活\music\1.mp3";
            //首先取消播放器的自动播放功能 在赋值给一首音乐的路径
            musicPlayer.settings.autoStart = false;


            lblMute.Image = Image.FromFile(@"C:\Users\SpringRain\Desktop\播放.jpg");
        }


        /// <summary>
        /// 播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.play();
        }


        /// <summary>
        /// 暂停音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();
        }

        /// <summary>
        /// 停止音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }
        bool b = true;
        private void btnPlayerOrPause_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count == 0)
            {
                return;
            }
            if (btnPlayerOrPause.Text == "播放")
            {
                if (b)
                {
                    int index = listBox1.SelectedIndex;
                    musicPlayer.URL = list[index];
                }
                musicPlayer.Ctlcontrols.play();
                btnPlayerOrPause.Text = "暂停";
            }
            else if (btnPlayerOrPause.Text == "暂停")
            {
                musicPlayer.Ctlcontrols.pause();
                btnPlayerOrPause.Text = "播放";
                b = false;
            }
        }
        //存储选中文件的全路径
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"F:\老赵生活\music";
            ofd.Filter = "音乐文件|*.mp3|歌词文件|*.lrc|所有文件|*.*";
            ofd.Multiselect = true;
            ofd.Title = "请选择要播放的音乐文件哟亲思密达~~~";
            ofd.ShowDialog();
            //获得在对话款中选择的文件
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将文件的名称加载到ListBox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
                //将文件的全路径存储到List泛型集合中
                list.Add(path[i]);
            }
        }


        /// <summary>
        /// 双击播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                return;
            }
            musicPlayer.URL = list[listBox1.SelectedIndex];
            musicPlayer.Ctlcontrols.play();
            IsExistLrc(list[listBox1.SelectedIndex]);
        }



        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //获得当前选中歌曲的下标
            int index = listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            //将改变后的索引的值 重新赋值给ListBox的选中项的索引
            listBox1.SelectedIndex = index;

            musicPlayer.URL = list[index];
            musicPlayer.Ctlcontrols.play();
        }


        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            //清空当前所有选中项的索引
            listBox1.SelectedIndices.Clear();
            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            listBox1.SelectedIndex = index;
            musicPlayer.URL = list[index];
            musicPlayer.Ctlcontrols.play();
        }


        /// <summary>
        /// 增加音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume += 5;
            // MessageBox.Show(musicPlayer.settings.volume.ToString());
        }


        /// <summary>
        /// 减少音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume -= 5;
        }



        /// <summary>
        /// 静音或者放音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMute_Click(object sender, EventArgs e)
        {
            if (lblMute.Tag.ToString() == "1")
            {
                //表示静音
                musicPlayer.settings.mute = true;
                lblMute.Image = Image.FromFile(@"C:\Users\SpringRain\Desktop\暂停.jpg");
                lblMute.Tag = "2";
            }
            else if (lblMute.Tag.ToString() == "2")
            {
                //表示放音
                musicPlayer.settings.mute = false;
                lblMute.Image = Image.FromFile(@"C:\Users\SpringRain\Desktop\播放.jpg");
                lblMute.Tag = "1";
            }
        }



        /// <summary>
        /// 全选删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过选中项的下标去删

            //获得选中项的个数
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //删除
                //ListBox  List 先删谁？
                //先删除集合
                list.RemoveAt(listBox1.SelectedIndex);
                //再删除ListBox
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //   lblInfomation.Text = musicPlayer.currentMedia.duration.ToString() + "\r\n" + musicPlayer.currentMedia.durationString + "\r\n" + musicPlayer.Ctlcontrols.currentPosition.ToString() + "\r\n" + musicPlayer.Ctlcontrols.currentPositionString;
        }


        /// <summary>
        /// 当播放状态发生改变的时候 触发这个事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //  MessageBox.Show(musicPlayer.playState.ToString());


            //如果当前播放器的状态时MediaEnded 我们进行下一曲
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                int index = listBox1.SelectedIndex;
                listBox1.SelectedIndices.Clear();
                index++;
                if (index == listBox1.Items.Count)
                {
                    index = 0;
                }
                listBox1.SelectedIndex = index;
                musicPlayer.URL = list[index];

            }

            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                try
                {
                    musicPlayer.Ctlcontrols.play();
                }
                catch
                {

                }
            }
        }


        void IsExistLrc(string songPath)
        {
            songPath += ".lrc";
            //如果歌词存在
            if (File.Exists(songPath))
            {
                string[] lrcText = File.ReadAllLines(songPath, Encoding.Default);
                FormatLrc(lrcText);
            }
            else//歌词不存在
            {
                lblLrc.Text = "-------歌词为找到---------";
            }
        }

        List<double> listTime = new List<double>();//存储时间
        List<string> listLrc = new List<string>();//存储歌词
        //[00:15.57]当我和世界不一样  15.57
        void FormatLrc(string[] lrcText)
        {
            for (int i = 0; i < lrcText.Length; i++)
            {
                string[] temp = lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

                string[] newTemp = temp[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //01
                double time = double.Parse(newTemp[0]) * 60 + double.Parse( newTemp[1]);
                listTime.Add(time);

                listLrc.Add(temp[1]);
            }
        }
        //播放歌词
        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listTime.Count; i++)
            {
                if (musicPlayer.Ctlcontrols.currentPosition >= listTime[i] && musicPlayer.Ctlcontrols.currentPosition <= listTime[i + 1])
                {
                    lblLrc.Text = listLrc[i];
                }
            }
        }

    }
}
