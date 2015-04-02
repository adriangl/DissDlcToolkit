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
    public partial class BgmSelectCharactersForm : Form
    {
        public UInt64 returnValue { get; set; }
        public BgmSelectCharactersForm(UInt64 selectedCharacters)
        {
            InitializeComponent();
            bgmSelectCharactersSaveButton.DialogResult = DialogResult.OK;
            populateCheckBoxes(selectedCharacters);
        }

        private void populateCheckBoxes(ulong selectedCharactersData)
        {
            // knowing that the the number is a series of bit masks
            // check those that the number defines
            BitArray characterFlags = new BitArray(BitConverter.GetBytes(selectedCharactersData));
            for (int i = 0; i < bgmSelectCharactersCheckedListBox.Items.Count; i++)
            {
                int characterFlagIndex = (i < 22) ? i + 1 : i + 2;
                bgmSelectCharactersCheckedListBox.SetItemChecked(i, characterFlags[characterFlagIndex]);                
            }
        }

        private void bgmSelectCharactersSaveButton_Click(object sender, EventArgs e)
        {
            // Recover data and pass it back to the main form
            BitArray newCharacterFlags = new BitArray(64, false);
            for (int i = 0; i < bgmSelectCharactersCheckedListBox.Items.Count; i++)
            {
                int characterFlagIndex = (i < 22) ? i + 1 : i + 2;
                newCharacterFlags[characterFlagIndex] = bgmSelectCharactersCheckedListBox.GetItemChecked(i);
            }
            byte[] bytes = new byte[8];
            newCharacterFlags.CopyTo(bytes, 0);
            returnValue = BitConverter.ToUInt64(bytes, 0);

            this.Close();
        }

        private void bgmSelectCharactersSelectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bgmSelectCharactersCheckedListBox.Items.Count; i++)
                bgmSelectCharactersCheckedListBox.SetItemChecked(i, true);
        }

        private void bgmSelectCharactersInvertSelection_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bgmSelectCharactersCheckedListBox.Items.Count; i++)
                bgmSelectCharactersCheckedListBox.SetItemChecked(i, 
                    !bgmSelectCharactersCheckedListBox.GetItemChecked(i));
        }        
    }
}
