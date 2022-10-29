using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Speel_Zet_Mankala : Speel_Zet
    {
        public void zet_tegenover_kuiltje(Kuiltje laatste_kuiltje, Bord bord, Speler speler)
        {
            Kuiltje tegenover = bord.tegenover_kuiltje(laatste_kuiltje);
            int steentjes = 1 + tegenover.steentjes;

            laatste_kuiltje.haal_leeg();
            tegenover.haal_leeg();

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

        public override void speel_zet(Bord bord, Speler speler)
        {
            // eerste zet
            bord.print_bord();
            bool volgende_beurt = false;
            Kuiltje laatste_kuiltje = zet_kies_kuiltje(bord, speler);

            while (!volgende_beurt)
            {
                bord.print_bord();

                // eigen thuiskuiltje
                if (laatste_kuiltje is Kuiltje_Thuis && laatste_kuiltje.speler_nummer == speler.speler_nummer)
                {
                    if (Spel.check_einde_spel.check_einde(bord, speler))
                    {
                        speler.eindig_spel = true;
                        return;
                    }
                    laatste_kuiltje = zet_kies_kuiltje(bord, speler);
                }

                // niet leeg kuiltje -> pak deze stenen en ga verder 
                else if (laatste_kuiltje.steentjes > 1)
                {
                    Console.WriteLine(speler.speler_nummer + " pakt de steentjes van kuiltje " + bord.kuiltjes.IndexOf(laatste_kuiltje));
                    Console.WriteLine("(Klik op enter om verder te gaan)");
                    Console.ReadLine();
                    laatste_kuiltje = zet_strooi_stenen(laatste_kuiltje, bord, speler);
                }

                else
                {
                    // leeg kuiltje speler + tegenover niet leeg -> pak laatste gestrooide steen en tegenover kuiltje voeg toe aan thuiskuiltje zet over
                    if (bord.tegenover_kuiltje(laatste_kuiltje).steentjes > 0 && laatste_kuiltje.speler_nummer == speler.speler_nummer)
                    {
                        Console.WriteLine(speler.speler_nummer + " pakt het laatste steentje en de steentjes aan de overkant en gooit ze in hun thuiskuiltje.");
                        Console.WriteLine("(Klik op enter om verder te gaan)");
                        Console.ReadLine();
                        zet_tegenover_kuiltje(laatste_kuiltje, bord, speler);
                        bord.print_bord();
                    }

                    // leeg kuiltje speler + tegenover is leeg -> volgende aan de beurt
                    // leeg kuiltje andere speler -> volgende aan de beurt
                    Console.WriteLine(speler.speler_nummer + ", jouw beurt is over.");
                    Console.WriteLine("(Klik op enter om verder te gaan)");
                    Console.ReadLine();
                    volgende_beurt = true;
                }
            }
        }
    }
}
