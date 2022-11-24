namespace TelCo.ColorCoder
{
    public interface IPairNumberForColor
    {
        int GetMajorColor(ColorPair pair);
        int GetMinorColor(ColorPair pair);
    }
}