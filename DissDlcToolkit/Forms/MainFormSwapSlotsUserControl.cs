using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DissDlcToolkit.Utils;
using System.Collections;
using DissDlcToolkit.Widgets;
using DissDlcToolkit.Models;
using System.IO;

namespace DissDlcToolkit.Forms
{
    public partial class MainFormSwapSlotsUserControl : UserControl
    {
        public MainFormSwapSlotsUserControl()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // Costume combo box
            ArrayList dlcGenDlcSlotsKeyValues = new ArrayList();
            for (UInt16 i = 1; i <= 255; i++)
            {
                KeyValuePair<UInt16, int> data = new KeyValuePair<UInt16, int>((UInt16)(0x2C0 + (i - 1)), i);
                dlcGenDlcSlotsKeyValues.Add(data);
            }
            swapSlotsCharacterSlotComboBox.DataSource = dlcGenDlcSlotsKeyValues;
            swapSlotsCharacterSlotComboBox.DisplayMember = "Value";
            swapSlotsCharacterSlotComboBox.ValueMember = "Key";

            // BGM Combo box

        }

        private void swapSlotsCharacterControllerBrowseButton_Click(object sender, EventArgs e)
        {
            String path = FormUtils.openGenericFileDialog();
            if (path != null)
            {
                swapSlotsCharacterControllerTextBox.Text = path;
            }
        }

        private void swapSlotsBgmControllerBrowseButton_Click(object sender, EventArgs e)
        {
            String path = FormUtils.openGenericFileDialog();
            if (path != null)
            {
                swapSlotsBgmControllerTextBox.Text = path;
            }
        }

        private void swapSlotsCharacterSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void swapSlotsCharacterSlotComboBox_Validating(object sender, CancelEventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void swapSlotsCharacterSlotComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            FormUtils.removeDropDown(sender);
        }

        private void swapSlotsBgmSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void swapSlotsBgmSlotComboBox_Validating(object sender, CancelEventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void swapSlotsBgmSlotComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            FormUtils.removeDropDown(sender);
        }

        private void swapSlotsCharacterSwapButton_Click(object sender, EventArgs e)
        {
            String controllerPath = swapSlotsCharacterControllerTextBox.Text;
            if (controllerPath == null || controllerPath.Equals(""))
            {
                MessageBoxEx.Show(this, "You have to select a controller!");
                return;
            }

            if (swapSlotsCharacterSlotComboBox.SelectedItem == null)
            {
                MessageBoxEx.Show(this, "Select valid values in the highlighted fields");
                return;
            }

            // After validating the data, swap slots!
            try
            {
                // Test if the given file is a valid controller
                ObjectTable table = new ObjectTable(controllerPath);
                int dlcSlotNumber = (int)swapSlotsCharacterSlotComboBox.SelectedIndex + 1;
                UInt16 dlcSlotId = (UInt16)swapSlotsCharacterSlotComboBox.SelectedValue;

                ObjectEntry entry = (ObjectEntry)table.entries[0];
                // Change DLC id to one valid with the slot if needed
                if (swapSlotsCharacterChangeIdCheckBox.Checked)
                {
                    entry.id = dlcSlotId;
                }
                entry.objectEntrySlot = (byte)dlcSlotNumber;
                // Delete old file and create a new one
                String parentPath = Path.GetDirectoryName(controllerPath);
                File.Delete(controllerPath);
                String objectTableHashFileName = Hasher.hash("dlc/obj/dlc_" + dlcSlotNumber.ToString("d3") + "oe.bin") + ".edat";
                table.writeToFile(System.IO.Path.Combine(parentPath, objectTableHashFileName));
                MessageBoxEx.Show(this, "Success!");

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, "Select a valid controller");
                Logger.Log("MainFormSwapSlotsUserControl", ex);
                return;
            }
        }

        private void swapSlotsBgmSwapButton_Click(object sender, EventArgs e)
        {
            String controllerPath = swapSlotsBgmControllerTextBox.Text;
            String parentPath = Path.GetDirectoryName(controllerPath);

            if (controllerPath == null || controllerPath.Equals(""))
            {
                MessageBoxEx.Show(this, "You have to select a controller!");
                return;
            }

            if (swapSlotsBgmSlotComboBox.SelectedItem == null)
            {
                MessageBoxEx.Show(this, "Select valid values in the highlighted fields");
                return;
            }
            
            try
            {
                // Test if the given file is a valid controller
                BgmTable table = new BgmTable(controllerPath);
                int newBgmDlcSlotNumber = (int)swapSlotsBgmSlotComboBox.SelectedIndex + 1;

                // First, try to find the text file so we can also change its slots by cracking
                // its name
                int originalBgmDlcSlotNumber = 0;
                foreach (int i in Enumerable.Range(1, 999))
                {
                    if (controllerPath.Contains(Hasher.hash(String.Format("dlc/bgm/dlc_{0}.bin", i.ToString("D3")))))
                    {
                        originalBgmDlcSlotNumber = i;
                        break;
                    }
                }
                String textHashedFileName = Hasher.hash(String.Format("text/jp/dlc/bgm_{0}t.bin", originalBgmDlcSlotNumber.ToString("D3"))) + ".edat";
                String textHashedFilePath = System.IO.Path.Combine(parentPath, textHashedFileName);
                if (!File.Exists(textHashedFilePath))
                {
                    MessageBoxEx.Show(this, "The selected BGM DLC controller doesn't have a text file!");
                    return;
                }

                // Here we should already have all the needed data, so swap slots!                
                // Change DLC id to one valid with the slot if needed
                if (swapSlotsBgmChangeIdsCheckBox.Checked)
                {
                    table.generateRandomEntryNamesAndIds(newBgmDlcSlotNumber, true, false);
                }
                // Rename old files to new ones
                File.Delete(controllerPath);
                table.writeToFile(Path.Combine(parentPath, Hasher.hash(String.Format("dlc/bgm/dlc_{0}.bin", newBgmDlcSlotNumber.ToString("D3"))) + ".edat"));
                // Move text entry
                File.Move(textHashedFilePath, Path.Combine(parentPath, Hasher.hash(String.Format("text/jp/dlc/bgm_{0}t.bin", newBgmDlcSlotNumber.ToString("D3"))) + ".edat"));
                MessageBoxEx.Show(this, "Success!");

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, "Select a valid controller");
                Logger.Log("MainFormSwapSlotsUserControl", ex);
                return;
            }
        }        
    }
}
