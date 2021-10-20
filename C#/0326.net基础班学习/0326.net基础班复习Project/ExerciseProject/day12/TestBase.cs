using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    internal class TestBase
    {
        public void Show()
        {
            //TC test01 = new TC(); //别名无法跨越类文件，TC仅仅在定义的类中可以使用
            TestClass testClass = new TestClass();
            TestClass2 testClass2 = new TestClass2();
        }
    }
}