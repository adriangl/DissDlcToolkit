using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DissDlcToolkit.Forms
{
    public partial class MainFormAttachmentsUserControl : UserControl
    {
        public MainFormAttachmentsUserControl()
        {
            InitializeComponent();
            initializeAttachmentsTab();
        }

        private void initializeAttachmentsTab()
        {
            attachmentLinkControllerRadioButton.Checked = true;
        }

        private void attachmentLinkControllerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            attachmentLinkDataLabel.Text = "Controller to link";
            attachmentLinkDataTextBox.Text = "";
            attachmentLinkDataTextBox.Enabled = false;
            attachmentLinkBrowseLinkedControllerButton.Visible = true;
        }

        private void attachmentLinkIdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            attachmentLinkDataLabel.Text = "ID to link";
            attachmentLinkDataTextBox.Text = "";
            attachmentLinkDataTextBox.Enabled = true;
            attachmentLinkBrowseLinkedControllerButton.Visible = false;
        }
    }
}
