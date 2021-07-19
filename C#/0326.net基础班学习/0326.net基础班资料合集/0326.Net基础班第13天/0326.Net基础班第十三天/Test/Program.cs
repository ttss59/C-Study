using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03访问修饰符;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
        }
    }

    public class T : Student
    {
        public void TT()
        { 
            
        }
    }
}
