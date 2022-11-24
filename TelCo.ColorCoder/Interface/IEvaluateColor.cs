namespace TelCo.ColorCoder
{
    public interface IEvaluateColor
    {
        int EvaluateColorPairNumber(ColorPair pair, int majorIndex, int minorIndex);
        int EvaluateIsValidPairNumber(int pairNumber);
    }
}