using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DissDlcToolkit.Utils
{
    class MessFileWriter
    {
        private static String KEY = "98edab90285e4284b132da2d57a6bfc833009a5727f24c4ba7367d929d73ce84";
	
	    private static byte[] currentKey;
	
	    public static String encodeDLCText(List<String> list, String path){	    
		
		    int stringNumber = list.Count;
            addStringTerminatorToElements(list);
		    int[] stringOffsets = calculateStringOffsets(list);
		
		    currentKey = hexStringToByteArray(KEY);
		    
            using (BinaryWriter writer = new BinaryWriter(new FileStream(path, FileMode.Create))){
                // Put number of strings
		        writer.Write((short)(stringNumber));
		
		        foreach (int i in stringOffsets){
			        writer.Write((short) i);
		        }
		
		        foreach (String s in list){
			        int characterCount = s.Length*2; // Unicode 16 bits -> 2 bytes
			        if (characterCount != 0 && !s.Equals(Char.MinValue)){
                        writer.Write((short)characterCount);
				        byte[] stringBytes = Encoding.Unicode.GetBytes(s);
				        byte[] encoded = xor(stringBytes, currentKey);
                        writer.Write(encoded);
			        }
			        rotateKey(currentKey);
		        }
            }

		    return path;		
	    }

        private static void addStringTerminatorToElements(List<string> list)
        {
            for (int i = 0; i < list.Count; i++) 
            {
                String s = list[i];
                if (!s.Contains(Char.MinValue))
                {
                    list[i] = s + Char.MinValue;
                }
            }
        }
	
	    private static int calculateFileSize(List<String> list) {
		    int size = 0;
		    int totalStrings = 0;
		    foreach (String s in list){
			    if (!s.Equals(Char.MinValue)){
				    size += s.Length*2;
				    totalStrings++;
			    }
		    }
		    size += 2*(list.Count+1);
		    size += 2*(totalStrings);
		    return size;
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

	    private static int[] calculateStringOffsets(List<String> list) {
		    int[] offsetList = new int[list.Count];
		    int headerSize = 2*(list.Count+1);
		
		    bool firstStringFound = false;
		
		    int nextOffset = 0;		
		    for (int i = 0; i<list.Count; i++){
			    if (!list[i].Equals(Char.MinValue) || list[i].Length == 0){
				    if (!firstStringFound){
					    offsetList[i] = headerSize/2;
					    nextOffset = headerSize;
					    firstStringFound = true;
				    }
				    else{
					    String s = getPreviousValidString(list, i-1);
					    if (s == null){
						    offsetList[i] = 0;
					    }
					    else{
						    int stringLength = s.Length*2; // Unicode 16 bits -> 2 bytes
						    nextOffset += stringLength +2;
						    offsetList[i] = nextOffset/2;
					    }
				    }
			    }
			    else{
				    offsetList[i] = 0;
			    }
		    }
		    return offsetList;
	    }
	
	    private static String getPreviousValidString(List<String> list, int i) {
		    if (i <0){
			    return null;
		    }
		    String s = list[i];
		    if (!s.Equals(Char.MinValue)){
			    return s;
		    }
		    else{
			    return getPreviousValidString(list, i-1);
		    }
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
				    catch (IndexOutOfRangeException e){
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
