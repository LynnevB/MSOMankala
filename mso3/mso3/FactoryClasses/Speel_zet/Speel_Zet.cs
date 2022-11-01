using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public abstract class Speel_Zet
    {
        protected Kuiltje zet_kies_kuiltje(Bord bord, Speler speler)
        {
            Kuiltje gekozen_kuiltje = speler.kies_kuiltje(bord);
            return zet_strooi_stenen(gekozen_kuiltje, bord, speler);
        }

        protected Kuiltje zet_strooi_stenen(Kuiltje kuiltje, Bord bord, Speler speler)
        {
            Kuiltje laatste_kuiltje = Spel.strooi_stenen.strooiStenen(kuiltje, bord, speler.speler_nummer);
            return laatste_kuiltje;
        }

        public bool kuiltje_mogelijk (Kuiltje kuiltje, Speler speler)
        {
            return (kuiltje.speler_nummer == speler.speler_nummer
                    && kuiltje is Kuiltje_Normaal
                    && kuiltje.steentjes > 0);
        }

        public abstract void speel_zet(Bord bord, Speler speler);
    }
}
