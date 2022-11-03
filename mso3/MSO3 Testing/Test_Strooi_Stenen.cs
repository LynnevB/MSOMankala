using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class Test_Strooi_Stenen
    {
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
        [InlineData(Spel.spelers.p1, 1)]
        [InlineData(Spel.spelers.p1, 2)]
        [InlineData(Spel.spelers.p1, 3)]
        [InlineData(Spel.spelers.p2, 0)]
        [InlineData(Spel.spelers.p2, 1)]
        [InlineData(Spel.spelers.p2, 3)]
        public void steen_in_thuiskuiltje_verkeerde_kuiltjes(Spel.spelers speler_nummer, int kuil_index)
        {
            // Arrange
            Strooi_Stenen strooi_stenen = new Strooi_Stenen_Mankala();
            Speler speler = new Speler(speler_nummer);
            int begin_stenen = 0;
            Bord bord = new Bord(1, begin_stenen, true);

            // Act
            strooi_stenen.steen_in_thuiskuiltje(1, speler, bord);
            int actual_stenen = bord.kuiltjes[kuil_index].steentjes;

            // Assert
            Assert.Equal(begin_stenen, actual_stenen);
        }
    }
}
