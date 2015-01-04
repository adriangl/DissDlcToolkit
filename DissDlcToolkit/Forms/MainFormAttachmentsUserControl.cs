using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DissDlcToolkit.Utils;
using System.Collections;
using DissDlcToolkit.Models;
using System.IO;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace DissDlcToolkit.Forms
{
    public partial class MainFormAttachmentsUserControl : UserControl
    {

        private const String TAG = "MainFormAttachmentsUserControl";

        public MainFormAttachmentsUserControl()
        {
            InitializeComponent();
            initializeAttachmentsTab();
        }

        private void initializeAttachmentsTab()
        {
            // Setup Link to controller as default value
            attachmentLinkControllerRadioButton.Checked = true;

            // Setup ComboBoxes

            // Config attachment data
            ArrayList attachmentDataKeyValues = new ArrayList();
            foreach (AttachmentData data in GlobalData.getInstance().attachmentDataList)
            {
                attachmentDataKeyValues.Add(data);
            }
            attachmentCreationBaseComboBox.DataSource = attachmentDataKeyValues;

            // Config DLC slots
            ArrayList attachmentDlcSlotsKeyValues = new ArrayList();
            for (UInt16 i = 1; i <= 255; i++)
            {
                KeyValuePair<UInt16, int> data = new KeyValuePair<UInt16, int>((UInt16)(0x2C0 + (i - 1)), i);
                attachmentDlcSlotsKeyValues.Add(data);
            }
            attachmentCreationDlcSlotComboBox.DataSource = attachmentDlcSlotsKeyValues;
            attachmentCreationDlcSlotComboBox.DisplayMember = "Value";
            attachmentCreationDlcSlotComboBox.ValueMember = "Key";            
        }

        private void attachmentLinkControllerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            attachmentLinkDataLabel.Text = "Controller to link";
            attachmentLinkDataTextBox.Text = "";
            attachmentLinkDataTextBox.MaxLength = 0;
            attachmentLinkDataTextBox.Enabled = false;
            attachmentLinkBrowseLinkedControllerButton.Visible = true;
        }

        private void attachmentLinkIdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            attachmentLinkDataLabel.Text = "ID to link";
            attachmentLinkDataTextBox.Text = "";
            attachmentLinkDataTextBox.MaxLength = 4;
            attachmentLinkDataTextBox.Enabled = true;
            attachmentLinkBrowseLinkedControllerButton.Visible = false;
        }

        private void attachmentCreationBrowseGmoFileButton_Click(object sender, EventArgs e)
        {
            attachmentCreationGmoFileTextBox.Text = FormUtils.openGmoFileDialog();
        }

        private void attachmentLinkBrowseCharacterControllerButton_Click(object sender, EventArgs e)
        {
            attachmentLinkBaseControllerTextBox.Text = FormUtils.openGenericFileDialog();
        }

        private void attachmentLinkBrowseLinkedControllerButton_Click(object sender, EventArgs e)
        {
            attachmentLinkDataTextBox.Text = FormUtils.openGenericFileDialog();
        }

        private void attachmentCreationGenerateButton_Click(object sender, EventArgs e)
        {
            String attachmentGmoFile = attachmentCreationGmoFileTextBox.Text;
            if (attachmentGmoFile.Equals(""))
            {
                MessageBox.Show("Select a valid GMO file");
                return;
            }
            else
            {
                try
                {
                    // Ready for Attachment creation
                    // TODO: clone this object
                    AttachmentData selectedAttachmentData = (AttachmentData)attachmentCreationBaseComboBox.SelectedValue;
                    int attachmentDlcSlotNumber = (int)attachmentCreationDlcSlotComboBox.SelectedIndex + 1;
                    UInt16 attachmentDlcSlotId = (UInt16)attachmentCreationDlcSlotComboBox.SelectedValue;

                    // Create needed folders
                    String baseFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                    String dlcDirectoryFolder = System.IO.Path.Combine(baseFolder, "dlc");
                    String dlcFolder = System.IO.Path.Combine(dlcDirectoryFolder, "[Slot " + attachmentCreationDlcSlotComboBox.Text + "][Attachment]");
                    if (Directory.Exists(dlcFolder))
                    {
                        Directory.Delete(dlcFolder, true);
                    }
                    Directory.CreateDirectory(dlcFolder);
                    String readmeFilePath = System.IO.Path.Combine(dlcFolder, "readme.txt");

                    // Generate player DLC (it must always be generated)            
                    // Compose DLC data
                    ObjectTable attachmentObjectTable = selectedAttachmentData.attachmentObjectTable;
                    ObjectEntry attachmentObjectEntry = (ObjectEntry)attachmentObjectTable.entries[0];

                    attachmentObjectEntry.id = attachmentDlcSlotId;
                    attachmentObjectEntry.objectEntrySlot = Convert.ToByte(attachmentDlcSlotNumber);
                    attachmentObjectEntry.modelName = ("G_" + "att_" + attachmentDlcSlotNumber.ToString("d3")).ToUpper(); // Ensure unique file name
                    attachmentObjectEntry.objxName = attachmentObjectEntry.modelName.ToLower(); // Ensure unique file name: use hash of current date

                    // Get hashed filenames, so the game can read them
                    String objectTableHashFileName = Hasher.hash("dlc/obj/dlc_" + attachmentDlcSlotNumber.ToString("d3") + "oe.bin") + ".edat";
                    String attachmentGmoHashFileName = Hasher.hash(("obj/" + attachmentObjectEntry.modelName + ".gmo").ToLower()) + ".edat";
                    String objxHashFileName = Hasher.hash(("obj/" + attachmentObjectEntry.objxName + ".objx").ToLower()) + ".edat";

                    // Write player files in DLC folder
                    using (StreamWriter readmeFileWriter = new StreamWriter(new FileStream(readmeFilePath, FileMode.Create)))
                    {
                        ResourceManager rm = new ResourceManager("DissDlcToolkit.Properties.Resources", Assembly.GetExecutingAssembly());

                        readmeFileWriter.WriteLine("Attachment in slot " + attachmentDlcSlotNumber);
                        readmeFileWriter.WriteLine("-----------------------");
                        readmeFileWriter.WriteLine("Attachment object entry slot: " + attachmentDlcSlotNumber.ToString());
                        readmeFileWriter.WriteLine("Attachment object entry ID: " + MiscUtils.swapEndianness(attachmentObjectEntry.id).ToString("X4"));
                        readmeFileWriter.WriteLine("-----------------------");

                        attachmentObjectTable.writeToFile(System.IO.Path.Combine(dlcFolder, objectTableHashFileName));
                        readmeFileWriter.WriteLine("Player object entry (BIN):\t\t" + objectTableHashFileName);

                        // If selected character is other than Aerith, add player models, portraits and exex file                    
                        File.Copy(attachmentGmoFile, System.IO.Path.Combine(dlcFolder, attachmentGmoHashFileName));
                        readmeFileWriter.WriteLine("Attachment model (GMO):\t\t\t" + attachmentGmoHashFileName);

                        byte[] objxBuffer = (byte[])rm.GetObject(selectedAttachmentData.internalName.ToUpper() + "_OBJX");
                        if (objxBuffer != null)
                        {
                            File.WriteAllBytes(System.IO.Path.Combine(dlcFolder, objxHashFileName), objxBuffer);
                            readmeFileWriter.WriteLine("Attachment object effects (OBJX):\t" + objxHashFileName);
                        }

                        readmeFileWriter.WriteLine("-----------------------");
                    }

                    MessageBox.Show("Success!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem saving the attachment files.");
                    Logger.Log(TAG, ex);
                }
            }
        }

        private void attachmentLinkGenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                String data = attachmentLinkDataTextBox.Text;
                String baseControllerFile = attachmentLinkBaseControllerTextBox.Text;
                if (!baseControllerFile.Equals(""))
                {
                    if (attachmentLinkControllerRadioButton.Checked)
                    {
                        // Attach base controller to attachment controller
                        ObjectTable attachmentTable = new ObjectTable(data);
                        ObjectEntry entry = (ObjectEntry)attachmentTable.entries[0];
                        attachControllerToId(baseControllerFile, entry.id);
                    }
                    else if (attachmentLinkIdRadioButton.Checked)
                    {
                        // Attach base controller to entered ID
                        UInt16 id;
                        Boolean result = UInt16.TryParse(data.ToUpper(), NumberStyles.HexNumber,
                            CultureInfo.InvariantCulture, out id);
                        attachControllerToId(baseControllerFile, MiscUtils.swapEndianness(id));
                    }
                }
                else
                {
                    MessageBox.Show("You need to select a base controller in order to link an attachment");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error linking the attachment");
                Logger.Log(TAG, ex);
            }
        }

        private void attachControllerToId(String baseControllerFile, UInt16 attachmentId)
        {
            // Set attachment ID to chosen base controller
            ObjectTable baseTable = new ObjectTable(baseControllerFile);
            ObjectEntry entry = (ObjectEntry)baseTable.entries[0];

            if (entry.addAttachment(attachmentId))
            {
                File.Copy(baseControllerFile, baseControllerFile + ".bak", true);
                baseTable.writeToFile(baseControllerFile);
                MessageBox.Show("Success!!");
            }
            else
            {
                MessageBox.Show("You have surpassed the limit of attachments to add to this controller");
            }
        }        

        private void attachmentLinkDataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (attachmentLinkIdRadioButton.Checked)
            {
                // Check input as hex only when in ID mode
                if (e.KeyChar != '\b')
                    e.Handled = !System.Uri.IsHexDigit(e.KeyChar);
                // Play standard error sound when the input is not valid hex
                if (e.Handled)
                {
                    System.Media.SystemSounds.Beep.Play();
                }
            }
        }
    }
}
