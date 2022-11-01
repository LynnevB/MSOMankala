using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class UnitTest1
    {
        [Theory]
        // data klopt nog niet 
        [InlineData(1,2)]
        public void TestTegenoverKuiltjesNormaal(int kuiltje_index, int tegenover_index)
        {
            // Arrange
            Bord bord = new(6, 4, true);
            Kuiltje kuiltje = bord.kuiltjes[kuiltje_index];

            // Act
            Kuiltje tegenover_kuiltje = bord.tegenover_kuiltje(kuiltje);
            int actual_tegenover_index = bord.kuiltjes.IndexOf(tegenover_kuiltje);

            // Assert
            Assert.Equal(tegenover_index, actual_tegenover_index);

        }

        [Fact]
        public void TestCheckEindeSpel_True()
        {
            // Arrange
            Bord bord = new(6, 0, true);
        }

        [Fact]
        public void TestCheckEindeSpel_FFalse()
        {

        }
    }
}
