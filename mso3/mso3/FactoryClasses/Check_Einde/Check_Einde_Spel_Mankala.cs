using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Check_Einde_Spel_Mankala : Check_Einde_Spel
    {
        public override bool check_einde(Bord bord, Speler speler)
        {
            foreach(Kuiltje kuil in bord.kuiltjes)
            {
                if (Spel.speel_zet.kuiltje_mogelijk(kuil, speler))
                    return false;
            }
            return true;
        }
    }
}
