using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DissDlcToolkit.Models;
using System.IO;
using DissDlcToolkit.Utils;
using System.Resources;
using System.Reflection;

namespace DissDlcToolkit.Forms
{
    public partial class MainFormDlcGenUserControl : UserControl
    {
        private const string TAG = "MainFormDlcGenUserControl";
        // Variable which controls whether we selected a character suitable for 
        // extra GIM file
        private Boolean dlcGenPlayerGimFileExtraEnabled = false;
        // Variable which controls if assist data is enabled
        private Boolean dlcGenAssistEnabled = true;
        // Variable which controls if player data is enabled
        private Boolean dlcGenPlayerGmoGimEnabled = true;


        public MainFormDlcGenUserControl()
        {
            InitializeComponent();
            InitializeDlcGenTab();
        }       

        private void InitializeDlcGenTab()
        {
            // Config player & assist DLC slots
            ArrayList dlcGenDlcSlotsKeyValues = new ArrayList();
            for (UInt16 i = 1; i <= 255; i++)
            {
                KeyValuePair<UInt16, int> data = new KeyValuePair<UInt16, int>((UInt16)(0x2C0 + (i - 1)), i);
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
            FormUtils.genericValidateComboBox(sender);
            configCostumeSlots();
            configPlayerEnabled();
            configAssistEnabled();
            configGimExtraEnabled();
        }

        private void configPlayerEnabled()
        {
            // Check if we're creating a DLC for Aerith (p_sev120), as it won't have player GMOs and GIMs
            dlcGenPlayerGmoGimEnabled = !((CharacterData)dlcGenCharacterComboBox.SelectedValue).internalName.Equals("p_sev120");
            dlcGenBrowsePlayerGmoButton.Enabled = dlcGenPlayerGmoGimEnabled;
            dlcGenBrowsePlayerGimFileMainButton.Enabled = dlcGenPlayerGmoGimEnabled;
            dlcGenBrowsePlayerGimFileExtraButton.Enabled = dlcGenPlayerGmoGimEnabled;
            // Clear assist data if it's not enabled
            if (!dlcGenPlayerGmoGimEnabled)
            {
                dlcGenPlayerGmoFileTextBox.Text = "";
                dlcGenPlayerGimFileMainTextBox.Text = "";
                dlcGenPlayerGimFileExtraTextBox.Text = "";
            }
        }

        private void configAssistEnabled()
        {
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

        private void configGimExtraEnabled()
        {
            // Check if we have selected Cecil (p_for100); if we did, then enable second GIM box
            dlcGenPlayerGimFileExtraEnabled = ((CharacterData)dlcGenCharacterComboBox.SelectedValue).internalName.Equals("p_for100");
            dlcGenBrowsePlayerGimFileExtraButton.Enabled = dlcGenPlayerGimFileExtraEnabled;
            // Clear extra GIM box if we select anything other than Cecil
            if (!dlcGenPlayerGimFileExtraEnabled)
            {
                dlcGenPlayerGimFileExtraTextBox.Text = "";
            }
        }

        private void configCostumeSlots()
        {
            // Get selected character internal name
            String selectedCharacterInternalName = ((CharacterData)dlcGenCharacterComboBox.SelectedValue).internalName;
            // Config costume slot keys & values depending on which can be used for characters
            ArrayList dlcGenCostumeSlotKeyValues = new ArrayList();
            // Add "Normal", "Alt. 1" & "Alt. 2" Slots
            dlcGenCostumeSlotKeyValues.Add(new KeyValuePair<Byte, String>(0x01, "Normal"));
            dlcGenCostumeSlotKeyValues.Add(new KeyValuePair<Byte, String>(0x02, "Alt. 1"));
            // Feral Chaos doesn't have an "Alt. 2" costume, don't add it
            if (!selectedCharacterInternalName.Equals("p_org210"))
            {
                dlcGenCostumeSlotKeyValues.Add(new KeyValuePair<Byte, String>(0x03, "Alt. 2"));
            }
            // Add manikin slot; Aerith and Feral Chaos can't have them
            // Also disable manikin effects box
            if (!selectedCharacterInternalName.Equals("p_org210") && !selectedCharacterInternalName.Equals("p_sev120"))
            {
                dlcGenCostumeSlotKeyValues.Add(new KeyValuePair<Byte, String>(0x00, "Manikin"));
                dlcGenIncludeManikinEffects.Enabled = true;                
            }
            else
            {
                dlcGenIncludeManikinEffects.Enabled = false;
                dlcGenIncludeManikinEffects.Checked = false;
            }
            // Add "DLC x" Slots
            // Aerith can't use DLC x Slots (yet), don't add them in this case
            if (!selectedCharacterInternalName.Equals("p_sev120"))
            {
                for (Byte i = 1; i <= 9; i++)
                {
                    KeyValuePair<Byte, String> data = new KeyValuePair<Byte, String>((byte)(i + (byte)3), "DLC " + i);
                    dlcGenCostumeSlotKeyValues.Add(data);
                }
            }            
            dlcGenCostumeSlotComboBox.DataSource = dlcGenCostumeSlotKeyValues;
            dlcGenCostumeSlotComboBox.DisplayMember = "Value";
            dlcGenCostumeSlotComboBox.ValueMember = "Key";
        }

        private void dlcGenBrowsePlayerGmoButton_Click(object sender, EventArgs e)
        {
            dlcGenPlayerGmoFileTextBox.Text = FormUtils.openGmoFileDialog();
        }

        private void dlcGenBrowsePlayerGimFileMainButton_Click(object sender, EventArgs e)
        {
            dlcGenPlayerGimFileMainTextBox.Text = FormUtils.openGimFileDialog();
        }

        private void dlcGenBrowsePlayerGimFileExtraButton_Click(object sender, EventArgs e)
        {
            dlcGenPlayerGimFileExtraTextBox.Text = FormUtils.openGimFileDialog();
        }

        private void dlcGenBrowseAssistGmoButton_Click(object sender, EventArgs e)
        {
            dlcGenAssistGmoFileTextBox.Text = FormUtils.openGmoFileDialog();
        }

        private void dlcGenGenerateButton_Click(object sender, EventArgs e)
        {
            generateDlcFiles();
        }


        private void generateDlcFiles()
        {
            // Validate ComboBox Data against null values
            if (dlcGenCharacterComboBox.SelectedItem == null
                || dlcGenCostumeSlotComboBox.SelectedItem == null
                || dlcGenPlayerDlcSlotComboBox.SelectedItem == null
                || dlcGenAssistDlcSlotComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select valid values in the highlighted fields.");
                return;
            }


            // Get needed data for generating the DLC
            Byte costumeDlcSlot = (Byte)dlcGenCostumeSlotComboBox.SelectedValue;

            int playerDlcSlotNumber = (int)dlcGenPlayerDlcSlotComboBox.SelectedIndex + 1;
            UInt16 playerDlcSlotId = (UInt16)dlcGenPlayerDlcSlotComboBox.SelectedValue;
            int assistDlcSlotNumber = (int)dlcGenAssistDlcSlotComboBox.SelectedIndex + 1;
            UInt16 assistDlcSlotId = (UInt16)dlcGenAssistDlcSlotComboBox.SelectedValue;

            String playerGmoFile = dlcGenPlayerGmoFileTextBox.Text;
            String playerGimMainFile = dlcGenPlayerGimFileMainTextBox.Text;
            String playerGimExtraFile = dlcGenPlayerGimFileExtraTextBox.Text;

            String assistGmoFile = dlcGenAssistGmoFileTextBox.Text;

            // Checks for consistency
            if (dlcGenPlayerGmoGimEnabled)
            {
                if (playerGmoFile.Equals("") || playerGimMainFile.Equals(""))
                {
                    if (dlcGenPlayerGimFileExtraEnabled && playerGimExtraFile.Equals(""))
                    {
                        // Cecil Only
                        MessageBox.Show("You need to select at least a player GMO & GIMs (main and extra)");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("You need to select at least a player GMO & GIM");
                        return;
                    }
                }                
            }
            else
            {
                // No player files enabled (Aerith only)
                if (dlcGenAssistEnabled)
                {
                    if (assistGmoFile.Equals(""))
                    {
                        MessageBox.Show("You need to select an assist GMO");
                        return;
                    }
                }
            }

            // Check that we're not trying to use the same DLC slots for player and assist (if they both need
            // to be generated)
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
            
            // Create needed folders; base folder by default will be in the same path as the executable
            String baseFolder = Settings.getDlcMainFolder();
            String dlcFolder = System.IO.Path.Combine(baseFolder, "[" + dlcGenCostumeSlotComboBox.Text + "]" + "[" + dlcGenCharacterComboBox.Text + "]");
            deleteNewDlcFolder(dlcFolder);
            Directory.CreateDirectory(dlcFolder);

            // Generate readme file path
            String readmeFilePath = System.IO.Path.Combine(dlcFolder, "readme.txt");

            // Generate player DLC (it must always be generated)            
            // Compose DLC data
            ObjectTable playerObjectTable = characterData.characterObjectTable;
            ObjectEntry playerObjectEntry = (ObjectEntry)playerObjectTable.entries[0];

            playerObjectEntry.costumeId = costumeDlcSlot;
            // If it's a DLC X costume add corresponding ID; if it isn't, put proper data
            switch (costumeDlcSlot)
            {
                case ObjectEntry.COSTUME_SLOT_MANIKIN: // Manikin
                    playerObjectEntry.id = characterData.manikinPlayerID;
                    break;
                case ObjectEntry.COSTUME_SLOT_NORMAL: // Normal
                    playerObjectEntry.id = characterData.normalPlayerID;
                    break;
                case ObjectEntry.COSTUME_SLOT_ALT1: // Alt. 1
                    playerObjectEntry.id = characterData.alt1PlayerID;
                    break;
                case ObjectEntry.COSTUME_SLOT_ALT2: // Alt. 2
                    playerObjectEntry.id = characterData.alt2PlayerID;
                    break;
                default: // DLC X; estimate it
                    playerObjectEntry.id = playerDlcSlotId;
                    break;
            }
            playerObjectEntry.objectEntrySlot = Convert.ToByte(playerDlcSlotNumber);
            playerObjectEntry.modelName = (costumeDlcSlot != ObjectEntry.COSTUME_SLOT_MANIKIN)
                ? characterData.internalName.ToUpper() + "_" + costumeDlcSlot.ToString("X") + "P"
                : characterData.internalName.ToUpper() + "_ZAKO";

            // If the user marks the 'include manikin voices & effects', add flag
            if (dlcGenIncludeManikinEffects.Checked)
            {
                playerObjectEntry.objectEntryType = ObjectEntry.DLC_TYPE_MANIKIN_PLAYER;
            }
            

            // Get hashed filenames, so the game can read them
            String objectTableHashFileName = Hasher.hash("dlc/obj/dlc_" + playerDlcSlotNumber.ToString("d3") + "oe.bin") + ".edat";
            String playerGmoHashFileName = Hasher.hash(("obj/" + playerObjectEntry.modelName + ".gmo").ToLower()) + ".edat";
            String cosxHashFileName = Hasher.hash(("obj/" + playerObjectEntry.modelName + ".cosx").ToLower()) + ".edat";
            String exexHashFileName = Hasher.hash(("obj/" + playerObjectEntry.modelName + ".exex").ToLower()) + ".edat";
            String gimMainHashFileName = Hasher.hash(("menu/JP/battle/chara_image/" + playerObjectEntry.modelName + ".gim").ToLower()) + ".edat";
            String gimExtraHashFileName = Hasher.hash(("menu/JP/battle/chara_image/" + playerObjectEntry.modelName + "_2.gim").ToLower()) + ".edat";

            // Write player files in DLC folder
            using (StreamWriter readmeFileWriter = new StreamWriter(new FileStream(readmeFilePath, FileMode.Create)))
            {
                try
                {
                    ResourceManager rm = new ResourceManager("DissDlcToolkit.Properties.Resources", Assembly.GetExecutingAssembly());

                    readmeFileWriter.WriteLine(dlcGenCharacterComboBox.Text + " " + dlcGenCostumeSlotComboBox.Text);
                    readmeFileWriter.WriteLine("-----------------------");
                    readmeFileWriter.WriteLine("Player object entry slot: " + playerDlcSlotNumber.ToString());
                    readmeFileWriter.WriteLine("Player object entry ID: " + MiscUtils.swapEndianness(playerObjectEntry.id).ToString("X4"));
                    readmeFileWriter.WriteLine("-----------------------");

                    playerObjectTable.writeToFile(System.IO.Path.Combine(dlcFolder, objectTableHashFileName));
                    readmeFileWriter.WriteLine("Player object entry (BIN):\t" + objectTableHashFileName);

                    // If selected character is other than Aerith, add player models, portraits and exex file
                    if (dlcGenPlayerGmoGimEnabled)
                    {
                        File.Copy(playerGmoFile, System.IO.Path.Combine(dlcFolder, playerGmoHashFileName));
                        readmeFileWriter.WriteLine("Player model (GMO):\t\t" + playerGmoHashFileName);

                        File.Copy(playerGimMainFile, System.IO.Path.Combine(dlcFolder, gimMainHashFileName));
                        readmeFileWriter.WriteLine("Player portrait (GIM):\t\t" + gimMainHashFileName);

                        if (dlcGenPlayerGimFileExtraEnabled)
                        {
                            File.Copy(playerGimExtraFile, System.IO.Path.Combine(dlcFolder, gimExtraHashFileName));
                            readmeFileWriter.WriteLine("Player extra portrait (GIM):\t" + gimExtraHashFileName);
                        }

                        byte[] exexBuffer = (byte[])rm.GetObject(characterData.internalName.ToUpper() + "_EXEX" + ((dlcGenIncludeManikinEffects.Checked) ? "_ZAKO" : ""));
                        if (exexBuffer != null)
                        {
                            File.WriteAllBytes(System.IO.Path.Combine(dlcFolder, exexHashFileName), exexBuffer);
                            readmeFileWriter.WriteLine("Player EX Mode effects (EXEX):\t" + exexHashFileName);
                        }
                    }

                    byte[] cosxBuffer = (byte[])rm.GetObject(characterData.internalName.ToUpper() + "_COSX" + ((dlcGenIncludeManikinEffects.Checked) ? "_ZAKO" : ""));
                    if (cosxBuffer != null)
                    {
                        File.WriteAllBytes(System.IO.Path.Combine(dlcFolder, cosxHashFileName), cosxBuffer);
                        readmeFileWriter.WriteLine("Player costume effects (COSX):\t" + cosxHashFileName);
                    }

                    readmeFileWriter.WriteLine("-----------------------");
                }
                catch (Exception e)
                {
                    MessageBox.Show("There was an error with one or some of the player input files."+"\r\n"+
                        "Please verify that they are valid files");
                    Logger.Log(TAG, e);
                    deleteNewDlcFolder(dlcFolder);
                    return;
                }
            }

            // Generate assist DLC (if needed)
            if (dlcGenAssistEnabled && !dlcGenAssistGmoFileTextBox.Text.Equals(""))
            {
                try
                {
                    // Compose DLC data
                    ObjectTable assistObjectTable = characterData.assistObjectTable;
                    ObjectEntry assistObjectEntry = (ObjectEntry)assistObjectTable.entries[0];

                    assistObjectEntry.costumeId = costumeDlcSlot;
                    // If it's a DLC X costume add corresponding ID; if it isn't, put proper data
                    switch (costumeDlcSlot)
                    {
                        case ObjectEntry.COSTUME_SLOT_MANIKIN: // Manikin
                            playerObjectEntry.id = characterData.manikinAssistID;
                            break;
                        case ObjectEntry.COSTUME_SLOT_NORMAL: // Normal
                            assistObjectEntry.id = characterData.normalAssistID;
                            break;
                        case ObjectEntry.COSTUME_SLOT_ALT1: // Alt. 1
                            assistObjectEntry.id = characterData.alt1AssistID;
                            break;
                        case ObjectEntry.COSTUME_SLOT_ALT2: // Alt. 2
                            assistObjectEntry.id = characterData.alt2AssistID;
                            break;
                        default: // DLC X
                            assistObjectEntry.id = assistDlcSlotId;
                            break;
                    }
                    assistObjectEntry.objectEntrySlot = Convert.ToByte(assistDlcSlotNumber);
                    assistObjectEntry.modelName = (costumeDlcSlot != ObjectEntry.COSTUME_SLOT_MANIKIN)
                        ? characterData.internalName.ToUpper() + "_" + costumeDlcSlot.ToString("X") + "P_A"
                        : characterData.internalName.ToUpper() + "_ZAKO_A";

                    /*
                    // If the user marks the 'include manikin voices & effects', add flag
                    if (costumeDlcSlot == ObjectEntry.COSTUME_SLOT_MANIKIN)
                    {
                        assistObjectEntry.objectEntryType = ObjectEntry.DLC_TYPE_MANIKIN_ASSIST;
                    }
                     */

                    // Get hashed filenames, so the game can read them
                    String assistObjectTableHashFileName = Hasher.hash("dlc/obj/dlc_" + assistDlcSlotNumber.ToString("d3") + "oe.bin") + ".edat";
                    String assistGmoHashFileName = Hasher.hash(("obj/" + assistObjectEntry.modelName + ".gmo").ToLower()) + ".edat";

                    // Write assist files in DLC folder 
                    using (StreamWriter readmeFileWriter = new StreamWriter(new FileStream(readmeFilePath, FileMode.Append)))
                    {
                        ResourceManager rm = new ResourceManager("DissDlcToolkit.Properties.Resources", Assembly.GetExecutingAssembly());

                        readmeFileWriter.WriteLine("Assist object entry slot: " + assistDlcSlotNumber.ToString());
                        readmeFileWriter.WriteLine("Assist object entry ID: " + MiscUtils.swapEndianness(assistObjectEntry.id).ToString("X4"));
                        readmeFileWriter.WriteLine("-----------------------");

                        assistObjectTable.writeToFile(System.IO.Path.Combine(dlcFolder, assistObjectTableHashFileName));
                        readmeFileWriter.WriteLine("Assist object entry (BIN):\t" + assistObjectTableHashFileName);

                        File.Copy(assistGmoFile, System.IO.Path.Combine(dlcFolder, assistGmoHashFileName));
                        readmeFileWriter.WriteLine("Assist model (GMO):\t\t" + assistGmoHashFileName);

                        readmeFileWriter.WriteLine("-----------------------");
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("There was an error with one or some of the assist input files." + "\r\n" +
                        "Please verify that they are valid files");
                    Logger.Log(TAG, e);
                    deleteNewDlcFolder(dlcFolder);
                    return;
                }
            }

            MessageBox.Show("Success!");
        }

        private static void deleteNewDlcFolder(String dlcFolder)
        {
            if (Directory.Exists(dlcFolder))
            {
                Directory.Delete(dlcFolder, true);
            }
        }

        private void dlcGenCharacterComboBox_Validating(object sender, CancelEventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void dlcGenCostumeSlotComboBox_Validating(object sender, CancelEventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void dlcGenPlayerDlcSlotComboBox_Validating(object sender, CancelEventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void dlcGenAssistDlcSlotComboBox_Validating(object sender, CancelEventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void dlcGenCostumeSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void dlcGenPlayerDlcSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void dlcGenAssistDlcSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }
    }
}
