using System;
using System.Collections.Generic;

namespace mso3
{
    class Speler
    {
        public Spel.spelers speler_nummer;
        public bool eindig_spel;

        public Speler(Spel.spelers Speler)
        {
            speler_nummer = Speler;
            eindig_spel = false;
        }

        List<int> print_mogelijke_kuiltjes(Bord bord)
        {
            List<int> mogelijke_kuiltjes = new List<int>();

            Console.WriteLine(speler_nummer + ", kies uit de volgende kuiltjes: ");
            for (int i = 0; i < bord.kuiltjes.Count; i++)
            {
                Kuiltje kuil = bord.kuiltjes[i];
                if (Spel.speel_zet.kuiltje_mogelijk(kuil, this))
                {
                    Console.WriteLine("Kuiltje " + i);
                    mogelijke_kuiltjes.Add(i);
                }
            }

            return mogelijke_kuiltjes;
        }

        public Kuiltje kies_kuiltje(Bord bord)
        {
            List<int> mogelijke_kuiltjes = print_mogelijke_kuiltjes(bord);
            int kuiltje_index = Convert.ToInt32(Console.ReadLine());

            while (!mogelijke_kuiltjes.Contains(kuiltje_index))
            {
                Console.WriteLine("Kies een van de mogelijke kuiljes");
                kuiltje_index = Convert.ToInt32(Console.ReadLine());
            }

            return bord.kuiltjes[kuiltje_index];
        }

    }
}
