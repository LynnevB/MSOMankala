﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    class Spel
    {
        private Speler P1, P2;
        public static Regels regels = new StandaardRegels();
        public Bord bord;

        public enum spelers
        {
            p1,
            p2
        }

        public Spel()
        {
            bord = regels.create_maak_bord().maakBord();
            P1 = new Speler(spelers.p1);
            P2 = new Speler(spelers.p2);
        }

        private void speel_spel()
        {
            // TO DO

        }
        
    }
}
