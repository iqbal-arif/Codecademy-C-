﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStatic
{
    internal class Forest
    {
        // FIELDS

        public int age;
        private string biome;
        private static int forestsCreated;
        private static string treeFacts;

        // CONSTRUCTORS

        public Forest(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            Age = 0;
            ForestsCreated += 1;
        }

        public Forest(string name) : this(name, "Unknown")
        { }

        static Forest()
        {
            treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
            ForestsCreated = 0;
        }

        // PROPERTIES

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public static int ForestsCreated { get; private set; }

        public static string TreeFacts { get; }

        // METHODS

        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

        public static void PrintTreeFacts()
        {
            Console.WriteLine(TreeFacts);
        }

    }
}
