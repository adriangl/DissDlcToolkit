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
            String mainDlcFolder = Settings.getDlcMainFolder();
            settingsMainDlcFolderTextBox.Text = mainDlcFolder;
            // Load exex backup data
            settingsBackupExex.Checked = Settings.getBackupExexSetting();
            // Load readme data
            settingsDlcGenReadmeEnabled.Checked = Settings.getDlcGenReadmeEnabled();
            settingsAttachmentReadmeEnabled.Checked = Settings.getAttachmentReadmeEnabled();
            settingsBgmReadmeEnabled.Checked = Settings.getBgmReadmeEnabled();
        }

        private void browseMainDlcFolderButton_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dialog = new FolderSelectDialog();
            dialog.ShowDialog();
            string folder = dialog.FileName;
            if (!folder.Equals(""))
                // Show new folder
                settingsMainDlcFolderTextBox.Text = folder;
                // Save data to settings
                Settings.setDlcMainFolder(settingsMainDlcFolderTextBox.Text);
        }

        private void settingsBackupExex_CheckedChanged(object sender, EventArgs e)
        {
            // Save exex backup setting
            Settings.setBackupExexSetting(settingsBackupExex.Checked);
        }

        private void settingsDlcGenReadmeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Settings.setDlcGenReadmeEnabled(settingsDlcGenReadmeEnabled.Checked);
        }

        private void settingsAttachmentReadmeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Settings.setAttachmentReadmeEnabled(settingsAttachmentReadmeEnabled.Checked);
        }

        private void settingsBgmReadmeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Settings.setBgmReadmeEnabled(settingsBgmReadmeEnabled.Checked);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            settingsDlcGenReadmeEnabled.Checked = !settingsDlcGenReadmeEnabled.Checked;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            settingsAttachmentReadmeEnabled.Checked = !settingsAttachmentReadmeEnabled.Checked;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            settingsBgmReadmeEnabled.Checked = !settingsBgmReadmeEnabled.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            settingsBackupExex.Checked = !settingsBackupExex.Checked;
        }
    }
}
