using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class RegelsMankala : Regels
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
            return new StrooiStenenMankala();
        }
        public CheckEindeSpel create_check_einde()
        {
            return new CheckEindeSpel();
        }
        public Winnaar create_winnaar()
        {
            return new WinnaarMeestePunten();
        }
        public override string ToString()
        {
            return "Mankala Regels";
        }
    }
}
