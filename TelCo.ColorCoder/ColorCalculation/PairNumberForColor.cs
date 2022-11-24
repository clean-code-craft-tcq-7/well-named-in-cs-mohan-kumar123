namespace TelCo.ColorCoder
{
    public class PairNumberForColor : IPairNumberForColor
    {
        public int GetMinorColor(ColorPair pair)
        {
            int minorIndex = -1;
            for (int i = 0; i < ColorMap.colorMapMinor.Length; i++)
            {
                if (ColorMap.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            return minorIndex;
        }
        public int GetMajorColor(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < ColorMap.colorMapMajor.Length; i++)
            {
                if (ColorMap.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            return majorIndex;
        }
    }
}
