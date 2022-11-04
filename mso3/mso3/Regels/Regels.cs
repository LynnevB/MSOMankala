using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    interface Regels
    {
        MaakBord create_maak_bord();
        SpeelZet create_speel_zet();
        StrooiStenen create_strooi_stenen();
        CheckEindeSpel create_check_einde();
        Winnaar create_winnaar();
    }
}
