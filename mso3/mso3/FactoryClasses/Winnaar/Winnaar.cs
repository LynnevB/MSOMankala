using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public abstract class Winnaar
    {
        // geeft aan wie heeft gewonnen
        public string winnaar(Bord bord)
        {
            int stenen_p1 = bord.kuiltjes[0].steentjes;
            int stenen_p2 = bord.kuiltjes[(bord.kuiltjes.Count / 2)].steentjes;

            if (speler1_wint(stenen_p1, stenen_p2))
                return ("Speler 1 heeft gewonnen!");
            else if (speler2_wint(stenen_p1, stenen_p2))
                return ("Speler 2 heeft gewonnen!");
            else
                return ("Gelijk spel!");
        }

        public abstract bool speler1_wint(int stenen_p1, int stenen_p2);
        public abstract bool speler2_wint(int stenen_p1, int stenen_p2);
    }
}
