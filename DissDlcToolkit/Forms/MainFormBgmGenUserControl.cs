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
                BgmTable bgmTable = new BgmTable(controllerFilePath);

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
                foreach (int i in Enumerable.Range(0, bgmTable.entries.Count))
                {
                    BgmEntry entry = bgmTable.entries[i];
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
                bgmGenDlcSlotComboBox.SelectedIndex = (dlcSlotNumber != -1)
                        ? dlcSlotNumber - 1
                        : 0;

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
            enableForm(true);
        }

        private void enableForm(Boolean enabled)
        {
            bgmGenBgmListBox.Enabled = enabled;
            bgmGenUpButton.Enabled = enabled;
            bgmGenDownButton.Enabled = enabled;
            bgmGenAddButton.Enabled = enabled;
            bgmGenRemoveButton.Enabled = enabled;
            bgmGenBgmTitleTextBox.Enabled = enabled;
            bgmGenBrowseAt3Button.Enabled = enabled;
            bgmGenDlcSlotComboBox.Enabled = enabled;
            bgmGenBgmVolumeTrackBar.Enabled = enabled;
            bgmGenCharactersSelectButton.Enabled = enabled;
            bgmGenStageSelectButton.Enabled = enabled;
            bgmGenSaveButton.Enabled = enabled;
        }

        private void bgmGenBgmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentBgmIndex != bgmGenBgmListBox.SelectedIndex)
            {
                currentBgmIndex = bgmGenBgmListBox.SelectedIndex;                
            }
            showBgmFormEntry(currentBgmIndex);
        }

        private void showBgmFormEntry(int index)
        {
            if (index != -1)
            {
                FormBgmEntry formEntry = (FormBgmEntry)bgmFormEntries[index];

                bgmGenBgmTitleTextBox.DataBindings.Clear();
                bgmGenAt3FileTextBox.DataBindings.Clear();

                bgmGenBgmTitleTextBox.Text = formEntry.bgmTitle;
                bgmGenAt3FileTextBox.Text = formEntry.filePath;                

                bgmGenBgmTitleTextBox.DataBindings.Add(new Binding("Text", formEntry, "bgmTitle", true, DataSourceUpdateMode.OnPropertyChanged));
                bgmGenAt3FileTextBox.DataBindings.Add(new Binding("Text", formEntry, "filePath", true, DataSourceUpdateMode.OnPropertyChanged));

                bgmGenVolumeTextBox.Text = formEntry.entry.bgmVolume.ToString();
                bgmGenBgmVolumeTrackBar.Value = formEntry.entry.bgmVolume;
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
                FormBgmEntry formEntry = (FormBgmEntry)bgmFormEntries[currentBgmIndex];
                bgmFormEntries.Remove(formEntry);
                bgmFormEntries.Insert(newIndex, formEntry);
                // Highlight new selection
                bgmGenBgmListBox.SetSelected(newIndex, true);                
            }
        }

        private void bgmGenAddButton_Click(object sender, EventArgs e)
        {
            // Add a new element
            BgmEntry bgmEntry = new BgmEntry();
            FormBgmEntry newEntry = new FormBgmEntry(bgmEntry);
            bgmFormEntries.Insert(currentBgmIndex + 1, newEntry);
            bgmGenBgmListBox.SetSelected(currentBgmIndex + 1, true);
        }

        private void bgmGenRemoveButton_Click(object sender, EventArgs e)
        {
            if (bgmFormEntries.Count > 1)
            {
                bgmFormEntries.RemoveAt(currentBgmIndex);
            }
            else
            {
                MessageBox.Show("You have to keep at least one BGM in the list!");
            }
        }

        private void bgmGenNewButton_Click(object sender, EventArgs e)
        {
            BindingList<FormBgmEntry> newBgmFormEntries = new BindingList<FormBgmEntry>();
            
            // Setup slot to 1 by default
            bgmGenDlcSlotComboBox.SelectedIndex = 0;

            // Add new dummy entry and select it
            BgmEntry bgmEntry = new BgmEntry();
            FormBgmEntry newEntry = new FormBgmEntry(bgmEntry);
            newBgmFormEntries.Add(newEntry);
            bindDataAndEnableForm(newBgmFormEntries);

        }

        private void bgmGenSaveButton_Click(object sender, EventArgs e)
        {
            // Save loaded data to files
            saveDataToFiles();
        }

        private void saveDataToFiles()
        {
            // Validate data
            if (bgmGenDlcSlotComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select valid values in the highlighted fields.");
                return;
            }

            int selectedBgmSlotIndex = bgmGenDlcSlotComboBox.SelectedIndex;
            if (selectedBgmSlotIndex < 0){
                MessageBox.Show("You have to select a valid DLC slot");
                return;
            }
            int bgmDlcSlot = (int)bgmGenDlcSlotComboBox.SelectedIndex + 1;

            if (bgmFormEntries.Count <= 0)
            {
                MessageBox.Show("You have to add at least one BGM to the list");
                return;
            }   
        
            
            // Get DLC folder
            String baseFolder = Settings.getDlcMainFolder();
            String dlcFolder = System.IO.Path.Combine(baseFolder, 
                "[Slot " + bgmGenDlcSlotComboBox.Text + "][BGM]");
            createDlcFolder(dlcFolder);           

            // Prepare copy
            List<String> bgmNames = new List<String>();
            List<String> bgmFileNames = new List<String>();
            BgmTable bgmTable = new BgmTable();
            foreach (FormBgmEntry formEntry in bgmFormEntries)
            {
                // Save text strings
                bgmNames.Add(formEntry.bgmTitle);
                bgmTable.addEntry(formEntry.entry);
            }

            // Ready bgmTable
            bgmTable.generateRandomEntryNamesAndIds(bgmDlcSlot);

            // Save bgm names
            String textHashedFileName = Hasher.hash(String.Format("text/jp/dlc/bgm_{0}t.bin", bgmDlcSlot.ToString("D3"))) + ".edat";
            String textHashedFilePath = System.IO.Path.Combine(dlcFolder, textHashedFileName);
            MessFileWriter.encodeDLCText(bgmNames, textHashedFilePath);

            // Save bgm controller
            String controllerHashedFileName = Hasher.hash(String.Format("dlc/bgm/dlc_{0}.bin", bgmDlcSlot.ToString("D3"))) + ".edat";
            String controllerHashedFilePath = System.IO.Path.Combine(dlcFolder, controllerHashedFileName);
            bgmTable.writeToFile(controllerHashedFilePath);

            // Copy bgm to dlc folder
            foreach (FormBgmEntry formEntry in bgmFormEntries)
            {
                String hashedInternalFileName = Hasher.hash(String.Format("bgm/{0}", formEntry.entry.internalFileName)) + ".edat";
                String hashedInternalFilePath = System.IO.Path.Combine(dlcFolder, hashedInternalFileName);
                if (File.Exists(formEntry.filePath))
                {
                    File.Copy(formEntry.filePath, hashedInternalFilePath, true);
                }
                bgmFileNames.Add(hashedInternalFileName);
            }

            // Generate readme
            if (Settings.getBgmReadmeEnabled())
            {
                String readmeFilePath = System.IO.Path.Combine(dlcFolder, "readme.txt");
                using (StreamWriter readmeFileWriter = new StreamWriter(new FileStream(readmeFilePath, FileMode.Create)))
                {
                    readmeFileWriter.WriteLine("BGM DLC Slot " + bgmGenDlcSlotComboBox.Text);
                    readmeFileWriter.WriteLine("-----------------------");
                    for (int i = 0; i < bgmNames.Count; i++)
                    {
                        readmeFileWriter.WriteLine(bgmNames[i] + " -> " + bgmFileNames[i]);
                    }
                }
            }

            MessageBox.Show("Success!");

        }

        private void createDlcFolder(string dlcFolder)
        {
            /*if (Directory.Exists(dlcFolder))
            {
                // Check if any of the elements are contained in that folder
                // just so we don't delete them by accident
                bool containsBgmData = false;
                foreach (FormBgmEntry entry in bgmFormEntries)
                {
                    if (entry.filePath != null && Directory.GetParent(entry.filePath).Equals(dlcFolder))
                    {
                        containsBgmData = true;
                        break;
                    }
                }
                if (!containsBgmData)
                {
                    Directory.Delete(dlcFolder, true);
                    Directory.CreateDirectory(dlcFolder);
                }
            }
            else
            {
                Directory.CreateDirectory(dlcFolder);
            }
             */
            if (Directory.Exists(dlcFolder))
            {
                Directory.Delete(dlcFolder, true);
            }
            Directory.CreateDirectory(dlcFolder);
        }

        private void bgmGenBrowseAt3Button_Click(object sender, EventArgs e)
        {
            String at3FilePath = FormUtils.openAt3FileDialog();
            if (at3FilePath != null && !at3FilePath.Trim().Equals(""))
            {
                bgmGenAt3FileTextBox.Text = at3FilePath;
            }
        }

        private void bgmGenCharactersSelectButton_Click(object sender, EventArgs e)
        {
            BgmEntry bgmEntry = bgmFormEntries[currentBgmIndex].entry;
            BgmSelectCharactersForm characterSelectForm = new BgmSelectCharactersForm(
                bgmEntry.bgmCharactersToPlay);
            if (characterSelectForm.ShowDialog(this).Equals(DialogResult.OK))
            {
                bgmEntry.bgmCharactersToPlay = characterSelectForm.returnValue;
            }
        }

        private void bgmGenStageSelectButton_Click(object sender, EventArgs e)
        {
            BgmEntry bgmEntry = bgmFormEntries[currentBgmIndex].entry;
            BgmSelectStageForm stageSelectForm = new BgmSelectStageForm(
                bgmEntry.bgmStagesToPlay);
            if (stageSelectForm.ShowDialog(this).Equals(DialogResult.OK))
            {
                bgmEntry.bgmStagesToPlay = stageSelectForm.returnValue;
            }
        }

        private void bgmGenBgmVolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            // Sync text box with trackbar
            bgmGenVolumeTextBox.Text = bgmGenBgmVolumeTrackBar.Value.ToString();
            bgmFormEntries[currentBgmIndex].entry.bgmVolume = Convert.ToByte(bgmGenBgmVolumeTrackBar.Value);
        }

        private void bgmGenDlcSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }

        private void bgmGenDlcSlotComboBox_Validating(object sender, CancelEventArgs e)
        {
            FormUtils.genericValidateComboBox(sender);
        }
    }
}
