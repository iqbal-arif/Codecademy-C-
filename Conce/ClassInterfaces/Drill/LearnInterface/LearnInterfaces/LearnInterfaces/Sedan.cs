using System;
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

        public double Speed { get;}


        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        public Sedan(double speed)
        {
            Speed = speed;

            Random randomPlate = new Random();
            double LicesePlate = randomPlate.NextDouble();

            Wheels = 4;
        }

    }
}
