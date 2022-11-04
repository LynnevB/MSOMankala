using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public abstract class StrooiStenen
    {
        // kuiltje dat wordt megegeven als current is het gekozen kuiltje dat leeg wordt gehaald
        // daar wordt dus niet een steentje in gegooid
        public Kuiltje strooi_stenen(Kuiltje current, Bord bord, Spel.spelers speler)
        {
            int stenen = current.steentjes;
            current.haal_leeg();

            int index = bord.kuiltjes.IndexOf(current);
            while (stenen > 0)
            {
                index++;
                if (index >= bord.kuiltjes.Count)
                    index = 0;

                current = bord.kuiltjes[index];
                if (moet_steen_in_kuiltje(current, speler))
                {
                    current.gooi_steentje();
                    stenen--;
                }
            }

            return current;
        }

        // bool die true teruggeeft of er een steentje in het kuiltje moet worden gestrooid
        public abstract bool moet_steen_in_kuiltje(Kuiltje current, Spel.spelers speler);

        // bepaald aantal stenen worden gegooid in het thuiskuiltje van de speler
        public void steen_in_thuiskuiltje(int steentjes, Speler speler, Bord bord)
        {
            if (speler.speler_nummer == Spel.spelers.p1)
            {
                // thuiskuiltje speler 1
                bord.kuiltjes[0].steentjes += steentjes;
            }
            else
            {
                // thuiskuiltje speler 2
                int index = bord.kuiltjes.Count / 2;
                bord.kuiltjes[index].steentjes += steentjes;
            }
        }
    }
}
