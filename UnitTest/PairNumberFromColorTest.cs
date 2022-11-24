using System;
using System.Drawing;
using TelCo.ColorCoder;
using Xunit;

namespace UnitTest
{
    public class PairNumberFromColorTest
    {
        [Fact]
        public void TestPairNumFromColor_Return4()
        {
            //Arrange
            ColorPair testPair2 = new ColorPair() { majorColor = Color.White, minorColor = Color.Brown };
            ColorProcessor colorProcessor = new ColorProcessor(testPair2);
            //Act
            int result = colorProcessor.GetPairNumberFromColorProcessor();
            //Assert
            Assert.Equal(result.ToString(), 4.ToString());
        }
        [Fact]
        public void TestPairNumFromColor_Return5()
        {
            //Arrange
            ColorPair testPair2 = new ColorPair() { majorColor = Color.White, minorColor = Color.SlateGray };
            ColorProcessor colorProcessor = new ColorProcessor(testPair2);
            //Act
            int result = colorProcessor.GetPairNumberFromColorProcessor();
            //Assert
            Assert.Equal(result.ToString(), 5.ToString());
        }
        [Fact]
        public void TestPairNumFromColor_ReturnException()
        {
            //Arrange
            ColorPair testPair2 = new ColorPair() { majorColor = Color.DarkBlue, minorColor = Color.DarkGoldenrod};
            ColorProcessor colorProcessor = new ColorProcessor(testPair2);
            //act
            Action act = () => colorProcessor.GetPairNumberFromColorProcessor();
            //assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Unknown Colors: MajorColor:DarkBlue, MinorColor:DarkGoldenrod", exception.Message);
        }
    }
}
