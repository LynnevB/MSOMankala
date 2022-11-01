using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Strooi_Stenen_Wari : Strooi_Stenen
    {
        public override bool steen_in_kuiltje(Kuiltje current, Spel.spelers speler)
        {
            return !(current is Kuiltje_Thuis);
        }
    }
}
