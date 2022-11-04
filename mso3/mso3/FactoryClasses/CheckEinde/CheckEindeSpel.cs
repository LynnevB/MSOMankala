using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public class CheckEindeSpel
    {
        // is true als het spel is geeindigd
        public bool check_einde(Bord bord, Speler speler)
        {
            foreach (Kuiltje kuil in bord.kuiltjes)
            {
                if (Spel.speel_zet.kuiltje_mogelijk(kuil, speler))
                    return false;
            }
            return true;
        }
    }
}
