using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public class Maak_Bord
    {
        public Bord maakBord()
        {
            Console.WriteLine("Hoeveel kuiltjes wil je per speler?");
            int aantal_kuiltjes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Met hoeveel steentjes moeten de kuiltjes beginnen?");
            int aantal_steentjes = Convert.ToInt32(Console.ReadLine());

            bool thuiskuiltjes = true;

            return new Bord(aantal_kuiltjes, aantal_steentjes, thuiskuiltjes);
        }
    }
}
