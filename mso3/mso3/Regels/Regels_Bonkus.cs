﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Regels_Bonkus : Regels
    {
        public Maak_Bord create_maak_bord()
        {
            return new Maak_Bord();
        }
        public Speel_Zet create_speel_zet()
        {
            return new Speel_Zet_Mankala();
        }
        public Strooi_Stenen create_strooi_stenen()
        {
            return new Strooi_Stenen_Wari();
        }
        public Check_Einde_Spel create_check_einde()
        {
            return new Check_Einde_Spel();
        }
        public Winnaar create_winnaar()
        {
            return new Winnaar_Minste_Punten();
        }
        public override string ToString()
        {
            return "Bonkus Regels";
        }
    }
}
