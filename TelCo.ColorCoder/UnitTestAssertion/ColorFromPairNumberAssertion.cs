using System.Diagnostics;
using System.Drawing;
using TelCo.ColorCoder.Interface;

namespace TelCo.ColorCoder.UnitTestAssertion
{
    public class ColorFromPairNumberAssertion : IUnitTestForColor
    {
        private ColorPair _colorPair;
        private int _pairNumber;
        public ColorFromPairNumberAssertion(ColorPair colorPair, int pairNumber)
        {
            _colorPair = colorPair;
            _pairNumber = pairNumber;
        }
        public void AssertionCheck()
        {
            switch (_pairNumber)
            {
                case 4:
                    Debug.Assert(_colorPair.majorColor == Color.White);
                    Debug.Assert(_colorPair.minorColor == Color.Brown);
                    break;
                case 5:
                    Debug.Assert(_colorPair.majorColor == Color.White);
                    Debug.Assert(_colorPair.minorColor == Color.SlateGray);
                    break;
                case 34:
                    Debug.Assert(_colorPair.majorColor == Color.Violet);
                    Debug.Assert(_colorPair.minorColor == Color.Green);
                    break;
                default:
                    break;
            }
        }
    }
}
