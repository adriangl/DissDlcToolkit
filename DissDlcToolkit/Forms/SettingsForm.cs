using FolderSelect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DissDlcToolkit.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Load DLC folder
            String mainDlcFolder = GlobalData.getInstance().getDlcMainFolder();
            settingsMainDlcFolderTextBox.Text = mainDlcFolder;
        }

        private void browseMainDlcFolderButton_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dialog = new FolderSelectDialog();
            dialog.ShowDialog();
            string folder = dialog.FileName;
            if (!folder.Equals(""))
                settingsMainDlcFolderTextBox.Text = folder;
        }

        private void settingsSaveButton_Click(object sender, EventArgs e)
        {
            // Save data to settings
            GlobalData.getInstance().setDlcMainFolder(settingsMainDlcFolderTextBox.Text);

            // Dismiss dialog
            Close();
        }
    }
}
