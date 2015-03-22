using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DissDlcToolkit.Utils
{
    class MessFileReader
    {
        private const String KEY = "98edab90285e4284b132da2d57a6bfc833009a5727f24c4ba7367d929d73ce84";
	
	    private static byte[] currentKey;
	
	    public static ArrayList decodeDLCText(String filePath){
		    ArrayList list = new ArrayList();
		    currentKey = hexStringToByteArray(KEY);
		
		    try {
                using (BinaryReader reader = new BinaryReader(new FileStream(filePath, FileMode.Open)))
                {
			        UInt16 stringNumber = getStringNumber(reader);			
			        UInt16[] textOffsets = getStringOffsets(reader, stringNumber);
			
			        foreach (UInt16 offset in textOffsets){
                        String s = "";
				        if (offset != 0){
					        s = getStringFromOffset(reader, offset);
                        }
					    list.Add(s.Replace("\0", string.Empty));
				        rotateKey(currentKey);
			        }
                }
			
		    } catch (FileNotFoundException e) {
                Logger.Log("AAA", e);
		    }
		    return list;
	    }

	    private static void rotateKey(byte[] key) {
		    int length = key.Length;
		    // Get 4 first bytes
		    byte[] header = new byte[]{key[0], key[1]};
		
		    for (int i = 2; i< length; i++){
			    key[i-2] = key[i];
		    }
		
		    key[length-1] = header[1];
		    key[length-2] = header[0];	
	    }

	    private static String getStringFromOffset(BinaryReader reader, int offset) {
            FileStream readerStream = (FileStream)reader.BaseStream;
		    int uOffset = offset * 2;
		    try {
			    readerStream.Seek(uOffset, SeekOrigin.Begin);
                UInt16 stringLength = reader.ReadUInt16();
			
			    byte[] textBuffer = new byte[stringLength];
                reader.Read(textBuffer, 0, stringLength);
			
			    byte[] decodedBytes = xor(textBuffer, currentKey);

                return Encoding.Unicode.GetString(decodedBytes);
		    } catch (IOException e) {
			    // TODO Auto-generated catch block
                Logger.Log("AAA", e);
		    }
		    return null;
	    }

	    private static UInt16[] getStringOffsets(BinaryReader reader, UInt16 stringNumber) {
		    UInt16[] stringOffsets = new UInt16[stringNumber];
			try {
                for (int i = 0; i < stringNumber; i++)
                {                    
                    stringOffsets[i] = reader.ReadUInt16();
                }                
			} catch (IOException e) {
				// TODO Auto-generated catch block
                Logger.Log("AAA", e);
			}
			
		    return stringOffsets;
	    }

	    private static UInt16 getStringNumber(BinaryReader reader) {
		    try {
               return reader.ReadUInt16();
		    } catch (IOException e) {
			    // TODO Auto-generated catch block
                Logger.Log("AAA", e);
		    }
		    return 0;
	    }
	
	    public static byte[] hexStringToByteArray(String hex) {
            return Enumerable.Range(0, hex.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                     .ToArray();
	    }
	
	    public static byte[] xor(byte[] b1, byte[] b2){
		
		    int minLength = b2.Length;
		
		    int iterations = getNextInteger((float)b1.Length/(float)minLength);
		
		    byte[] finalByte = new byte[b1.Length];
		
		    for (int j = 0; j < iterations; j++){
			    for (int i = 0; i<minLength; i++){
				    try{
					    int index = (j*minLength)+i;
					    finalByte[index] = (byte) (b1[index] ^ b2[i]);
				    }
				    catch (Exception e){
					    break;
				    }
			    }
		    }
		
		    return finalByte;
	    }
	
	    private static int getNextInteger(float f) {
		    double floor = Math.Floor((double)f);
		    if (floor != f){
			    return (int) (floor + 1);
		    }
		    return (int)floor;
	    }
    }
}
