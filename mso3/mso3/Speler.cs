using System;

namespace mso3
{
    class Speler
    {
        public Spel.spelers speler_nummer;
        Regels regels;

        public Speler(Spel.spelers Speler)
        {
            speler_nummer = Speler;
            regels = Spel.regels;
        }

        public Kuiltje kies_kuiltje(Bord bord)
        {
            
            Console.WriteLine("Kies uit de volgende kuiltjes: ");
            for(int i = 0; i < bord.kuiltjes.Count; i++)
            {
                //if (regels.)
                //Console.WriteLine("Kuiltje", );
            }

            return bord.kuiltjes[1];
        }

        public void speel_zet(Bord bord)
        {
            // TO DO
        }
    }
}
