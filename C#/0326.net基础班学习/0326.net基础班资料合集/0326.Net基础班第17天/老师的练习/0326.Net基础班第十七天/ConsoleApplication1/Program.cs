using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\code.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fsRead.Length];
                int r = fsRead.Read(buffer, 0, buffer.Length);

                string str = System.Text.Encoding.Default.GetString(buffer, 0, r);
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
