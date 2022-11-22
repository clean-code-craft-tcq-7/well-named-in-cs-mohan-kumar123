using System;

namespace TelCo.ColorCoder
{
    public class EvaluateColor
    {
        public static int EvaluateColorPairNumber(ColorPair pair, int majorIndex, int minorIndex)
        {
            int result;
            // If colors can not be found throw an exception
            if (majorIndex == -1 && minorIndex == -1)
                throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));

            result = (majorIndex * ColorMap.colorMapMinor.Length) + (minorIndex + 1);
            
            return result;
        }
        public static int EvaluateIsValidPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = ColorMap.colorMapMinor.Length;
            int majorSize = ColorMap.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
                 throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            
            return minorSize;
        }
    }
}
