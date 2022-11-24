namespace TelCo.ColorCoder
{
    public interface IColorCalculationForColorFromPairNumber
    {
        ColorPair GetcolorPairNumber(int pairNumber, int minorSize);
    }
}