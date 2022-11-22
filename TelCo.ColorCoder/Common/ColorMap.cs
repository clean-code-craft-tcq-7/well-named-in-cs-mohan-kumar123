using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorMap
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] colorMapMinor;

        static ColorMap()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
