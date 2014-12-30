using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissDlcToolkit.Utils
{
    class MiscUtils
    {
        public static UInt16 swapEndianness(UInt16 x)
        {
            return (UInt16)(((x & 0x00ff) << 8) +  // First byte
                   ((x & 0xff00) >> 8));   // Second byte                   
        }

        public static Color invertColor(Color c)
        {
            // Assumes alpha is in the leftmost byte, change as needed
            return Color.FromArgb((int)(0x00FFFFFFu ^ c.ToArgb()));           
        }

        public static String argbToString(Color color)
        {
            return "#" + color.A.ToString("X2") + color.R.ToString("X2") 
                + color.G.ToString("X2") + color.B.ToString("X2");
        }

        public static String rgbToString(Color color)
        {
            return "#" + color.R.ToString("X2")
                + color.G.ToString("X2") + color.B.ToString("X2");
        }
    }
}
