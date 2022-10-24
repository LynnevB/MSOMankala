using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Bord
    {
        public List<Kuiltje> kuiltjes = new List<Kuiltje>();
        public int kuiltjes_per_speler;
        public bool thuiskuiltje;

        // aantal_kuiltjes is het aantal normale kuiltjes per speler
        public Bord(int aantal_kuiltjes, int aantal_steentjes, bool thuiskuiltjes)
        {
            kuiltjes_per_speler = aantal_kuiltjes;
            thuiskuiltje = thuiskuiltjes;

            // hieruit komt een lijst: [ (thuiskuiltje p1,) kuiltjes p1 ... , (thuiskuiltje p2,) kuiltjes p2 ...]
            for (int aantal_spelers = 0; aantal_spelers < 2; aantal_spelers++)
            {
                if (thuiskuiltjes && aantal_spelers == 0)
                    kuiltjes.Add(new Kuiltje_Thuis(Spel.spelers.p1));
                else if(thuiskuiltjes && aantal_spelers == 1)
                    kuiltjes.Add(new Kuiltje_Thuis(Spel.spelers.p2));

                for (int i = 0; i < kuiltjes_per_speler; i++)
                {
                    if (aantal_spelers == 0)
                        kuiltjes.Add(new Kuiltje_Normaal(Spel.spelers.p1, aantal_steentjes));
                    else
                        kuiltjes.Add(new Kuiltje_Normaal(Spel.spelers.p2, aantal_steentjes));
                }
            }
        }
    }
}
