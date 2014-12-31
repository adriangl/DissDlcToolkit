using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DissDlcToolkit.Utils;
using DissDlcToolkit.Models;

namespace DissDlcToolkit.Forms
{
    public partial class MainFormDlcReporterUserControl : UserControl
    {
        public MainFormDlcReporterUserControl()
        {
            InitializeComponent();
        }

        private void reporterLoadFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Open the folder where the DLC are located.";
                dialog.ShowNewFolderButton = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string folder = dialog.SelectedPath;
                    reporterFolderLabel.Text = folder;
                    reportSelectedFolder(folder);
                }
            }
        }

        private void reportSelectedFolder(String folder)
        {
            for (int i = 1; i <= 999; i++)
            {
                String objectTableHashFileName = Hasher.hash("dlc/obj/dlc_" + i.ToString("d3") + "oe.bin") + ".edat";
                String pathToSearch = System.IO.Path.Combine(folder, objectTableHashFileName);
                if (File.Exists(pathToSearch))
                {
                    // We have found an object table inside the folder; scan it and print results in TextBox
                    StringBuilder builder = new StringBuilder();
                    ObjectTable hashedFileObjectTable = new ObjectTable(pathToSearch);
                    foreach (ObjectEntry entry in hashedFileObjectTable.entries)
                    {
                        builder.AppendLine("DLC Slot: " + i);
                        builder.AppendLine("Character: "+ GlobalData.getInstance().getCharacterNameFromId(entry.characterId));
                        builder.AppendLine("Type: "+entry.getFormattedObjectEntryType());
                        builder.AppendLine("DLC ID: "+MiscUtils.swapEndianness(entry.id).ToString("X4"));
                        builder.AppendLine("DLC Model name: " + entry.modelName);
                        builder.AppendLine("DLC .objx name: " + entry.objxName);
                        builder.AppendLine("Files:");
                        builder.AppendLine("\tController file: " + objectTableHashFileName);
                        // Check if extra data exist, and print it
                        printIfExists("\tGMO File:", folder, Hasher.hash(("obj/" + entry.modelName + ".gmo").ToLower()) + ".edat", builder);
                        printIfExists("\tGIM File:", folder, Hasher.hash(("menu/JP/battle/chara_image/" + entry.modelName + ".gim").ToLower()) + ".edat", builder);
                        printIfExists("\tGIM Extra File:", folder, Hasher.hash(("menu/JP/battle/chara_image/" + entry.modelName + "_2.gim").ToLower()) + ".edat", builder);
                        printIfExists("\tCOSX File:", folder, Hasher.hash(("obj/" + entry.modelName + ".cosx").ToLower()) + ".edat", builder);
                        printIfExists("\tEXEX File:", folder, Hasher.hash(("obj/" + entry.modelName + ".exex").ToLower()) + ".edat", builder);
                        printIfExists("\tOBJX File:", folder, Hasher.hash(("obj/" + entry.modelName + ".objx").ToLower()) + ".edat", builder);
                        builder.AppendLine("--------------------------------------");
                        reporterDataTextBox.AppendText(builder.ToString());
                    }                 
                    
                }
            }
            
        }

        private void printIfExists(string description, string folder, string fileName, StringBuilder builder)
        {
            if (File.Exists(System.IO.Path.Combine(folder, fileName)))
            {
                builder.AppendLine(description + " " + fileName);
            }
        }   
    }
}
