using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{

    //INTERFACE Cannot Specify
    //Constructors
    //Fields

    interface IAutomobile
    {
        string LicensePlate { get; }

        double Speed { get; }

        int Wheels { get; }

        void Honk();
    }
}
