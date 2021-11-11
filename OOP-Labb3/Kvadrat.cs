using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3
{
    class Kvadrat : Teckning
    {
        public double bas { get; set; }

        public Kvadrat()
        {
            bas = 4;
        }
        public override double Area()
        {
            return bas * bas;
        }
    }
}
