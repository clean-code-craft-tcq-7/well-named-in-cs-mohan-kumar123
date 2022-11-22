namespace TelCo.ColorCoder
{
    public class ColorCodeFromPairNumber: IColorCodeFromPairNumber
    {
        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
        public void GetColorFromPairNumber(int pairNumber)
        {
            ColorProcessor colorProcessor = new ColorProcessor(null, pairNumber);
            colorProcessor.GetColorFromPairNumberProcessor();
        }
    }
}
