﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    internal class Sedan : IAutomobile
    {

        public string LicensePlate { get;}

        public int Wheels { get; }

        public double Speed { get; private set; }

        //METHOD
        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        public void SpeedUp()
        {
           Speed += 5;
            Console.WriteLine(Speed);
        }

        public void SlowDown()
        {
            Speed -= 5;
        }

        //COSNTRUCTOR
        public Sedan(double speed)
        {
            Speed = speed;

            LicensePlate = Tools.GenerateLicensePlate();

            Wheels = 4;
        }



    }
}
