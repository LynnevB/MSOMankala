﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Bord
    {
        public List<Kuiltje> kuiltjes = new List<Kuiltje>();
        public bool thuiskuiltje;

        // aantal_kuiltjes is het aantal normale kuiltjes per speler
        public Bord(int aantal_kuiltjes, int aantal_steentjes, bool thuiskuiltjes)
        {
            thuiskuiltje = thuiskuiltjes;

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

        public Kuiltje tegenover_kuiltje(Kuiltje kuil)
        {
            int index = kuiltjes.IndexOf(kuil);
            int totaal_kuiltjes = kuiltjes.Count;
            int tegenover_index = totaal_kuiltjes - index;
            if (!thuiskuiltje)
                tegenover_index -= 1;
            
            return kuiltjes[tegenover_index];
        }


        public void print_bord()
        {
            Console.WriteLine();
            for (int i = 0; i < kuiltjes.Count; i++)
            {
                string text = "Kuiltje " + i + ", " + kuiltjes[i].speler_nummer;
                if (kuiltjes[i] is Kuiltje_Thuis)
                    text += ", Thuis: ";
                else
                    text += ", Normaal: ";
                text += kuiltjes[i].steentjes;
                Console.WriteLine(text);
            }
            Console.WriteLine();
        }
    }
}