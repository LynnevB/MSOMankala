using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class TestCheckEindeSpel
    {
        [Theory]
        [InlineData(Spel.spelers.p1)]
        [InlineData(Spel.spelers.p2)]
        public void check_einde_true(Spel.spelers speler_nummer)
        {
            // Arrange
            CheckEindeSpel einde = new CheckEindeSpel();
            Spel.speel_zet = new SpeelZetMankala();
            Bord bord = new Bord(6, 0, true);
            Speler speler = new Speler(speler_nummer);

            // Act
            bool is_einde = einde.check_einde(bord, speler);

            // Assert
            Assert.True(is_einde);
        }

        [Theory]
        [InlineData(Spel.spelers.p1)]
        [InlineData(Spel.spelers.p2)]
        public void check_einde_false(Spel.spelers speler_nummer)
        {
            // Arrange
            CheckEindeSpel einde = new CheckEindeSpel();
            Spel.speel_zet = new SpeelZetMankala();
            Bord bord = new Bord(6, 1, true);
            Speler speler = new Speler(speler_nummer);

            // Act
            bool is_einde = einde.check_einde(bord, speler);

            // Assert
            Assert.False(is_einde);
        }
    }
}
