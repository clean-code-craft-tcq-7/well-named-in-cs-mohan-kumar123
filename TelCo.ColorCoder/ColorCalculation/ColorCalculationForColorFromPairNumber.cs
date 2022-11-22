namespace TelCo.ColorCoder
{
    public class ColorCalculationForColorFromPairNumber
    {
        public static ColorPair GetcolorPairNumber(int pairNumber, int minorSize)
        {
            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
            // Construct the return val from the arrays
            ColorPair pair = new ColorPair()
            {
                majorColor = ColorMap.colorMapMajor[majorIndex],
                minorColor = ColorMap.colorMapMinor[minorIndex]
            };
            return pair;
        }
    }
}
