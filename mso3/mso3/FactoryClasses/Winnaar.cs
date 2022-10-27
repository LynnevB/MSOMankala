using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    abstract class Winnaar
    {
        public Spel.spelers winnaar(Bord bord)
        {
            // TO DO
            int stenen_p1 = bord.kuiltjes[0].steentjes;
            int stenen_p2 = bord.kuiltjes[(bord.kuiltjes.Count / 2) + 1].steentjes;

            // gelijk spel???
            if (stenen_p1 > stenen_p2)
                return Spel.spelers.p1;
            else
                return Spel.spelers.p2;
        }
    }
}
