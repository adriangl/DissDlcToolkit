using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
                KeyValuePair<UInt16, String> data = new KeyValuePair<UInt16, String>((UInt16)(0x2C0+(i-1)), i.ToString());
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
            dlcGenCharacterKeyValues.Add(new KeyValuePair<String, String>("p_sev100", "Cloud"));
            dlcGenCharacterKeyValues.Add(new KeyValuePair<String, String>("p_for100", "Cecil"));
            dlcGenCharacterComboBox.DataSource = dlcGenCharacterKeyValues;
            dlcGenCharacterComboBox.DisplayMember = "Value";
            dlcGenCharacterComboBox.ValueMember = "Key";
        }

        private void dlcGenCharacterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if we have selected Cecil (p_for100); if we did, then enable second GIM box
            dlcGenPlayerGimFileExtraEnabled = dlcGenCharacterComboBox.SelectedValue.Equals("p_for100");
            dlcGenBrowsePlayerGimFileExtraButton.Enabled = dlcGenPlayerGimFileExtraEnabled;
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
            MessageBox.Show("Success!");
        }
    }
}
