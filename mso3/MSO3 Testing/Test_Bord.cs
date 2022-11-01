using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class Test_Bord
    {
        [Theory]
        // data klopt nog niet 
        //mogelijk aparte test voor met en zonder thuiskuiltjes in bord ?
        [InlineData(6, false, 1, 2)]
        public void tegenoverkuiltje(int aantal_kuiltjes, bool thuiskuiltjes, int kuiltje_index, int tegenover_index)
        {
            // Arrange
            Bord bord = new(aantal_kuiltjes, 4, thuiskuiltjes);
            Kuiltje kuiltje = bord.kuiltjes[kuiltje_index];

            // Act
            Kuiltje tegenover_kuiltje = bord.tegenover_kuiltje(kuiltje);
            int actual_tegenover_index = bord.kuiltjes.IndexOf(tegenover_kuiltje);

            // Assert
            Assert.Equal(tegenover_index, actual_tegenover_index);

        }
    }
}
