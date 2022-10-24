using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    abstract class Kuiltje
    {
        public int steentjes;
        public Spel.spelers speler_nummer;

        public Kuiltje(Spel.spelers Speler)
        {
            speler_nummer = Speler;
        }

        public void gooi_steentje()
        {
            steentjes++;
        }
    }
}
