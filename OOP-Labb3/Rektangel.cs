using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3
{
    class Rektangel : Teckning
    {
        double höjd { get; set; }
        double bas { get; set; }

        public Rektangel()
        {
            bas=4;
            höjd=5;
        }
        public override double Area()
        {
            return bas * höjd;
        }
    }
}
