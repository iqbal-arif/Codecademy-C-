using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    internal class Pupil
    {
        //PROPERTY - NAME OF THE PUPIL

         public string Title {  get; private set; }

        //CONSTRUCTOR

        public Pupil(string title)
        {
            Title = title;
        }
    }
}
