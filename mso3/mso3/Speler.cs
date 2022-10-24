using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Speler
    {
        public Spel.spelers speler_nummer;

        public Speler(Spel.spelers Speler)
        {
            speler_nummer = Speler;
        }

        private Kuiltje kies_kuiltje(List<Kuiltje> lijst)
        {
            // TO DO
            Kuiltje keuze = lijst[0];
            return keuze;
        }

        public void speel_zet(Bord bord, Regels regels)
        {
            // TO DO

            // eerste zet 
            List<Kuiltje> mogelijke_kuiltjes = regels.mogelijke_zetten(bord, this);
            Kuiltje gekozen_kuiltje = kies_kuiltje(mogelijke_kuiltjes);
            Kuiltje laatste_kuiltje = regels.strooi_stenen(bord, gekozen_kuiltje, speler_nummer);

            // eigen thuiskuiltje
            if (laatste_kuiltje.soort_kuiltje == Kuiltje.kuil_soort.thuis && laatste_kuiltje.speler_nummer == speler_nummer)
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
