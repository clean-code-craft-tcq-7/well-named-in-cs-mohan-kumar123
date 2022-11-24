namespace TelCo.ColorCoder
{
    public interface IColorCalculationForPairNumberFromColor
    {
        int GetMajorColor(ColorPair pair);
        int GetMinorColor(ColorPair pair);
    }
}