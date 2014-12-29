using DissDlcToolkit.Models;
using DissDlcToolkit.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DissDlcToolkit
{
    /**
     * This partial class handles all callbacks from the
     * "DLC Generation" tab
     */

    public partial class MainForm
    {
        // Variable which controls whether we selected a character suitable for 
        // extra GIM file
        private Boolean dlcGenPlayerGimFileExtraEnabled = false;
        private Boolean dlcGenAssistEnabled = true;
        
        private void InitializeDlcGenTab()
        {
            // Config costume slot keys & values
            ArrayList dlcGenCostumeSlotKeyValues = new ArrayList();
            for (Byte i = 1; i <= 9; i++){
                KeyValuePair<Byte, String> data = new KeyValuePair<Byte, String>((byte)(i + (byte)3), "DLC " + i);
                dlcGenCostumeSlotKeyValues.Add(data);
            }
            dlcGenCostumeSlotComboBox.DataSource = dlcGenCostumeSlotKeyValues;
            dlcGenCostumeSlotComboBox.DisplayMember = "Value";
            dlcGenCostumeSlotComboBox.ValueMember = "Key";


            // Config player & assist DLC slots
            ArrayList dlcGenDlcSlotsKeyValues = new ArrayList();
            for (UInt16 i = 1; i <= 255; i++)
            {
                KeyValuePair<UInt16, int> data = new KeyValuePair<UInt16, int>((UInt16)(0x2C0+(i-1)), i);
                dlcGenDlcSlotsKeyValues.Add(data);
            }
            dlcGenPlayerDlcSlotComboBox.DataSource = dlcGenDlcSlotsKeyValues;
            dlcGenPlayerDlcSlotComboBox.DisplayMember = "Value";
            dlcGenPlayerDlcSlotComboBox.ValueMember = "Key";
            // Use a copy of the array here so it doesn't change while changing player slot value
            dlcGenAssistDlcSlotComboBox.DataSource = dlcGenDlcSlotsKeyValues.Clone();
            dlcGenAssistDlcSlotComboBox.DisplayMember = "Value";
            dlcGenAssistDlcSlotComboBox.ValueMember = "Key";

            // Config character data
            ArrayList dlcGenCharacterKeyValues = new ArrayList();
            foreach (CharacterData data in GlobalData.getInstance().characterDataList)
            {
                dlcGenCharacterKeyValues.Add(data);
            }
            dlcGenCharacterComboBox.DataSource = dlcGenCharacterKeyValues;
        }

        private void dlcGenCharacterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if we have selected Cecil (p_for100); if we did, then enable second GIM box
            dlcGenPlayerGimFileExtraEnabled = ((CharacterData)dlcGenCharacterComboBox.SelectedValue).internalName.Equals("p_for100");
            dlcGenBrowsePlayerGimFileExtraButton.Enabled = dlcGenPlayerGimFileExtraEnabled;
            // Clear extra GIM box if we select anything other than Cecil
            if (!dlcGenPlayerGimFileExtraEnabled)
            {
                dlcGenPlayerGimFileExtraTextBox.Text = "";
            }
            // Also check if we're creating a DLC for Feral Chaos (p_org210), as it can't have an assist
            dlcGenAssistEnabled = !((CharacterData)dlcGenCharacterComboBox.SelectedValue).internalName.Equals("p_org210");
            dlcGenAssistDlcSlotComboBox.Enabled = dlcGenAssistEnabled;
            dlcGenBrowseAssistGmoButton.Enabled = dlcGenAssistEnabled;
            // Clear assist data if it's not enabled
            if (!dlcGenAssistEnabled)
            {
                dlcGenAssistGmoFileTextBox.Text = "";
            }
        }

        private void dlcGenBrowsePlayerGmoButton_Click(object sender, EventArgs e)
        {
            dlcGenPlayerGmoFileTextBox.Text = openGmoFileDialog();
        }

        private void dlcGenBrowsePlayerGimFileMainButton_Click(object sender, EventArgs e)
        {
            dlcGenPlayerGimFileMainTextBox.Text = openGimFileDialog();
        }

        private void dlcGenBrowsePlayerGimFileExtraButton_Click(object sender, EventArgs e)
        {
            dlcGenPlayerGimFileExtraTextBox.Text = openGimFileDialog();
        }

        private void dlcGenBrowseAssistGmoButton_Click(object sender, EventArgs e)
        {
            dlcGenAssistGmoFileTextBox.Text = openGmoFileDialog();
        }

        private void dlcGenGenerateButton_Click(object sender, EventArgs e)
        {
            generateDlcFiles();
        }


        private void generateDlcFiles()
        {
            // Get needed data for generating the DLC
            Byte costumeDlcSlot = (Byte)dlcGenCostumeSlotComboBox.SelectedValue;

            int playerDlcSlotNumber = (int)dlcGenPlayerDlcSlotComboBox.SelectedIndex+1;
            UInt16 playerDlcSlotId = (UInt16)dlcGenPlayerDlcSlotComboBox.SelectedValue;
            int assistDlcSlotNumber = (int)dlcGenAssistDlcSlotComboBox.SelectedIndex + 1;
            UInt16 assistDlcSlotId = (UInt16)dlcGenAssistDlcSlotComboBox.SelectedValue;            

            String playerGmoFile = dlcGenPlayerGmoFileTextBox.Text;
            String playerGimMainFile = dlcGenPlayerGimFileMainTextBox.Text;
            String playerGimExtraFile = dlcGenPlayerGimFileExtraTextBox.Text;

            String assistGmoFile = dlcGenAssistGmoFileTextBox.Text;

            // Checks for consistency
            if (playerGmoFile.Equals("") || playerGimMainFile.Equals(""))
            {
                MessageBox.Show("You need to select at least a player GMO & GIM");
                return;
            }

            if (dlcGenAssistEnabled)
            {
                if (!assistGmoFile.Equals(""))                
                {
                    if (playerDlcSlotNumber == assistDlcSlotNumber)
                    {
                        MessageBox.Show("Set different slots for player and assist DLC slots");
                        return;
                    }
                }
            }

            // TODO: clone this object
            CharacterData characterData = (CharacterData)dlcGenCharacterComboBox.SelectedValue;

            // Generate player DLC (it must always be generated)
            // Create needed folders
            String baseFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            String dlcDirectoryFolder = System.IO.Path.Combine(baseFolder, "dlc");
            String dlcFolder = System.IO.Path.Combine(dlcDirectoryFolder, "[" + dlcGenCostumeSlotComboBox.Text + "]" + "[" + dlcGenCharacterComboBox.Text + "]");
            if (Directory.Exists(dlcFolder))
            {
                Directory.Delete(dlcFolder, true);
            }
            Directory.CreateDirectory(dlcFolder);

            // Compose DLC data
            ObjectTable playerObjectTable = characterData.characterObjectTable;
            ObjectEntry playerObjectEntry = (ObjectEntry)playerObjectTable.entries[0];

            playerObjectEntry.costumeId = costumeDlcSlot;
            playerObjectEntry.id = playerDlcSlotId;
            playerObjectEntry.objectEntrySlot = Convert.ToByte(playerDlcSlotNumber);
            playerObjectEntry.modelName = characterData.internalName.ToUpper() + "_" + costumeDlcSlot.ToString("X") + "P";

            // Get hashed filenames, so the game can read them
            String objectTableHashFileName = Hasher.hash("dlc/obj/dlc_" + playerDlcSlotNumber.ToString("d3") + "oe.bin") +".edat";
            String playerGmoHashFileName = Hasher.hash(("obj/" + playerObjectEntry.modelName + ".gmo").ToLower()) + ".edat";
            String cosxHashFileName = Hasher.hash(("obj/" + playerObjectEntry.modelName + ".cosx").ToLower()) + ".edat";
            String exexHashFileName = Hasher.hash(("obj/" + playerObjectEntry.modelName + ".exex").ToLower()) + ".edat";
            String gimMainHashFileName = Hasher.hash(("menu/JP/battle/chara_image/" + playerObjectEntry.modelName + ".gim").ToLower()) + ".edat";
            String gimExtraHashFileName = Hasher.hash(("menu/JP/battle/chara_image/" + playerObjectEntry.modelName + "_2.gim").ToLower()) + ".edat";
            
            // Write player files in DLC folder            
            String readmeFilePath = System.IO.Path.Combine(dlcFolder, "readme.txt");
            using (StreamWriter readmeFileWriter = new StreamWriter(new FileStream(readmeFilePath, FileMode.Create)))
            {
                ResourceManager rm = new ResourceManager("DissDlcToolkit.Properties.Resources", Assembly.GetExecutingAssembly());

                readmeFileWriter.WriteLine(dlcGenCharacterComboBox.Text + " " + dlcGenCostumeSlotComboBox.Text);
                readmeFileWriter.WriteLine("-----------------------");
                readmeFileWriter.WriteLine("Player object entry slot: " + playerDlcSlotNumber.ToString());
                readmeFileWriter.WriteLine("Player object entry ID: " + MiscUtils.swapEndianness(playerDlcSlotId).ToString("X4"));
                readmeFileWriter.WriteLine("-----------------------");                
                
                playerObjectTable.writeToFile(System.IO.Path.Combine(dlcFolder, objectTableHashFileName));
                readmeFileWriter.WriteLine("Player object entry (BIN):\t"+objectTableHashFileName);
                
                File.Copy(playerGmoFile, System.IO.Path.Combine(dlcFolder, playerGmoHashFileName));
                readmeFileWriter.WriteLine("Player model (GMO):\t\t" + playerGmoHashFileName);
                
                File.Copy(playerGimMainFile, System.IO.Path.Combine(dlcFolder, gimMainHashFileName));
                readmeFileWriter.WriteLine("Player portrait (GIM):\t\t" + gimMainHashFileName);

                if (dlcGenPlayerGimFileExtraEnabled)
                {
                    File.Copy(playerGimExtraFile, System.IO.Path.Combine(dlcFolder, gimExtraHashFileName));
                    readmeFileWriter.WriteLine("Player extra portrait (GIM):\t" + gimExtraHashFileName);
                }
                
                byte[] cosxBuffer = (byte[])rm.GetObject(characterData.internalName.ToUpper() + "_COSX");
                if (cosxBuffer != null)
                {
                    File.WriteAllBytes(System.IO.Path.Combine(dlcFolder, cosxHashFileName), cosxBuffer);
                    readmeFileWriter.WriteLine("Player costume effects (COSX):\t" + cosxHashFileName);
                }

                byte[] exexBuffer = (byte[])rm.GetObject(characterData.internalName.ToUpper() + "_EXEX");
                if (exexBuffer != null)
                {
                    File.WriteAllBytes(System.IO.Path.Combine(dlcFolder, exexHashFileName), exexBuffer);
                    readmeFileWriter.WriteLine("Player EX Mode effects (EXEX):\t" + exexHashFileName);
                }

                readmeFileWriter.WriteLine("-----------------------");
            }

            // Generate assist DLC (if needed)

            if (dlcGenAssistEnabled && !dlcGenAssistGmoFileTextBox.Text.Equals(""))
            {
                // Compose DLC data
                ObjectTable assistObjectTable = characterData.assistObjectTable;
                ObjectEntry assistObjectEntry = (ObjectEntry)assistObjectTable.entries[0];

                assistObjectEntry.costumeId = costumeDlcSlot;
                assistObjectEntry.id = assistDlcSlotId;
                assistObjectEntry.objectEntrySlot = Convert.ToByte(assistDlcSlotNumber);
                assistObjectEntry.modelName = characterData.internalName.ToUpper() + "_" + costumeDlcSlot.ToString("X") + "P_A";

                // Get hashed filenames, so the game can read them
                String assistObjectTableHashFileName = Hasher.hash("dlc/obj/dlc_" + assistDlcSlotNumber.ToString("d3") + "oe.bin") + ".edat";
                String assistGmoHashFileName = Hasher.hash(("obj/" + assistObjectEntry.modelName + ".gmo").ToLower()) + ".edat";

                // Write assist files in DLC folder 
                using (StreamWriter readmeFileWriter = new StreamWriter(new FileStream(readmeFilePath, FileMode.Append)))
                {
                    ResourceManager rm = new ResourceManager("DissDlcToolkit.Properties.Resources", Assembly.GetExecutingAssembly());

                    readmeFileWriter.WriteLine("Assist object entry slot: " + assistDlcSlotNumber.ToString());
                    readmeFileWriter.WriteLine("Assist object entry ID: " + MiscUtils.swapEndianness(assistDlcSlotId).ToString("X4"));
                    readmeFileWriter.WriteLine("-----------------------");

                    assistObjectTable.writeToFile(System.IO.Path.Combine(dlcFolder, assistObjectTableHashFileName));
                    readmeFileWriter.WriteLine("Assist object entry (BIN):\t" + assistObjectTableHashFileName);

                    File.Copy(playerGmoFile, System.IO.Path.Combine(dlcFolder, assistGmoHashFileName));
                    readmeFileWriter.WriteLine("Assist model (GMO):\t\t" + assistGmoHashFileName);

                    readmeFileWriter.WriteLine("-----------------------");
                }
            }

            MessageBox.Show("Success!");
        }
    }
}
