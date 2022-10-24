using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    interface Regels
    {
        Bord maak_bord();
        List<Kuiltje> mogelijke_zetten(Bord bord, Speler speler);
        Kuiltje strooi_stenen(Bord bord, Kuiltje kuiltje, Spel.spelers speler);
        bool check_einde_spel(Bord bord);
        Spel.spelers winnaar(Bord bord);
    }
}
