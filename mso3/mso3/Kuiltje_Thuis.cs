using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Kuiltje_Thuis : Kuiltje
    {
        public Kuiltje_Thuis(Spel.spelers Speler) : base(Speler)
        {
            steentjes = 0;
        }
    }
}
