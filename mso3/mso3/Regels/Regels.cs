using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    interface Regels
    {
        Maak_Bord create_maak_bord();
        Speel_Zet create_speel_zet();
        Strooi_Stenen create_strooi_stenen();
        Check_Einde_Spel create_check_einde();
        Winnaar create_winnaar();
    }
}
