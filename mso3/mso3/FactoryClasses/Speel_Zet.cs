using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    abstract class Speel_Zet
    {
        public List<Kuiltje> mogelijke_kuiltjes(Bord bord, Speler speler)
        {
            List<Kuiltje> kuiltjes = new List<Kuiltje>();

            foreach (Kuiltje kuil in bord.kuiltjes)
            {
                if (kuil.speler_nummer == speler.speler_nummer
                    && kuil is Kuiltje_Normaal
                    && kuil.steentjes > 0
                   )
                    kuiltjes.Add(kuil);
            }

            return kuiltjes;
        }

        public bool kuiltje_mogelijke (Kuiltje kuiltje, Speler speler)
        {
            return (kuiltje.speler_nummer == speler.speler_nummer
                    && kuiltje is Kuiltje_Normaal
                    && kuiltje.steentjes > 0);
        }
    }
}
