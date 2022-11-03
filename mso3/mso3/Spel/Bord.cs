using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public class Bord
    {
        public List<Kuiltje> kuiltjes = new List<Kuiltje>();
        public bool heeft_thuiskuiltjes;

        // aantal_kuiltjes is het aantal normale kuiltjes per speler
        public Bord(int aantal_kuiltjes, int aantal_steentjes, bool thuiskuiltjes)
        {
            heeft_thuiskuiltjes = thuiskuiltjes;

            // hieruit komt een lijst: [ (thuiskuiltje p1,) kuiltjes p1 ... , (thuiskuiltje p2,) kuiltjes p2 ...]
            for (int aantal_spelers = 0; aantal_spelers < 2; aantal_spelers++)
            {
                if (thuiskuiltjes && aantal_spelers == 0)
                    kuiltjes.Add(new Kuiltje_Thuis(Spel.spelers.p1));
                else if(thuiskuiltjes && aantal_spelers == 1)
                    kuiltjes.Add(new Kuiltje_Thuis(Spel.spelers.p2));

                for (int i = 0; i < aantal_kuiltjes; i++)
                {
                    if (aantal_spelers == 0)
                        kuiltjes.Add(new Kuiltje_Normaal(Spel.spelers.p1, aantal_steentjes));
                    else
                        kuiltjes.Add(new Kuiltje_Normaal(Spel.spelers.p2, aantal_steentjes));
                }
            }
        }

        // geeft het kuiltje terug die tegenover het kuiltje wat megegeven wordt ligt
        public Kuiltje tegenover_kuiltje(Kuiltje kuil)
        {
            int index = kuiltjes.IndexOf(kuil);
            int totaal_kuiltjes = kuiltjes.Count;
            int tegenover_index = totaal_kuiltjes - index;
            if (!heeft_thuiskuiltjes)
                tegenover_index -= 1;
            
            return kuiltjes[tegenover_index];
        }

        public void print_bord()
        {
            int thuis_boven = kuiltjes.Count / 2;
            int thuis_onder = 0;
            int start_index = 0;

            string enter = "\n";
            string normaal_gap = "|   |";
            string thuis_gap = "|     |";

            string rij_boven = "       ";
            string rij_onder = "";

            string lijn = "-------" + new string('-', 5 * (kuiltjes.Count / 2)) + "--";

            string nummers_boven = "       ";
            string nummers_onder = "";

            string inhoud_boven = "       ";
            string inhoud_onder = "";

            if (heeft_thuiskuiltjes)
            {
                start_index = 1;
                rij_onder += thuis_gap;
                nummers_onder += ("" + thuis_onder).PadLeft(4).PadRight(7);
                inhoud_onder += ("|" + ("" + kuiltjes[thuis_onder].steentjes).PadLeft(3).PadRight(5) + "|");
            }

            for (int i = start_index; i < (kuiltjes.Count / 2); i++)
            {
                // rij onder
                rij_onder += normaal_gap;
                nummers_onder += ("" + i).PadLeft(3).PadRight(5);
                inhoud_onder += ("|" + ("" + kuiltjes[i].steentjes).PadLeft(2).PadRight(3) + "|");

                // rij boven
                int j = kuiltjes.Count - i - 1 + start_index; 
                rij_boven += normaal_gap;
                nummers_boven += ("" + j).PadLeft(3).PadRight(5);
                inhoud_boven += ("|" + ("" + kuiltjes[j].steentjes).PadLeft(2).PadRight(3) + "|");
            }

            if (heeft_thuiskuiltjes)
            {
                rij_boven += thuis_gap;
                nummers_boven += ("" + thuis_boven).PadLeft(4).PadRight(7);
                inhoud_boven += ("|" + ("" + kuiltjes[thuis_boven].steentjes).PadLeft(3).PadRight(5) + "|");
            }

            Console.WriteLine(enter + "Speler 2" + enter + nummers_boven + enter + lijn + enter + rij_boven + enter + inhoud_boven + enter + rij_boven + enter + lijn);
            Console.WriteLine(rij_onder + enter + inhoud_onder + enter + rij_onder + enter + lijn + enter + nummers_onder + enter + "Speler 1" + enter);
        }
    }
}
