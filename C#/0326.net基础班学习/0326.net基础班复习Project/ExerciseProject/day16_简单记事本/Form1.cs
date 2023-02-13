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

namespace day16_简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.WordWrap = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private Dictionary<string, string> openPathDic = new Dictionary<string, string>();

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "选择需要打开的文档";
            fileDialog.InitialDirectory = @"D:\Desktop";//默认桌面地址
            fileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            fileDialog.ShowDialog();
            string path = fileDialog.FileName;//获取选择的文件路径
            if (string.IsNullOrEmpty(path)) return;//如果没有选择任何文件，则直接返回
            string fileName = Path.GetFileNameWithoutExtension(path);
            if (!openPathDic.ContainsKey(fileName))
            {
                listBox1.Items.Add(fileName);
                openPathDic.Add(fileName, path);
            }
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                int count = fs.Read(buffer, 0, buffer.Length);
                textBox1.Text = System.Text.Encoding.UTF8.GetString(buffer, 0, count);
            }
            this.Text = fileName;
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "请选择文件的保存路径";
            saveFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            saveFileDialog.InitialDirectory = @"D:\Desktop";
            saveFileDialog.ShowDialog();
            string path = saveFileDialog.FileName;
            if (string.IsNullOrEmpty(path)) return;
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(textBox1.Text);
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Text == "自动换行")
            {
                textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "取消自动换行";
            }
            else if (自动换行ToolStripMenuItem.Text == "取消自动换行")
            {
                textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "自动换行";
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            textBox1.Font = fontDialog.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            textBox1.ForeColor = colorDialog.Color;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string fileName = listBox1.SelectedItem.ToString();
            if (!openPathDic.ContainsKey(fileName)) return;
            string path = openPathDic[fileName];
            if (!File.Exists(path)) return;//不存在该文件则返回
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                int count = fs.Read(buffer, 0, buffer.Length);
                textBox1.Text = System.Text.Encoding.UTF8.GetString(buffer, 0, count);
            }
            panel1.Visible = false;
        }
    }
}