using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Winnaar_Mankala : Winnaar
    {
        public override void winnaar(Bord bord)
        {
            int stenen_p1 = bord.kuiltjes[0].steentjes;
            int stenen_p2 = bord.kuiltjes[(bord.kuiltjes.Count / 2)].steentjes;

            if (stenen_p1 > stenen_p2)
                Console.WriteLine("Speler 1 heeft gewonnen!");
            else if (stenen_p2 > stenen_p1)
                Console.WriteLine("Speler 2 heeft gewonnen!");
            else
                Console.WriteLine("Gelijk spel!");
        }
    }
}
