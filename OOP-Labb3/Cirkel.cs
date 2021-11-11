using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3
{
    class Cirkel : Teckning
    {
        double radie { get; set; }
        public Cirkel()
        {
            radie = 2;
        }
        public override double Area()
        {
            return radie * radie * Math.PI;
        }

    }
}
