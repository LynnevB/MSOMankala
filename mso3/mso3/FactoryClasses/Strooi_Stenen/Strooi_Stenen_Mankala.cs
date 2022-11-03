using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public class Strooi_Stenen_Mankala : Strooi_Stenen
    {

        public override bool moet_steen_in_kuiltje(Kuiltje current, Spel.spelers speler)
        {
            return !(current is Kuiltje_Thuis && current.speler_nummer != speler);
        }
    }
}
