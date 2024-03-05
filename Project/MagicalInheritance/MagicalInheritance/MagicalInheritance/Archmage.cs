using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    internal class Archmage : Mage
    {
        
        
            //CONSTRUCTOR
            public Archmage(string title) : base(title) { }

            //METHOD

            public override Storm CastRainStorm()
            {
                return new Storm(Title, "rain", true);
            }            
        
            
            public Storm CastLightningStorm()
            {
                return new Storm(Title, "lightning", true);
            }

        
    }
}
