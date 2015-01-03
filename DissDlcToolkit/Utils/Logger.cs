using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissDlcToolkit.Utils
{
    /**
     * Simple logger class which saves exception messages to a file in the executable's path
     */
    class Logger
    {
        private static String logFilePath = System.IO.Path.Combine(
            System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location),
            "log.txt");

        public static void Log(String tag, Exception ex)
        {
            Log(tag, ex.Message + "\r\n" + ex.StackTrace);
        }
        
        public static void Log(String tag, String message)
        {
            try
            {
                Directory.CreateDirectory(Directory.GetParent(logFilePath).FullName);
                using (StreamWriter writer = new StreamWriter(new FileStream(logFilePath, FileMode.Append)))
                {
                    writer.WriteLine(DateTime.Now.ToString() + " " + tag + ": " + message);
                    writer.WriteLine();
                }
            }
            catch (Exception e)
            {
                return;
            }
        }
    }
}
