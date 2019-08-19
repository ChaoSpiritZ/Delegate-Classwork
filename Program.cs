﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Car aCar = new Car();
            aCar.OnSpeeding += p.Speeding;
            aCar.OnStop += p.Stopped;
            aCar.OnDriving += p.Driving;
            aCar.OnDriving += p.Driving2;

            aCar.CurrentSpeed = 0;
            aCar.CurrentSpeed = 100;
            aCar.CurrentSpeed = 120;
            aCar.CurrentSpeed = 130;
            aCar.CurrentSpeed = 140;
            aCar.CurrentSpeed = -13;
        }

        public void Speeding()
        {
            Console.WriteLine("YOU ARE SPEEDING!");
        }

        public void Stopped()
        {
            Console.WriteLine("The car stopped.");
        }

        public void Driving(int currentSpeed)
        {
            Console.WriteLine("You are driving at a speed of: " + currentSpeed);
        }

        public void Driving2(int currentSpeed)
        {
            Console.WriteLine("also hi");
        }
    }
}
