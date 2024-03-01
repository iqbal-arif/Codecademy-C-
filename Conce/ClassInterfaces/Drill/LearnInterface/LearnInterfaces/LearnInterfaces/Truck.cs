using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    internal class Truck : IAutomobile
    {
        public string LicensePlate { get; }

        public int Wheels { get; }

        public double Speed { get; private set; }

        public double Weight { get;}

        //METHOD
        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }

        //CONSTRUCTOR

        public Truck(double speed, double weight)
        {
            Speed = speed;

            Weight = weight;

            LicensePlate = Tools.GenerateLicensePlate();

            if (weight < 400) Wheels = 8;
            else Wheels = 12;

        }
    }
}
