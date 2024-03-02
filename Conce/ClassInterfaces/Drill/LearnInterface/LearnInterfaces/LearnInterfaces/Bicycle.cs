﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    internal class Bicycle : Vehicle
    {

        public Bicycle(double speed) : base(speed)
        {
            Speed = speed;

            Wheels = 2;
        }

        public override void SpeedUp()
        {
            Speed += 5;

            if (Speed > 15) { Speed = 15; } 
        }

        public override void SlowDown()
        {
            Speed -= 5;

            if (Speed < 0) {  Speed = 0; }
        }

    }

   
}
