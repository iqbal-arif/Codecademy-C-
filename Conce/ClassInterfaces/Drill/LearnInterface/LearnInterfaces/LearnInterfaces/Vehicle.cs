using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    internal class Vehicle
    {
        
        
            //PROPERTIES

            public string LicensePlate { get; protected set; }

            public double Speed { get; protected set; }

            public int Wheels { get; protected set; }

        
            public void Honk() { }

            public void SpeedUp(double speed) {  }

            public void SlowDown(double speed) {  }



    }
}
