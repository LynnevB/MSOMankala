using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class Test_Winnaar
    {
        [Theory]
        [InlineData(5, 0, "Speler 1 heeft gewonnen!")]
        [InlineData(5, -10, "Speler 1 heeft gewonnen!")]
        [InlineData(-5, -10, "Speler 1 heeft gewonnen!")]

        [InlineData(0, 5, "Speler 2 heeft gewonnen!")]
        [InlineData(-10, 5, "Speler 2 heeft gewonnen!")]
        [InlineData(-10, -5, "Speler 2 heeft gewonnen!")]

        [InlineData(5, 5, "Gelijk spel!")]
        [InlineData(0, 0, "Gelijk spel!")]
        [InlineData(-5, -5, "Gelijk spel!")]
        public void winnaar_meeste_stenen_true(int stenen_p1, int stenen_p2, string expected)
        {
            // Arrange
            Winnaar geef_winnaar = new Winnaar_Meeste_Punten();
            Bord bord = new Bord(6, 4, true);

            // Act
            // geef p1 stenen
            bord.kuiltjes[0].steentjes = stenen_p1;

            // geef p2 stenen
            bord.kuiltjes[(bord.kuiltjes.Count / 2)].steentjes = stenen_p2;

            string gewonnen_speler = geef_winnaar.winnaar(bord);

            // Assert
            Assert.Equal(expected, gewonnen_speler);
        }

        [Theory]
        [InlineData(0, 0, "Speler 1 heeft gewonnen!")]
        [InlineData(5, 10, "Speler 1 heeft gewonnen!")]
        [InlineData(-5, 10, "Speler 1 heeft gewonnen!")]

        [InlineData(0, 0, "Speler 2 heeft gewonnen!")]
        [InlineData(10, 5, "Speler 2 heeft gewonnen!")]
        [InlineData(10, -5, "Speler 2 heeft gewonnen!")]

        [InlineData(0, 1, "Gelijk spel!")]
        [InlineData(-1, 0, "Gelijk spel!")]
        public void winnaar_meeste_stenen_false(int stenen_p1, int stenen_p2, string expected)
        {
            // Arrange
            Winnaar geef_winnaar = new Winnaar_Meeste_Punten();
            Bord bord = new Bord(6, 4, true);

            // Act
            // geef p1 stenen
            bord.kuiltjes[0].steentjes = stenen_p1;

            // geef p2 stenen
            bord.kuiltjes[(bord.kuiltjes.Count / 2)].steentjes = stenen_p2;

            string gewonnen_speler = geef_winnaar.winnaar(bord);

            // Assert
            Assert.False(expected == gewonnen_speler);
        }

        [Theory]
        [InlineData(0, 5, "Speler 1 heeft gewonnen!")]
        [InlineData(-5, 10, "Speler 1 heeft gewonnen!")]
        [InlineData(-10, -5, "Speler 1 heeft gewonnen!")]

        [InlineData(5, 0, "Speler 2 heeft gewonnen!")]
        [InlineData(5, -10, "Speler 2 heeft gewonnen!")]
        [InlineData(-5, -10, "Speler 2 heeft gewonnen!")]

        [InlineData(5, 5, "Gelijk spel!")]
        [InlineData(0, 0, "Gelijk spel!")]
        [InlineData(-5, -5, "Gelijk spel!")]
        public void winnaar_minste_stenen_true(int stenen_p1, int stenen_p2, string expected)
        {
            // Arrange
            Winnaar geef_winnaar = new Winnaar_Minste_Punten();
            Bord bord = new Bord(6, 4, true);

            // Act
            // geef p1 stenen
            bord.kuiltjes[0].steentjes = stenen_p1;

            // geef p2 stenen
            bord.kuiltjes[(bord.kuiltjes.Count / 2)].steentjes = stenen_p2;

            string gewonnen_speler = geef_winnaar.winnaar(bord);

            // Assert
            Assert.Equal(expected, gewonnen_speler);
        }

        [Theory]
        [InlineData(5, 0, "Speler 1 heeft gewonnen!")]
        [InlineData(5, -10, "Speler 1 heeft gewonnen!")]
        [InlineData(-5, -10, "Speler 1 heeft gewonnen!")]

        [InlineData(0, 5, "Speler 2 heeft gewonnen!")]
        [InlineData(-10, 5, "Speler 2 heeft gewonnen!")]
        [InlineData(-10, -5, "Speler 2 heeft gewonnen!")]

        [InlineData(0, 1, "Gelijk spel!")]
        [InlineData(-1, 0, "Gelijk spel!")]
        public void winnaar_minste_stenen_false(int stenen_p1, int stenen_p2, string expected)
        {
            // Arrange
            Winnaar geef_winnaar = new Winnaar_Minste_Punten();
            Bord bord = new Bord(6, 4, true);

            // Act
            // geef p1 stenen
            bord.kuiltjes[0].steentjes = stenen_p1;

            // geef p2 stenen
            bord.kuiltjes[(bord.kuiltjes.Count / 2)].steentjes = stenen_p2;

            string gewonnen_speler = geef_winnaar.winnaar(bord);

            // Assert
            Assert.False(expected == gewonnen_speler);
        }
    }
}
