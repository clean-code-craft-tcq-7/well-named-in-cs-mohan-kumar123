using System;
using TelCo.ColorCoder.Interface;
using TelCo.ColorCoder.UnitTestAssertion;

namespace TelCo.ColorCoder
{
    public class ColorProcessor
    {
        private ColorPair _pair;
        private int _pairNumber, minorSize;
        public ColorProcessor(ColorPair pair = null, int pairNumber = 0)
        {
            _pair = pair;
            _pairNumber = pairNumber;
        }
        public void GetPairNumberFromColorProcessor()
        {
            int majorIndex = ColorCalculationForPairNumberFromColor.GetMajorColor(_pair);
            int minorIndex = ColorCalculationForPairNumberFromColor.GetMinorColor(_pair);
            int result = EvaluateColor.EvaluateColorPairNumber(_pair, majorIndex, minorIndex);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", _pair, result);
            IUnitTestForColor unitTestForColor = new PairNumberFromColorAssertion(_pair, result);
            unitTestForColor.AssertionCheck();
        }
        public void GetColorFromPairNumberProcessor()
        {
            minorSize = EvaluateColor.EvaluateIsValidPairNumber(_pairNumber);
            ColorPair colorPair = ColorCalculationForColorFromPairNumber.GetcolorPairNumber(_pairNumber, minorSize);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", _pairNumber, colorPair);
            IUnitTestForColor unitTestForColor = new ColorFromPairNumberAssertion(colorPair, _pairNumber);
            unitTestForColor.AssertionCheck();
        }
    }
}
