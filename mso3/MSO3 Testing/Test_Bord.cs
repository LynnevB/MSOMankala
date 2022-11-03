using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class Test_Bord
    {
        [Theory]
        [InlineData(false, 1, 0, 1)]
        [InlineData(false, 2, 0, 3)]
        [InlineData(false, 2, 1, 2)]

        [InlineData(true, 1, 1, 3)]
        [InlineData(true, 2, 1, 5)]
        [InlineData(true, 2, 2, 4)]

        public void tegenoverkuiltje_true(bool thuiskuiltjes, int aantal_kuiltjes_pp, int kuiltje_index, int expected_index)
        {
            // Arrange
            Bord bord = new(aantal_kuiltjes_pp, 4, thuiskuiltjes);
            Kuiltje kuiltje = bord.kuiltjes[kuiltje_index];

            // Act
            Kuiltje tegenover_kuiltje = bord.tegenover_kuiltje(kuiltje);
            int tegenover_index = bord.kuiltjes.IndexOf(tegenover_kuiltje);

            // Assert
            Assert.Equal(expected_index, tegenover_index);

        }

        [Theory]
        [InlineData(false, 1, 0, 0)]
        [InlineData(false, 2, 0, 2)]
        [InlineData(false, 2, 1, 3)]

        [InlineData(true, 1, 1, 2)]
        [InlineData(true, 2, 1, 2)]
        [InlineData(true, 2, 2, 5)]

        public void tegenoverkuiltje_false(bool thuiskuiltjes, int aantal_kuiltjes_pp, int kuiltje_index, int expected_index)
        {
            // Arrange
            Bord bord = new(aantal_kuiltjes_pp, 4, thuiskuiltjes);
            Kuiltje kuiltje = bord.kuiltjes[kuiltje_index];

            // Act
            Kuiltje tegenover_kuiltje = bord.tegenover_kuiltje(kuiltje);
            int tegenover_index = bord.kuiltjes.IndexOf(tegenover_kuiltje);

            // Assert
            Assert.False(expected_index == tegenover_index);

        }
    }
}
