using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Speel_Zet_Mankala : Speel_Zet
    {
        public void speel_zet(Bord bord, Speler speler)
        {
            // TO DO

            // eerste zet 
            Kuiltje gekozen_kuiltje = speler.kies_kuiltje(bord);
            Kuiltje laatste_kuiltje = bord.regels.create_strooi_stenen().strooiStenen(gekozen_kuiltje, bord, speler.speler_nummer);

            // eigen thuiskuiltje
            if (laatste_kuiltje is Kuiltje_Thuis && laatste_kuiltje.speler_nummer == speler.speler_nummer)
                ;

            // niet leeg kuiltje -> pak deze stenen en ga verder 
            else if (laatste_kuiltje.steentjes > 0)
                ;

            else
            {
                // leeg kuiltje speler + tegenover niet leeg -> pak laatste gestrooide steen en tegenover kuiltje voeg toe aan thuiskuiltje zet over

                // leeg kuiltje andere speler -> volgende aan de beurt

                // leeg kuiltje speler + tegenover is leeg -> volgende aan de beurt
            }
        }
    }
}
