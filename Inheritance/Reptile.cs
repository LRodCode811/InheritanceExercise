using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            Age = 8;
            LegCount = 0;
            Habitat = "Land";
        }
        public bool HasScales { get; set; }
        public string Dwelling { get; set; }
        public double Size { get; set; }
        public bool SwallowsRodents { get; set; }
    }
}
