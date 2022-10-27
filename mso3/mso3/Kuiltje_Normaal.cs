using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Kuiltje_Normaal : Kuiltje
    {
        public Kuiltje_Normaal(Spel.spelers Speler, int begin_steentjes) : base (Speler)
        {
            steentjes = begin_steentjes;
        }

        public override void haal_leeg()
        {
            steentjes = 0;
        }
    }
}
