using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    public class Spel
    {
        private Speler P1, P2;
        public Bord bord;
        private Regels regels;
        public static Maak_Bord maak_bord;
        public static Speel_Zet speel_zet;
        public static Strooi_Stenen strooi_stenen;
        public static Check_Einde_Spel check_einde_spel;
        public static Winnaar winnaar;

        public enum spelers
        {
            p1,
            p2
        }

        public Spel()
        {
            regels = kies_regels();
            maak_bord = regels.create_maak_bord();
            speel_zet = regels.create_speel_zet();
            strooi_stenen = regels.create_strooi_stenen();
            check_einde_spel = regels.create_check_einde();
            winnaar = regels.create_winnaar();

            bord = maak_bord.maak_bord();
            P1 = new Speler(spelers.p1);
            P2 = new Speler(spelers.p2);
        }

        // laat de speler een set regels kiezen en stuurt deze terug
        Regels kies_regels()
        {
            Console.WriteLine("Kies een set regels: ");

            List<Regels> lijst_regels = new List<Regels>() { new Regels_Mankala(), new Regels_Wari(), new Regels_Bonkus() };
            for (int i = 0; i < lijst_regels.Count; i++)
            {
                Console.WriteLine("[" + (i+1) + "] " + lijst_regels[i].ToString());
            }

            int antwoord = Convert.ToInt32(Console.ReadLine());
            while (antwoord > lijst_regels.Count || antwoord < 0)
            {
                Console.WriteLine("Kies een van de mogelijke opties");
                antwoord = Convert.ToInt32(Console.ReadLine());
            }

            return lijst_regels[antwoord-1];
        }

        public void speel_spel()
        {
            Speler current_speler = P1;
            while(!check_einde_spel.check_einde(bord, current_speler))
            {
                speel_zet.speel_zet(bord, current_speler);
                if (current_speler.eindig_spel)
                    break;
                current_speler = switch_speler(current_speler);
            }

            Console.WriteLine(winnaar.winnaar(bord));
        }

        Speler switch_speler(Speler speler)
        {
            if (speler == P1)
                return P2;
            else
                return P1;
        }
        
    }
}
