using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class Test_Speel_Zet
    {
        [Theory]
        [InlineData(Spel.spelers.p1, 1)]
        [InlineData(Spel.spelers.p2, 1)]
        public void kuiltje_mogelijk_true(Spel.spelers speler_nummer, int steentjes)
        {
            // Arrange
            Speel_Zet speel_zet = new Speel_Zet_Mankala();
            Speler speler = new Speler(speler_nummer);
            Kuiltje kuil = new Kuiltje_Normaal(speler_nummer, steentjes);

            // Act
            bool is_mogelijk = speel_zet.kuiltje_mogelijk(kuil, speler);

            // Assert
            Assert.True(is_mogelijk);
        }

        [Theory]
        [InlineData(Spel.spelers.p1, Spel.spelers.p2)]
        [InlineData(Spel.spelers.p2, Spel.spelers.p1)]
        public void kuiltje_mogelijk_false_speler(Spel.spelers speler1, Spel.spelers speler2)
        {
            // Arrange
            Speel_Zet speel_zet = new Speel_Zet_Mankala();
            Speler speler = new Speler(speler1);
            Kuiltje kuil = new Kuiltje_Normaal(speler2, 1);

            // Act
            bool is_mogelijk = speel_zet.kuiltje_mogelijk(kuil, speler);

            // Assert
            Assert.False(is_mogelijk);
        }

        [Fact]
        public void kuiltje_mogelijk_false_kuiltje()
        {
            // Arrange
            Speel_Zet speel_zet = new Speel_Zet_Mankala();
            Speler speler = new Speler(Spel.spelers.p1);
            Kuiltje kuil = new Kuiltje_Thuis(Spel.spelers.p1);
            kuil.steentjes = 1;

            // Act
            bool is_mogelijk = speel_zet.kuiltje_mogelijk(kuil, speler);

            // Assert
            Assert.False(is_mogelijk);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void kuiltje_mogelijk_false_steentjes(int steentjes)
        {
            // Arrange
            Speel_Zet speel_zet = new Speel_Zet_Mankala();
            Speler speler = new Speler(Spel.spelers.p1);
            Kuiltje kuil = new Kuiltje_Normaal(Spel.spelers.p1, steentjes);

            // Act
            bool is_mogelijk = speel_zet.kuiltje_mogelijk(kuil, speler);

            // Assert
            Assert.False(is_mogelijk);
        }
    }
}
