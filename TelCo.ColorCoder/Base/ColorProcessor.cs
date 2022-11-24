using System;

namespace TelCo.ColorCoder
{
    public class ColorProcessor
    {
        private ColorPair _pair;
        private int _pairNumber, minorSize;
        EvaluateColor evaluateColor = new EvaluateColor();
        public ColorProcessor(ColorPair pair = null, int pairNumber = 0)
        {
            _pair = pair;
            _pairNumber = pairNumber;
        }
        public int GetPairNumberFromColorProcessor()
        {
            ColorCalculationForPairNumberFromColor colorCalculationForPairNumberFromColor = new ColorCalculationForPairNumberFromColor();
            int majorIndex = colorCalculationForPairNumberFromColor.GetMajorColor(_pair);
            int minorIndex = colorCalculationForPairNumberFromColor.GetMinorColor(_pair);
            int result = evaluateColor.EvaluateColorPairNumber(_pair, majorIndex, minorIndex);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", _pair, result);
            return result;
        }
        public ColorPair GetColorFromPairNumberProcessor()
        {
            ColorCalculationForColorFromPairNumber colorCalculationForColorFromPairNumber = new ColorCalculationForColorFromPairNumber();
            minorSize = evaluateColor.EvaluateIsValidPairNumber(_pairNumber);
            ColorPair colorPair = colorCalculationForColorFromPairNumber.GetcolorPairNumber(_pairNumber, minorSize);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", _pairNumber, colorPair);
            return colorPair;
        }
    }
}
