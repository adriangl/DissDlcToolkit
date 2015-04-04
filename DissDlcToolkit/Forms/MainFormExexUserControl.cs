using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DissDlcToolkit.Models;
using DissDlcToolkit.Utils;
using System.IO;
using CutoutPro.Winforms;
using System.Collections;
using DissDlcToolkit.Widgets;

namespace DissDlcToolkit.Forms
{
    public partial class MainFormExexUserControl : UserControl
    {
        /**
         * This partial class handles all callbacks from the
         * ".exex editing" tab
         */
        private const string TAG = "MainFormExexUserControl";
        private String exexFile;
        private ExexTable exexTable;
        private int currentAuraSlotIndex = 0;

        private bool labelBoxesEnabled = false;


        public MainFormExexUserControl()
        {
            InitializeComponent();
            InitializeExexTab();
        }      

        public void InitializeExexTab()
        {
            exexParticleColorLabel.Parent = pictureBox1;
            exexOuterGlowLabel.Parent = pictureBox2;
            exexInnerGlowLabel.Parent = pictureBox3;
            exexSmoke1Label.Parent = pictureBox4;
            exexSmoke2Label.Parent = pictureBox5;
            exexBoltsLabel.Parent = pictureBox6;
        }

        private void exexLoadButton_Click(object sender, EventArgs e)
        {
            exexFile = FormUtils.openExexFileDialog();
            if (exexFile != null && !exexFile.Trim().Equals(""))
            {
                try
                {
                    // Disable listener for aura combo box
                    exexAuraSlotComboBox.SelectedIndexChanged -= new System.EventHandler(exexAuraSlotComboBox_SelectedIndexChanged);
                    exexFileLabel.Text = exexFile;
                    exexTable = new ExexTable(exexFile);
                    populateFields(exexTable);
                    // Restore listener
                    exexAuraSlotComboBox.SelectedIndexChanged += new System.EventHandler(exexAuraSlotComboBox_SelectedIndexChanged);
                    
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(this, "The .exex file you tried to load is not a vaild .exex");
                    Logger.Log(TAG, ex);
                }
            }
        }

        private void exexAuraSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
            if (currentAuraSlotIndex != exexAuraSlotComboBox.SelectedIndex)
            {
                saveValuesToAuraSlot(currentAuraSlotIndex);
                currentAuraSlotIndex = exexAuraSlotComboBox.SelectedIndex;
                populateColorsForAura(currentAuraSlotIndex);
            }
        }

        private void exexParticleColorLabel_Click(object sender, EventArgs e)
        {
            selectColorAndUpdate(exexParticleColorLabel, exexParticleColorTextBox, false, true);
        }

        private void exexOuterGlowLabel_Click(object sender, EventArgs e)
        {
            selectColorAndUpdate(exexOuterGlowLabel, exexOuterGlowTextBox, false, true);
        }

        private void exexInnerGlowLabel_Click(object sender, EventArgs e)
        {
            selectColorAndUpdate(exexInnerGlowLabel, exexInnerGlowTextBox, false, true);
        }

        private void exexSmoke1Label_Click(object sender, EventArgs e)
        {
            selectColorAndUpdate(exexSmoke1Label, exexSmoke1TextBox, exexSmoke1InvertCheckBox.Checked, false);
        }

        private void exexSmoke2Label_Click(object sender, EventArgs e)
        {
            selectColorAndUpdate(exexSmoke2Label, exexSmoke2TextBox, exexSmoke2InvertCheckBox.Checked, false);
        }

        private void exexBoltsLabel_Click(object sender, EventArgs e)
        {            
            selectColorAndUpdate(exexBoltsLabel, exexBoltsTextBox, exexBoltsInvertCheckBox.Checked, false);
        }

