namespace TelCo.ColorCoder
{
    public class PairNumberFromColorCode: IPairNumberFromColorCode
    {
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public int GetPairNumberFromColor(ColorPair pair)
        {
            ColorProcessor colorProcessor = new ColorProcessor(pair);
            int colorinfo = colorProcessor.GetPairNumberFromColorProcessor();
            return colorinfo;
        }
    }
}
