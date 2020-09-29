using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
            {
            IsAlive = true;
            Age = 5;
            LegCount = 2;
            Habitat = "Mountains";
            }
    public bool CanFly { get; set; }
    public int Talons { get; set; }
    public double WingSpan { get; set; }
    public string Color { get; set; }
    }
}
