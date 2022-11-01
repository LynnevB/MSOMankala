using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public abstract class Strooi_Stenen
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
                if (steen_in_kuiltje(current, speler))
                {
                    current.gooi_steentje();
                    stenen--;
                }
            }

            return current;
        }

        // bool die true teruggeeft als er een steentje in het kuiltje moet worden gestrooid
        public abstract bool steen_in_kuiltje(Kuiltje current, Spel.spelers speler);
    }
}
