using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    internal class IAutomobile
    {
        interface IAutomobile 
        {
            string LicensePlate { get; }

            double Speed { get; }

            int Wheels { get; }

            void Honk();
        }
    }
}
