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
using System.Media;
namespace ListBox练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<string> list = new List<string>();//存储文件的全路径
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] str = Directory.GetFiles(@"C:\Users\SpringRain\Desktop\Resources", "*.wav");
            for (int i = 0; i < str.Length; i++)
            {
                //将文件名加载到ListBox中
                listBox1.Items.Add(Path.GetFileName(str[i]));
                //将文件的全路径加载到List泛型集合中
                list.Add(str[i]);
            }
        }


        //双击的时候播放音乐
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = list[listBox1.SelectedIndex];
            sp.Play();
        }
    }
}
