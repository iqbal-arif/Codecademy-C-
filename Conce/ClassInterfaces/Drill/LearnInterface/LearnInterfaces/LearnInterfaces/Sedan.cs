using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces


{   //The below code means that Sedan will inherit all the functionality of the Vehicle class, and it “promises” to implement all the functionality in the IAutomobile interface.


    internal class Sedan : Vehicle, IAutomobile
    {

        public string LicensePlate { get;}

        public int Wheels { get; }

        public double Speed { get; private set; }

        //METHOD
        /*
        public void Honk()
        {
            Console.WriteLine("Sedan Honk");
        }
        */
        public void SpeedUp()
        {
           Speed += 5;
            Console.WriteLine(Speed);
        }

        public void SlowDown()
        {
            Speed -= 5;
        }

        public override string Describe()
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

        //COSNTRUCTOR
        public Sedan(double speed) : base(speed)
        {
            /*
            Speed = speed;

            LicensePlate = Tools.GenerateLicensePlate();
            */
            Wheels = 4;
        }



    }
}
