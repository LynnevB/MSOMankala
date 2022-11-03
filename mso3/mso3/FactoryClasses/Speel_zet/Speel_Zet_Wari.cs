using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Speel_Zet_Wari : Speel_Zet
    {
        // loop van de zet van een speler totdat de beurt voorbij is
        public override void speel_zet(Bord bord, Speler speler)
        {
            // eerste zet
            bord.print_bord();
            Kuiltje laatste_kuiltje = zet_kies_kuiltje(bord, speler);

            // uitkomst
            bord.print_bord();
            int steentjes = laatste_kuiltje.steentjes;
            if ((steentjes == 2 || steentjes == 3) && laatste_kuiltje.speler_nummer != speler.speler_nummer)
            {
                laatste_kuiltje.haal_leeg();
                Spel.strooi_stenen.steen_in_thuiskuiltje(steentjes, speler, bord);

                print_tekst("De steentjes uit kuiltje " + bord.kuiltjes.IndexOf(laatste_kuiltje) + " en stop ze bij hun buit");
                bord.print_bord();
            }

            print_tekst(speler.speler_nummer + ", jouw beurt is over.");
        }
    }
}
