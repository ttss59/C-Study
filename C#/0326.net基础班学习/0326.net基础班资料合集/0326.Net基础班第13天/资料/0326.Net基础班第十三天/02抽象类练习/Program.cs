using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用多态的思想来模拟将U盘、移动硬盘、mp3插到电脑上读写数据
            //U盘和移动硬盘都有一个Read()  Write()
            //MP3除了Read() Write()之外，自己本身还可以播放音乐
            //父类 移动设备

            UDisk uDisk = new UDisk();
            MobileDisk md = new MobileDisk();
            MP3 mp3 = new MP3();

            Computer cpu = new Computer();
            cpu.MS = mp3;
            cpu.CPURead();
            cpu.CPUWrite();
            //cpu.CPUWrite(uDisk);
            //cpu.CPURead(uDisk);
            //cpu.CPURead(mp3);
            //cpu.CPUWrite(mp3);
            mp3.PlayMusic();
            Console.ReadKey();

        }
    }


    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }


    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }


    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("Mp3在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3在写入数据");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Mp3在播放音乐");
        }
    }


    public class Computer
    { 
        //获得插到电脑上的移动存储设备


        public MobileStorage MS
        {
            get;
            set;
        }

        /// <summary>
        ///  电脑需要调用插到电脑上的移动设备的读取数据的方法
        /// </summary>
        public void CPURead()
        {
            this.MS.Read();
        }

        public void CPUWrite()
        {
            this.MS.Write();
        }


    }
}
