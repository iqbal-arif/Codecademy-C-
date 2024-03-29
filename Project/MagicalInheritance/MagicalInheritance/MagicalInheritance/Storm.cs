﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    internal class Storm
    {
        //AUTOMATIC PROPERTIES

        public string Essence { get; private set; }

        public bool IsStrong { get; private set; }

        public string Caster { get; private set; }

        //CONSTRUCTOR

        public Storm(string caster, string essence, bool isStrong)
        {
            IsStrong = isStrong;

            Caster = caster;

            Essence = essence;
        }

        //METHOD

        public string Announce()
        {
            if(IsStrong)
            {
                return $"{Caster} cast a strong {Essence} storm!";
            }
            else 
            { 
                return $"{Caster} cast a weak {Essence} storm!";
            }
        }


    }
}
