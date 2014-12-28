using System;
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
            if (generateDlcFiles())
            {
                MessageBox.Show("Save successful!!");
            }
        }


        private Boolean generateDlcFiles()
        {
            return true;
        }
    }
}
