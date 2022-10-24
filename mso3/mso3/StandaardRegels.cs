using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class StandaardRegels : Regels
    {
        public Bord maak_bord()
        {
            Console.WriteLine("Hoeveel kuiltjes wil je per speler?");
            int aantal_kuiltjes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Met hoeveel steentjes moeten de kuiltjes beginnen?");
            int aantal_steentjes = Convert.ToInt32(Console.ReadLine());

            bool thuiskuiltjes = true;

            Bord bord = new Bord(aantal_kuiltjes, aantal_steentjes, thuiskuiltjes);
            return bord;
        }

        public List<Kuiltje> mogelijke_zetten(Bord bord, Speler speler)
        {
            List<Kuiltje> mogelijke_kuiltjes = new List<Kuiltje>();

            foreach(Kuiltje kuil in bord.kuiltjes)
            {
                if (kuil.speler_nummer == speler.speler_nummer
                    && kuil is Kuiltje_Normaal
                    && kuil.steentjes > 0
                   )
                    mogelijke_kuiltjes.Add(kuil);
            }

            return mogelijke_kuiltjes;
        }

        public Kuiltje strooi_stenen(Bord bord, Kuiltje kuiltje, Spel.spelers speler)
        {
            // TO DO
            return kuiltje;
        }

        public bool check_einde_spel(Bord bord)
        {
            // TO DO
            return false;
        }

        public Spel.spelers winnaar(Bord bord)
        {
            // TO DO
            int stenen_p1 = bord.kuiltjes[0].steentjes;
            int stenen_p2 = bord.kuiltjes[bord.kuiltjes_per_speler + 1].steentjes;

            // gelijk spel???
            if (stenen_p1 > stenen_p2)
                return Spel.spelers.p1;
            else
                return Spel.spelers.p2;
        }
    }
}
