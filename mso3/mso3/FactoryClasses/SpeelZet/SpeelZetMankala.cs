using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public class SpeelZetMankala : SpeelZet
    {
        // pakt het laatste gestrooide steentje EN de steentjes in het kuiltje tegenover
        // deze stenen worden in het thuiskuiltje gegooid van de speler die aan de beurt is
        public void zet_tegenover_kuiltje(Kuiltje laatste_kuiltje, Bord bord, Speler speler)
        {
            Kuiltje tegenover = bord.tegenover_kuiltje(laatste_kuiltje);
            int steentjes = 1 + tegenover.steentjes;

            laatste_kuiltje.haal_leeg();
            tegenover.haal_leeg();

            Spel.strooi_stenen.steen_in_thuiskuiltje(steentjes, speler, bord);
        }

        // loop van de zet van een speler totdat de beurt voorbij is
        public override void speel_zet(Bord bord, Speler speler)
        {
            // eerste zet
            bord.print_bord();
            bool volgende_beurt = false;
            Kuiltje laatste_kuiltje = zet_kies_kuiltje(bord, speler);

            while (!volgende_beurt)
            {
                bord.print_bord();

                // laatste steen in eigen thuiskuiltje
                if (laatste_kuiltje is Kuiltje_Thuis && laatste_kuiltje.speler_nummer == speler.speler_nummer)
                {
                    if (Spel.check_einde_spel.check_einde(bord, speler))
                    {
                        speler.eindig_spel = true;
                        return;
                    }
                    laatste_kuiltje = zet_kies_kuiltje(bord, speler);
                }

                // laatste steen in een niet leeg kuiltje -> pak deze stenen en ga verder 
                else if (laatste_kuiltje.steentjes > 1)
                {
                    print_tekst(speler.speler_nummer + " pakt de steentjes van kuiltje " + bord.kuiltjes.IndexOf(laatste_kuiltje));
                    laatste_kuiltje = Spel.strooi_stenen.strooi_stenen(laatste_kuiltje, bord, speler.speler_nummer);
                }

                else
                {
                    // laatste steen in een leeg kuiltje van de speler && tegenover niet leeg
                    // -> pak laatste gestrooide steen en de stenen in het tegenover kuiltje en voeg ze toe aan thuiskuiltje
                    // -> zet over
                    if (bord.tegenover_kuiltje(laatste_kuiltje).steentjes > 0 && laatste_kuiltje.speler_nummer == speler.speler_nummer)
                    {
                        print_tekst(speler.speler_nummer + " pakt het laatste steentje en de steentjes aan de overkant en gooit ze in hun thuiskuiltje.");
                        zet_tegenover_kuiltje(laatste_kuiltje, bord, speler);
                        bord.print_bord();
                    }

                    // laatste steen in een leeg kuiltje van de speler && tegenover is leeg
                    // of
                    // laatste steen in een leeg kuiltje van de andere speler
                    // -> zet over
                    print_tekst(speler.speler_nummer + ", jouw beurt is over.");
                    volgende_beurt = true;
                }
            }
        }
    }
}
