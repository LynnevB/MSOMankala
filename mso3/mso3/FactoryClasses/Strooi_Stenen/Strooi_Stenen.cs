using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    abstract class Strooi_Stenen
    {
        bool thuiskuiltjes;
        public Strooi_Stenen(bool thuisKuiltjes)
        {
            thuiskuiltjes = thuisKuiltjes;
        }

        // kuiltje dat wordt megegeven als current is het gekozen kuiltje dat leeg wordt gehaald
        // daar wordt dus niet een steentje in gegooid
        public Kuiltje strooiStenen(Kuiltje current, Bord bord, Spel.spelers speler)
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
                if (!(current is Kuiltje_Thuis && !(thuiskuiltjes && current.speler_nummer == speler)))
                {
                    current.gooi_steentje();
                    stenen--;
                }
            }

            return current;
        }
    }
}
