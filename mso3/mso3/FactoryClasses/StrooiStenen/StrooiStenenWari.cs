using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class StrooiStenenWari : StrooiStenen
    {
        public override bool moet_steen_in_kuiltje(Kuiltje current, Spel.spelers speler)
        {
            return !(current is Kuiltje_Thuis);
        }
    }
}
