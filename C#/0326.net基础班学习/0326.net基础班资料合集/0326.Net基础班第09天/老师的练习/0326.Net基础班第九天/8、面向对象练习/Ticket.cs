﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_面向对象练习
{
    public class Ticket
    {
        double _distance;

        public double Distance
        {
            get { return _distance; }
        }
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }

        double _price;

        public double Price
        {
            get
            {
                if (_distance >= 0 && _distance <= 100)
                {
                    return _distance * 1.0;
                }
                else if (_distance >= 101 && _distance <= 200)
                {
                    return _distance * 0.95;
                }
                else if (_distance >= 201 && _distance <= 300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance * 0.8;
                }
            }
        }

        public void ShowTicket()
        {
            Console.WriteLine("{0}公里需要{1}元", this.Distance, this.Price);
        }

    }
}