        private void exexSmoke1InvertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            exexSmoke1Label.BackColor = MiscUtils.invertColor(exexSmoke1Label.BackColor);
        }

        private void exexSmoke2InvertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            exexSmoke2Label.BackColor = MiscUtils.invertColor(exexSmoke2Label.BackColor);
        }

        private void exexBoltsInvertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            exexBoltsLabel.BackColor = MiscUtils.invertColor(exexBoltsLabel.BackColor);
        }



        private void exexSaveButton_Click(object sender, EventArgs e)
        {
            // Validate data, just in case
            if (exexAuraSlotComboBox.SelectedItem == null)
            {
                MessageBoxEx.Show(this, "Select valid values in the highlighted fields.");
                return;
            }
            
            saveValuesToAuraSlot(currentAuraSlotIndex);
            // Backup existing file if the user allowed it & the file exists, and overwrite old copies
            if (Settings.getBackupExexSetting() && File.Exists(@exexFile))
            {
                File.Copy(@exexFile, @exexFile + ".bak", true);
            }
            // Write .exex to disk
            try
            {
                exexTable.writeToFile(@exexFile);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, "There was a problem writing the .exex file");
                Logger.Log(TAG, ex);
            }
            MessageBoxEx.Show(this, "Success!!");
        }

        /** 
         * Opens a color dialog & updates the color if needed
         */
        private void selectColorAndUpdate(Label label, TextBox textBox, bool invertColor, bool applyAlpha)
        {
            if (labelBoxesEnabled)
            {
                Color backColor = openColorDialog(label.BackColor, invertColor);
                updateColorData(backColor, label, textBox, invertColor, applyAlpha);
            }
        }

        private void updateColorData(Color backColor, Label colorLabel, TextBox colorTextBox,
            Boolean invert, Boolean applyAlpha)
        {
            Color colorToApply = invert ? MiscUtils.invertColor(backColor) : backColor;
            if (!applyAlpha)
            {
                colorToApply = Color.FromArgb(0xFF, colorToApply.R, colorToApply.G, colorToApply.B);
            }
            colorLabel.BackColor = colorToApply;
            colorTextBox.Text = applyAlpha ? MiscUtils.argbToString(backColor) : MiscUtils.rgbToString(backColor);
        }

        private Color openColorDialog(Color currentColor, Boolean invertColor)
        {            
            ArgbColorDialog dialog = new ArgbColorDialog();
            // Sets the initial color select to the current text color.
            dialog.Color = invertColor ? MiscUtils.invertColor(currentColor) : currentColor;
            dialog.ShowDialog();

            // Update the text box color
            return dialog.Color;

        }

        private void populateFields(ExexTable table)
        {
            // Config aura slots
            ArrayList exexAuraSlots = new ArrayList();
            for (Byte i = 0; i < table.entries.Count; i++)
            {
                exexAuraSlots.Add(i + 1);
            }
            exexAuraSlotComboBox.DataSource = exexAuraSlots;

            // Enable fields for editing
            exexAuraSlotComboBox.Enabled = true;
            exexSmoke1InvertCheckBox.Enabled = true;
            exexSmoke2InvertCheckBox.Enabled = true;
            exexBoltsInvertCheckBox.Enabled = true;
            exexSaveButton.Enabled = true;
            labelBoxesEnabled = true;

            // Populate colors for index 0
            currentAuraSlotIndex = 0;
            populateColorsForAura(currentAuraSlotIndex);
        }

        private void populateColorsForAura(int auraIndex)
        {
            ExexEntry entry = (ExexEntry)exexTable.entries[auraIndex];
            updateColorData(entry.particleColor, exexParticleColorLabel, exexParticleColorTextBox, false, true);
            updateColorData(entry.outerGlowColor, exexOuterGlowLabel, exexOuterGlowTextBox, false, true);
            updateColorData(entry.innerGlowColor, exexInnerGlowLabel, exexInnerGlowTextBox, false, true);

            exexSmoke1InvertCheckBox.Checked = entry.smoke1Invert;
            exexSmoke2InvertCheckBox.Checked = entry.smoke2Invert;
            exexBoltsInvertCheckBox.Checked = entry.boltsInvert;

            updateColorData(entry.smoke1Color, exexSmoke1Label, exexSmoke1TextBox, entry.smoke1Invert, false);
            updateColorData(entry.smoke2Color, exexSmoke2Label, exexSmoke2TextBox, entry.smoke2Invert, false);
            updateColorData(entry.boltsColor, exexBoltsLabel, exexBoltsTextBox, entry.boltsInvert, false);

        }

        private void saveValuesToAuraSlot(int auraSlotIndex)
        {
            if (auraSlotIndex >= 0 && auraSlotIndex < exexTable.entries.Count)
            {
                if (exexTable.entries != null)
                {
                    ExexEntry entry = (ExexEntry)exexTable.entries[auraSlotIndex];
                    entry.particleColor = exexParticleColorLabel.BackColor;
                    entry.outerGlowColor = exexOuterGlowLabel.BackColor;
                    entry.innerGlowColor = exexInnerGlowLabel.BackColor;

                    entry.smoke1Color = exexSmoke1InvertCheckBox.Checked
                        ? MiscUtils.invertColor(exexSmoke1Label.BackColor)
                        : exexSmoke1Label.BackColor;
                    entry.smoke1Invert = exexSmoke1InvertCheckBox.Checked;

                    entry.smoke2Color = exexSmoke2InvertCheckBox.Checked
                        ? MiscUtils.invertColor(exexSmoke2Label.BackColor)
                        : exexSmoke2Label.BackColor;
                    entry.smoke2Invert = exexSmoke2InvertCheckBox.Checked;

                    entry.boltsColor = exexBoltsInvertCheckBox.Checked
                        ? MiscUtils.invertColor(exexBoltsLabel.BackColor)
                        : exexBoltsLabel.BackColor;
                    entry.boltsInvert = exexBoltsInvertCheckBox.Checked;
                }
                else
                {
                    Logger.Log("MainFormExexUserControl", "The exex table contains no entries");
                }
            }
            else
            {
                Logger.Log("MainFormExexUserControl", "The exex index is not valid");
            }
        }

        private void exexAuraSlotComboBox_Validating(object sender, CancelEventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void exexAuraSlotComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            FormUtils.removeDropDown(sender);
        }
    }
}
