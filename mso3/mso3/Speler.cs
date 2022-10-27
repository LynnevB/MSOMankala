using System;

namespace mso3
{
    class Speler
    {
        public Spel.spelers speler_nummer;
        Regels regels;

        public Speler(Spel.spelers Speler, Regels regel)
        {
            speler_nummer = Speler;
            regels = regel;
        }

        public Kuiltje kies_kuiltje(Bord bord)
        {
            
            Console.WriteLine("Kies uit de volgende kuiltjes: ");
            for(int i = 0; i < bord.kuiltjes.Count; i++)
            {
                //if (regels.)
                //Console.WriteLine("Kuiltje", );
            }

            return bord.kuiltjes[1];
        }

        public void speel_zet(Bord bord)
        {
            // TO DO

            // eerste zet 
            Kuiltje gekozen_kuiltje = kies_kuiltje(bord);
            Kuiltje laatste_kuiltje = regels.create_strooi_stenen().strooiStenen(gekozen_kuiltje, bord, speler_nummer);

            // eigen thuiskuiltje
            if (laatste_kuiltje is Kuiltje_Thuis && laatste_kuiltje.speler_nummer == speler_nummer)
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
