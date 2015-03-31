using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DissDlcToolkit.Models;
using DissDlcToolkit.Utils;
using System.IO;
using System.Collections;

namespace DissDlcToolkit.Forms
{
    public partial class MainFormBgmGenUserControl : UserControl
    {

        private int currentBgmIndex;
        private BindingList<FormBgmEntry> bgmFormEntries;

        public MainFormBgmGenUserControl()
        {
            InitializeComponent();            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Restart data
            currentBgmIndex = -1;

            // Get Controller
            String controllerFilePath = FormUtils.openGenericFileDialog();

            if (controllerFilePath != null)
            {
                String controllerFileName = System.IO.Path.GetFileName(controllerFilePath);

                // Needed to locate original BGM DLC data
                String controllerFolder = Directory.GetParent(controllerFilePath).FullName;

                // Getting data from BgmTable
                BgmTable table = new BgmTable(controllerFilePath);

                // Attempt to crack BGM DLC Slot from filename
                int dlcSlotNumber = 0;
                ArrayList bgmTitles = new ArrayList();
                foreach (int i in Enumerable.Range(1, 999))
                {
                    if (controllerFileName.Contains(Hasher.hash(String.Format("dlc/bgm/dlc_{0}.bin", i.ToString("D3")))))
                    {
                        dlcSlotNumber = i;
                        break;
                    }
                }
                if (dlcSlotNumber != 0)
                {
                    // Try getting strings from text file in DLC slot
                    String textHashedFileName = Hasher.hash(String.Format("text/jp/dlc/bgm_{0}t.bin", dlcSlotNumber.ToString("D3"))) + ".edat";
                    String textHashedFilePath = System.IO.Path.Combine(controllerFolder, textHashedFileName);
                    if (File.Exists(textHashedFilePath))
                    {
                        bgmTitles = MessFileReader.decodeDLCText(@textHashedFilePath);
                    }
                }

                // Getting Form BGM entries
                BindingList<FormBgmEntry> formEntries = new BindingList<FormBgmEntry>();
                foreach (int i in Enumerable.Range(0, table.entries.Count - 1))
                {
                    BgmEntry entry = (BgmEntry)table.entries[i];
                    FormBgmEntry formEntry = new FormBgmEntry(entry);
                    String hashedInternalFileName = Hasher.hash(String.Format("bgm/{0}", entry.internalFileName)) + ".edat";
                    String hashedInternalFilePath = System.IO.Path.Combine(controllerFolder, hashedInternalFileName);
                    if (File.Exists(hashedInternalFilePath))
                    {
                        formEntry.filePath = hashedInternalFilePath;
                    }
                    if (bgmTitles.Count > 0 && bgmTitles.Count > i)
                    {
                        formEntry.bgmTitle = (String)bgmTitles[i];
                    }
                    formEntries.Add(formEntry);
                }

                // Set DLC slot if any
                if (dlcSlotNumber != -1)
                {
                    bgmGenDlcSlotComboBox.SelectedIndex = dlcSlotNumber - 1;
                }

                // Bind data
                bindDataAndEnableForm(formEntries);
            }
        }

        private void bindDataAndEnableForm(BindingList<FormBgmEntry> dataSource)
        {         
            // Bind form data to ListBox
            bgmFormEntries = dataSource;
            BindingSource bs = new BindingSource();
            bs.DataSource = bgmFormEntries;
            bgmGenBgmListBox.DisplayMember = "bgmTitle";
            bgmGenBgmListBox.DataSource = bs;
            
            // Enable controls
            Boolean enabled = true;
            bgmGenBgmListBox.Enabled = enabled;
            bgmGenUpButton.Enabled = enabled;
            bgmGenDownButton.Enabled = enabled;
            bgmGenDownButton.Enabled = enabled;
            bgmGenAddButton.Enabled = enabled;
            bgmGenRemoveButton.Enabled = enabled;
            bgmGenBgmTitleTextBox.Enabled = enabled;
            bgmGenGameValueComboBox.Enabled = enabled;
        }

        private void bgmGenBgmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentBgmIndex != bgmGenBgmListBox.SelectedIndex)
            {
                currentBgmIndex = bgmGenBgmListBox.SelectedIndex;
                showBgmFormEntry(currentBgmIndex);
            }
        }

        private void showBgmFormEntry(int index)
        {
            if (index != -1)
            {
                FormBgmEntry entry = (FormBgmEntry)bgmFormEntries[index];

                bgmGenBgmTitleTextBox.DataBindings.Clear();
                bgmGenAt3FileTextBox.DataBindings.Clear();

                bgmGenBgmTitleTextBox.Text = entry.bgmTitle;
                bgmGenAt3FileTextBox.Text = entry.filePath;                

                bgmGenBgmTitleTextBox.DataBindings.Add(new Binding("Text", entry, "bgmTitle", true, DataSourceUpdateMode.OnPropertyChanged));
                bgmGenAt3FileTextBox.DataBindings.Add(new Binding("Text", entry, "filePath", true, DataSourceUpdateMode.OnPropertyChanged));
            }
        }

        private void bgmGenUpButton_Click(object sender, EventArgs e)
        {
            moveSelectedEntry(-1);
        }        

        private void bgmGenDownButton_Click(object sender, EventArgs e)
        {
            moveSelectedEntry(1);
        }

        private void moveSelectedEntry(int offset)
        {
            // First, get the new index
            int entrySize =  bgmFormEntries.Count;
            if (entrySize > 1)
            {
                int newIndex = (((currentBgmIndex + offset) % entrySize) + entrySize) % entrySize;

                // Then move the entry around
                FormBgmEntry entry = (FormBgmEntry)bgmFormEntries[currentBgmIndex];
                bgmFormEntries.Remove(entry);
                bgmFormEntries.Insert(newIndex, entry);

                bgmGenBgmListBox.SetSelected(newIndex, true);
            }
        }

        private void bgmGenAddButton_Click(object sender, EventArgs e)
        {
            // Add a new element
            FormBgmEntry newEntry = new FormBgmEntry(new BgmEntry());
            newEntry.bgmTitle = "New entry";
            bgmFormEntries.Insert(currentBgmIndex + 1, newEntry);
            bgmGenBgmListBox.SetSelected(currentBgmIndex + 1, true);
        }

        private void bgmGenRemoveButton_Click(object sender, EventArgs e)
        {
            bgmFormEntries.RemoveAt(currentBgmIndex);
        }

        private void bgmGenNewButton_Click(object sender, EventArgs e)
        {
            bindDataAndEnableForm(new BindingList<FormBgmEntry>());
        }

        private void bgmGenSaveButton_Click(object sender, EventArgs e)
        {
            // Save loaded data to files
            saveDataToFiles();
        }

        private void saveDataToFiles()
        {
            // TODO Validate data
            int bgmDlcSlot = (int)bgmGenDlcSlotComboBox.SelectedIndex + 1;
            // Get DLC folder
            String baseFolder = Settings.getDlcMainFolder();
            String dlcFolder = System.IO.Path.Combine(baseFolder, "[Slot " + bgmGenDlcSlotComboBox.Text + "][BGM]");
        }
    }
}
