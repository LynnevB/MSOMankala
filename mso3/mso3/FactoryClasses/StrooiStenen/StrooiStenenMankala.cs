using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public class StrooiStenenMankala : StrooiStenen
    {

        public override bool moet_steen_in_kuiltje(Kuiltje current, Spel.spelers speler)
        {
            return !(current is Kuiltje_Thuis && current.speler_nummer != speler);
        }
    }
}
