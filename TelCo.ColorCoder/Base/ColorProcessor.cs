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
            PairNumberForColor pairNumberColor = new PairNumberForColor();
            int majorIndex = pairNumberColor.GetMajorColor(_pair);
            int minorIndex = pairNumberColor.GetMinorColor(_pair);
            int result = evaluateColor.EvaluateColorPairNumber(_pair, majorIndex, minorIndex);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", _pair, result);
            return result;
        }
        public ColorPair GetColorFromPairNumberProcessor()
        {
            ColorForPairNumber colorForPairNumber = new ColorForPairNumber();
            minorSize = evaluateColor.EvaluateIsValidPairNumber(_pairNumber);
            ColorPair colorPair = colorForPairNumber.GetcolorPairNumber(_pairNumber, minorSize);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", _pairNumber, colorPair);
            return colorPair;
        }
    }
}
