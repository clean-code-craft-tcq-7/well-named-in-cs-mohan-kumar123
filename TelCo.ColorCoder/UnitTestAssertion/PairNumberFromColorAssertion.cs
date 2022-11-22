using System.Diagnostics;
using System.Drawing;
using TelCo.ColorCoder.Interface;

namespace TelCo.ColorCoder.UnitTestAssertion
{
    public class PairNumberFromColorAssertion: IUnitTestForColor
    {
        private ColorPair _colorPair;
        private int _pairNumber;
        public PairNumberFromColorAssertion(ColorPair colorPair, int pairNumber)
        {
            _colorPair = colorPair;
            _pairNumber = pairNumber;
        }
        public void AssertionCheck()
        {
            if (_colorPair.majorColor == Color.Yellow)
            {
                Debug.Assert(_pairNumber == 18);
            }
            else if (_colorPair.majorColor == Color.Red)
            {
                Debug.Assert(_pairNumber == 6);
            }
            
        }
    }
}
