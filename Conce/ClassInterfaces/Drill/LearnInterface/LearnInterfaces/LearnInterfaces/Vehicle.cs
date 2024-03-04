using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    abstract class Vehicle
    {
        
        
            //PROPERTIES

            public string LicensePlate { get; protected set; }

            public double Speed { get; protected set; }

            public int Wheels { get; protected set; }

        
            public void Honk() { Console.WriteLine("Vehicle Honk!!!"); }

            public virtual void SpeedUp() 
            { 
            Speed += 5;
            Console.WriteLine("Vehicle S-UP " + Speed);

        }

        public virtual void SlowDown() 
        {
            Speed -= 5;
            Console.WriteLine("Vehicle S-DOWN " + Speed);
            
        }

            //CONSTRUCTOR

            public Vehicle(double speed)
            {
            
            }

        //METHOD
        public abstract string Describe();

            

    }
}
