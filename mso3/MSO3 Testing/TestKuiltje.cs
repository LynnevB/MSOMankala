using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class TestKuiltje
    {
        [Theory]
        [InlineData(0,1)]
        [InlineData(5, 6)]
        [InlineData(-1, 0)]
        public void gooi_steentje_kuiltje_normaal(int begin_aantal, int expected)
        {
            // Arrange
            Kuiltje kuil = new Kuiltje_Normaal(Spel.spelers.p1, begin_aantal);

            // Act
            kuil.gooi_steentje();
            int stenen = kuil.steentjes;

            // Assert
            Assert.Equal(expected, stenen);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(5, 6)]
        [InlineData(-1, 0)]
        public void gooi_steentje_kuiltje_thuis(int begin_aantal, int expected)
        {
            // Arrange
            Kuiltje kuil = new Kuiltje_Thuis(Spel.spelers.p1);
            kuil.steentjes = begin_aantal;

            // Act
            kuil.gooi_steentje();
            int stenen = kuil.steentjes;

            // Assert
            Assert.Equal(expected, stenen);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(-10)]
        public void haal_leeg_kuiltje_normaal(int begin_aantal)
        {
            // Arrange
            int expected_stenen = 0;
            Kuiltje kuil = new Kuiltje_Normaal(Spel.spelers.p1, begin_aantal);

            // Act
            kuil.haal_leeg();
            int stenen = kuil.steentjes;

            // Assert
            Assert.Equal(expected_stenen, stenen);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(-10)]
        public void haal_leeg_kuiltje_thuis(int begin_aantal)
        {
            // Arrange
            Kuiltje kuil = new Kuiltje_Thuis(Spel.spelers.p1);
            kuil.steentjes = begin_aantal;

            // Act
            kuil.haal_leeg();
            int stenen = kuil.steentjes;

            // Assert
            Assert.Equal(stenen, begin_aantal);
        }
    }
}
