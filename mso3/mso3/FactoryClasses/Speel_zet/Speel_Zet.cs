using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public abstract class Speel_Zet
    {
        protected Kuiltje zet_kies_kuiltje(Bord bord, Speler speler)
        {
            Kuiltje gekozen_kuiltje = speler.kies_kuiltje(bord);
            return Spel.strooi_stenen.strooi_stenen(gekozen_kuiltje, bord, speler.speler_nummer);
        }

        public bool kuiltje_mogelijk (Kuiltje kuiltje, Speler speler)
        {
            return (kuiltje.speler_nummer == speler.speler_nummer
                    && kuiltje is Kuiltje_Normaal
                    && kuiltje.steentjes > 0);
        }

        // stenen worden gegooid in het thuiskuiltje van de speler
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

        public void print_tekst(string tekst)
        {
            Console.WriteLine(tekst);
            Console.WriteLine("(Klik op enter om verder te gaan)");
            Console.ReadLine();
        }

        // loop van de zet van een speler totdat de beurt voorbij is
        public abstract void speel_zet(Bord bord, Speler speler);
    }
}
