using CutoutPro.Winforms;
using DissDlcToolkit.Models;
using DissDlcToolkit.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DissDlcToolkit
{
    public partial class MainForm
    {
        /**
         * This partial class handles all callbacks from the
         * ".exex editing" tab
         */

        private String exexFile;
        private ExexTable exexTable;
        private int currentAuraSlotIndex = 0;

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
            exexFile = openExexFileDialog();
            if (exexFile != null && !exexFile.Trim().Equals(""))
            {
                exexFileLabel.Text = exexFile;
                exexTable = new ExexTable(exexFile);
                populateFields(exexTable);
            }
        }

        private void exexAuraSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentAuraSlotIndex != exexAuraSlotComboBox.SelectedIndex)
            {
                saveValuesToAuraSlot(currentAuraSlotIndex);
                currentAuraSlotIndex = exexAuraSlotComboBox.SelectedIndex;
                populateColorsForAura(currentAuraSlotIndex);
            }
        }

        private void exexParticleColorLabel_Click(object sender, EventArgs e)
        {
            Color backColor = openColorDialog(exexParticleColorLabel.BackColor, false);
            updateColorData(backColor, exexParticleColorLabel, exexParticleColorTextBox, false, true);
        }        

        private void exexOuterGlowLabel_Click(object sender, EventArgs e)
        {
            Color backColor = openColorDialog(exexOuterGlowLabel.BackColor, false);
            updateColorData(backColor, exexOuterGlowLabel, exexOuterGlowTextBox, false, true);
        }

        private void exexInnerGlowLabel_Click(object sender, EventArgs e)
        {
            Color backColor = openColorDialog(exexInnerGlowLabel.BackColor, false);
            updateColorData(backColor, exexInnerGlowLabel, exexInnerGlowTextBox, false, true);
        }

        private void exexSmoke1Label_Click(object sender, EventArgs e)
        {
            Boolean invertColor = exexSmoke1InvertCheckBox.Checked;
            Color backColor = openColorDialog(exexSmoke1Label.BackColor, invertColor);
            updateColorData(backColor, exexSmoke1Label, exexSmoke1TextBox, invertColor, false);
        }

        private void exexSmoke2Label_Click(object sender, EventArgs e)
        {
            Boolean invertColor = exexSmoke2InvertCheckBox.Checked;
            Color backColor = openColorDialog(exexSmoke2Label.BackColor, invertColor);
            updateColorData(backColor, exexSmoke2Label, exexSmoke2TextBox, invertColor, false);
        }

        private void exexBoltsLabel_Click(object sender, EventArgs e)
        {
            Boolean invertColor = exexBoltsInvertCheckBox.Checked;
            Color backColor = openColorDialog(exexBoltsLabel.BackColor, invertColor);
            updateColorData(backColor, exexBoltsLabel, exexBoltsTextBox, invertColor, false);
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
            saveValuesToAuraSlot(currentAuraSlotIndex);
            File.Copy(@exexFile, @exexFile + ".bak");
            exexTable.writeToFile(@exexFile);
            MessageBox.Show("Success!!");
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
            for (Byte i = 0; i < table.entries.Count; i++){
                exexAuraSlots.Add(i+1);
            }
            exexAuraSlotComboBox.DataSource = exexAuraSlots;
            exexAuraSlotComboBox.Enabled = true;

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

    }
}
