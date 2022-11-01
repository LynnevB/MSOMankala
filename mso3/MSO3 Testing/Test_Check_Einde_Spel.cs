using System;
using Xunit;
using mso3;

namespace MSO3_Testing
{
    public class Test_Check_Einde_Spel
    {
        [Fact]
        public void CheckEinde_True()
        {
            // Arrange
            Bord bord = new(6, 0, true);
        }

        [Fact]
        public void CheckEinde_False()
        {

        }
    }
}
