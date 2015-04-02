using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DissDlcToolkit.Forms
{
    public partial class BgmSelectStageForm : Form
    {
        public UInt32 returnValue { get; set; }
        public BgmSelectStageForm(UInt32 selectedStages)
        {
            InitializeComponent();
            bgmSelectStageSaveButton.DialogResult = DialogResult.OK;
            populateCheckBoxes(selectedStages);
        }

        private void populateCheckBoxes(UInt32 selectedStagesData)
        {
            // knowing that the the number is a series of bit masks
            // check those that the number defines
            BitArray stageFlags = new BitArray(BitConverter.GetBytes(selectedStagesData));
            for (int i = 0; i < bgmSelectStageCheckedListBox.Items.Count; i++)
            {
                bgmSelectStageCheckedListBox.SetItemChecked(i, stageFlags[i]);
            }
        }

        private void bgmSelectStageSaveButton_Click(object sender, EventArgs e)
        {
            // Recover data and pass it back to the main form
            BitArray newStageFlags = new BitArray(32, false);
            for (int i = 0; i < bgmSelectStageCheckedListBox.Items.Count; i++)
            {
                newStageFlags[i] = bgmSelectStageCheckedListBox.GetItemChecked(i);
            }
            byte[] bytes = new byte[4];
            newStageFlags.CopyTo(bytes, 0);
            returnValue = BitConverter.ToUInt32(bytes, 0);

            this.Close();
        }

        private void bgmSelectStageSelectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bgmSelectStageCheckedListBox.Items.Count; i++)
                bgmSelectStageCheckedListBox.SetItemChecked(i, true);
        }

        private void bgmSelectStageInvertSelection_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bgmSelectStageCheckedListBox.Items.Count; i++)
                bgmSelectStageCheckedListBox.SetItemChecked(i, 
                    !bgmSelectStageCheckedListBox.GetItemChecked(i));
        }        
    }
}
