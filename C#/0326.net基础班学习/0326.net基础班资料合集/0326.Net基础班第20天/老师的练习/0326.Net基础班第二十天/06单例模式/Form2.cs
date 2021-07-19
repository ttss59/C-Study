using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06单例模式
{
    public partial class Form2 : Form
    {
        private Form2()
        {
            InitializeComponent();
        }
        //2、创建一个单例
        private static Form2 _frmSingle = null;

        public static Form2 FrmSingle
        {
            get { return Form2._frmSingle; }
            set { Form2._frmSingle = value; }
        }
        //1、提供一个方法来返回一个对象
        //静态方法  实例方法
        public static Form2 GetSingle()
        {
            if (_frmSingle == null)
            {
               _frmSingle= new Form2();
            }
            //我们就返回一个对象
            return _frmSingle;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
