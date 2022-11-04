using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public class WinnaarMeestePunten : Winnaar
    {
        public override bool speler1_wint(int stenen_p1, int stenen_p2)
        {
            return (stenen_p1 > stenen_p2);
        }

        public override bool speler2_wint(int stenen_p1, int stenen_p2)
        {
            return (stenen_p2 > stenen_p1);
        }
    }
}
