﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t = new Ticket(150);
            t.ShowTicket();
            Console.ReadKey();
        }
    }
}
