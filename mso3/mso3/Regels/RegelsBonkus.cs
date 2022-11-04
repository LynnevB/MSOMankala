using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class RegelsBonkus : Regels
    {
        public MaakBord create_maak_bord()
        {
            return new MaakBord();
        }
        public SpeelZet create_speel_zet()
        {
            return new SpeelZetMankala();
        }
        public StrooiStenen create_strooi_stenen()
        {
            return new StrooiStenenWari();
        }
        public CheckEindeSpel create_check_einde()
        {
            return new CheckEindeSpel();
        }
        public Winnaar create_winnaar()
        {
            return new WinnaarMinstePunten();
        }
        public override string ToString()
        {
            return "Bonkus Regels";
        }
    }
}
