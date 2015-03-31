using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DissDlcToolkit
{
    /**
     * Main class to save/load settings
     */
    class Settings
    {
        
        public static void setDlcMainFolder(string folder)
        {
            Properties.Settings.Default.dlcMainFolder = folder;
            Properties.Settings.Default.Save();
        }

        public static String getDlcMainFolder()
        {
            // First, check if there is any saved data
            String dlcMainFolder = Properties.Settings.Default.dlcMainFolder;
            // Then load the value
            if (dlcMainFolder == null || dlcMainFolder.Trim().Equals(""))
            {
                dlcMainFolder = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "dlc");
                setDlcMainFolder(dlcMainFolder);
            }
            return dlcMainFolder;
        }

        public static bool getBackupExexSetting()
        {
            return Properties.Settings.Default.createExexBackupWhenSaving;
        }

        public static void setBackupExexSetting(bool enabled)
        {
            Properties.Settings.Default.createExexBackupWhenSaving = enabled;
            Properties.Settings.Default.Save();
        }
    }
}
