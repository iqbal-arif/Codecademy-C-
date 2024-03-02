using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    internal class Truck : Vehicle, IAutomobile
    {
        public double Weight { get;}
        /*
         public string LicensePlate { get; }

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
         */

        public override string Describe()
        {
            return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }



        //CONSTRUCTOR

        public Truck(double speed, double weight) : base(speed)
        {
            /*
            Speed = speed;

            LicensePlate = Tools.GenerateLicensePlate();
            */
            Weight = weight;

            if (weight < 400) Wheels = 8;
            else Wheels = 12;

        }
    }
}
