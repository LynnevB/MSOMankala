using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public abstract class Speel_Zet
    {
        // laat de speler een van de mogelijke kuiltjes kiezen
        protected Kuiltje zet_kies_kuiltje(Bord bord, Speler speler)
        {
            Kuiltje gekozen_kuiltje = speler.kies_kuiltje(bord);
            return Spel.strooi_stenen.strooi_stenen(gekozen_kuiltje, bord, speler.speler_nummer);
        }

        // geeft aan of de speler het kuiltje kan kiezen
        // om vervolgens hiervan de stenen te strooien
        public bool kuiltje_mogelijk (Kuiltje kuiltje, Speler speler)
        {
            return (kuiltje.speler_nummer == speler.speler_nummer
                    && kuiltje is Kuiltje_Normaal
                    && kuiltje.steentjes > 0);
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
