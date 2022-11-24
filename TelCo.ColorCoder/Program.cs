using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            IColorCodeFromPairNumber colorCodeFromPairNumber = new ColorCodeFromPairNumber();
            IPairNumberFromColorCode pairNumberFromColorCode = new PairNumberFromColorCode();
            int[] pairNumbers = new int[] { 4, 5, 23, 6, 7, 8};

            for (int i = 0; i < pairNumbers.Length; i++)
            {
                int pairNumber = pairNumbers[i];
                colorCodeFromPairNumber.GetColorFromPairNumber(pairNumber);
            }

            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumberFromColorCode.GetPairNumberFromColor(testPair2);
            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumberFromColorCode.GetPairNumberFromColor(testPair2);
        }
    }
}
