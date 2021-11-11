using System;
using System.Collections.Generic;

namespace OOP_Labb3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrat kvadrat = new Kvadrat();
            Rektangel rektangel = new Rektangel();
            Cirkel cirkel = new Cirkel();

            Console.WriteLine("Area Kvadrat: " + kvadrat.Area());
            Console.WriteLine("Area Rektangel: " + rektangel.Area());
            Console.WriteLine("Cirkel: "+ cirkel.Area());
            Console.ReadKey();
        }
    }
}
