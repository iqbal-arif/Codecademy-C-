using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    internal class Mage : Pupil
    {
        //CONSTRUCTOR
        public Mage(string title) : base(title) { }
        
        //METHOD

        public virtual Storm CastRainStorm()
        {
          return new Storm(Title, "rain", false);
        }
    }
}
