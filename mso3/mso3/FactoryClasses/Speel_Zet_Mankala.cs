using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Speel_Zet_Mankala : Speel_Zet
    {
        public void speel_zet(Bord bord, Speler speler)
        {
            // eerste zet
            Kuiltje laatste_kuiltje = zet_kies_kuiltje(bord, speler);

            // eigen thuiskuiltje
            if (laatste_kuiltje is Kuiltje_Thuis && laatste_kuiltje.speler_nummer == speler.speler_nummer)
                laatste_kuiltje = zet_kies_kuiltje(bord, speler);

            // niet leeg kuiltje -> pak deze stenen en ga verder 
            else if (laatste_kuiltje.steentjes > 0)
                zet_strooi_stenen(laatste_kuiltje, bord, speler);

            else
            {
                // leeg kuiltje speler + tegenover niet leeg -> pak laatste gestrooide steen en tegenover kuiltje voeg toe aan thuiskuiltje zet over

                // leeg kuiltje andere speler -> volgende aan de beurt

                // leeg kuiltje speler + tegenover is leeg -> volgende aan de beurt
            }
        }
    }
}
