using Moq;
using System;
using System.Drawing;
using TelCo.ColorCoder;
using Xunit;

namespace UnitTest
{
    public class ColorFromPairNumberAssertionUnitTest
    {
        [Fact]
        public void TestColorFrmPairNo_ReturnColor()
        {
            //Arrange
            ColorProcessor colorProcessor = new ColorProcessor(null, 4);
            //Act
            ColorPair result =  colorProcessor.GetColorFromPairNumberProcessor();
            //Assert
            Assert.Equal(result.majorColor.ToString(), Color.White.ToString());
            Assert.Equal(result.minorColor.ToString(), Color.Brown.ToString());
        }
        [Fact]
        public void Test2()
        {
            //Arrange
            ColorProcessor colorProcessor = new ColorProcessor(null, 5);
            //Act
            ColorPair result = colorProcessor.GetColorFromPairNumberProcessor();
            //Assert
            Assert.Equal(result.majorColor.ToString(), Color.White.ToString());
            Assert.Equal(result.minorColor.ToString(), Color.SlateGray.ToString());
        }
        [Fact]
        public void TestPairNumFromColor_ReturnException()
        {
            //Arrange
            int pairNumber = 34;
            ColorProcessor colorProcessor = new ColorProcessor(null, pairNumber);
            //Act
            Action act = () => colorProcessor.GetColorFromPairNumberProcessor();
            //Assert
            ArgumentException exception = Assert.Throws<ArgumentOutOfRangeException>(act);
            string result = "Specified argument was out of the range of valid values. (Parameter 'Argument PairNumber:" + pairNumber + " is outside the allowed range')";
            Assert.Equal(result, exception.Message);
        }
    }
}
