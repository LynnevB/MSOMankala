using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class Test_Strooi_Stenen
    {/*
        public void steen_in_thuiskuiltje(int steentjes, Speler speler, Bord bord)
        {
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
        */
        [Theory]
        [InlineData(Spel.spelers.p1, 1, 0)]
        [InlineData(Spel.spelers.p1, 0, 0)]
        [InlineData(Spel.spelers.p1, -1, 0)]
        [InlineData(Spel.spelers.p2, 1, 2)]
        [InlineData(Spel.spelers.p2, 0, 2)]
        [InlineData(Spel.spelers.p2, -1, 2)]
        public void steen_in_thuiskuiltje_juiste_kuiltjes(Spel.spelers speler_nummer, int steentjes, int kuil_index)
        {
            // Arrange
            Strooi_Stenen strooi_stenen = new Strooi_Stenen_Mankala();
            Speler speler = new Speler(speler_nummer);
            Bord bord = new Bord(1, 0, true);

            // Act
            strooi_stenen.steen_in_thuiskuiltje(steentjes, speler, bord);
            int actual_stenen = bord.kuiltjes[kuil_index].steentjes;

            // Assert
            Assert.Equal(steentjes, actual_stenen);
        }

        [Theory]
        [InlineData(Spel.spelers.p1, 1, 1)]
        [InlineData(Spel.spelers.p1, 1, 2)]
        [InlineData(Spel.spelers.p1, 1, 3)]
        [InlineData(Spel.spelers.p2, 1, 0)]
        [InlineData(Spel.spelers.p2, 1, 1)]
        [InlineData(Spel.spelers.p2, 1, 3)]
        public void steen_in_thuiskuiltje_verkeerde_kuiltjes(Spel.spelers speler_nummer, int steentjes, int kuil_index)
        {
            // Arrange
            Strooi_Stenen strooi_stenen = new Strooi_Stenen_Mankala();
            Speler speler = new Speler(speler_nummer);
            Bord bord = new Bord(0, 0, true);

            // Act
            strooi_stenen.steen_in_thuiskuiltje(steentjes, speler, bord);
            int actual_stenen = bord.kuiltjes[kuil_index].steentjes;

            // Assert
            Assert.False(steentjes == actual_stenen);
        }
    }
}
