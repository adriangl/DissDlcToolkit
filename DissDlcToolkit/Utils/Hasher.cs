using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissDlcToolkit.Utils
{
    class Hasher
    {
        public static String hash(String s){		    
		    byte[] byteArray = Encoding.ASCII.GetBytes(s);
            CRC crc = new CRC();
		    foreach (byte b in byteArray){
			    crc.UpdateCRC(b);
		    }
            return crc.GetFinalCRC().ToString("x8");
	    }
    }
}
