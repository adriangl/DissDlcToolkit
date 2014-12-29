using System;
using System.Collections.Generic;
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
    }
}
