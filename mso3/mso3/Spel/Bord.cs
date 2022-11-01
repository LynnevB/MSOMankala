using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public class Bord
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
            string normalgap = "|   |";
            string homegap = "|     |";

            string whitespacetoprow = "       ";
            string whitespacebottomrow = "";

            string lines = "-------" + new string('-', 5 * (kuiltjes.Count / 2)) + "--";

            string nummeringtop = "       ";
            string nummeringbottom = "";

            string inhoudtop = "       ";
            string inhoudbottom = "";

            for (int i = kuiltjes.Count - 1; i >= (kuiltjes.Count / 2); i--)
            {
                if (kuiltjes[i] is Kuiltje_Thuis)
                {
                    whitespacetoprow += homegap;
                    nummeringtop += ("" + i).PadLeft(4).PadRight(7);

                    inhoudtop += ("|" + ("" + kuiltjes[i].steentjes).PadLeft(3).PadRight(5) + "|");
                }
                else
                {
                    whitespacetoprow += normalgap;
                    nummeringtop += ("" + i).PadLeft(3).PadRight(5);

                    inhoudtop += ("|" + ("" + kuiltjes[i].steentjes).PadLeft(2).PadRight(3) + "|");
                }
            }

            for (int i = 0; i < (kuiltjes.Count / 2); i++)
            {
                if (kuiltjes[i] is Kuiltje_Thuis)
                {
                    whitespacebottomrow += homegap;

                    nummeringbottom += ("" + i).PadLeft(4).PadRight(7);

                    inhoudbottom += ("|" + ("" + kuiltjes[i].steentjes).PadLeft(3).PadRight(5) + "|");
                }
                else
                {
                    whitespacebottomrow += normalgap;

                    nummeringbottom += ("" + i).PadLeft(3).PadRight(5);

                    inhoudbottom += ("|" + ("" + kuiltjes[i].steentjes).PadLeft(2).PadRight(3) + "|");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Speler 2");
            Console.WriteLine(nummeringtop);
            Console.WriteLine(lines);
            Console.WriteLine(whitespacetoprow);
            Console.WriteLine(inhoudtop);
            Console.WriteLine(whitespacetoprow);
            Console.WriteLine(lines);
            Console.WriteLine(whitespacebottomrow);
            Console.WriteLine(inhoudbottom);
            Console.WriteLine(whitespacebottomrow);
            Console.WriteLine(lines);
            Console.WriteLine(nummeringbottom);
            Console.WriteLine("Speler 1");
            Console.WriteLine();
        }
    }
}
