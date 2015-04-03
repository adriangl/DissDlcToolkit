using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DissDlcToolkit.Utils;
using DissDlcToolkit.Models;
using OfficeOpenXml;
using FolderSelect;

namespace DissDlcToolkit.Forms
{
    public partial class MainFormDlcReporterUserControl : UserControl
    {
        private const String TAG = "MainFormDlcReporterUserControl";
        
        private ExcelPackage baseExcelPackage;
        
        private ExcelWorksheet characterDlcWorksheet;

        public MainFormDlcReporterUserControl()
        {
            InitializeComponent();
        }

        private void reporterLoadFolderButton_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dialog = new FolderSelectDialog();
            dialog.ShowDialog();
            string folder = dialog.FileName;
            if (!folder.Equals(""))
                reportSelectedFolder(folder);
        }

        private void reportSelectedFolder(String folder)
        {
            // First check: check if there are files in the folder, and check if the folder exists, just in case
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            if (!dirInfo.Exists)
            {
                MessageBox.Show("The selected folder does not exist");
                return;
            }
            else if (dirInfo.GetFiles().Length == 0)
            {
                MessageBox.Show("The selected folder hasn't got any files");
                return;
            }

            // Clean TextBox
            reporterDataTextBox.Text = "";

            // Get a worksheet to write excel values
            initExcelWorkbook();
            int excelRow = 2;

            // Iterate through all possible DLC Object Table names
            try
            {
                for (int i = 1; i <= 999; i++)
                {
                    String objectTableHashFileName = Hasher.hash("dlc/obj/dlc_" + i.ToString("d3") + "oe.bin") + ".edat";
                    String pathToSearch = System.IO.Path.Combine(folder, objectTableHashFileName);
                    if (File.Exists(pathToSearch))
                    {
                        // We have found an object table inside the folder; scan it
                        ObjectTable hashedFileObjectTable = new ObjectTable(pathToSearch);
                        foreach (ObjectEntry entry in hashedFileObjectTable.entries)
                        {
                            // Print results in TextBox
                            String textData = getTextDataForEntry(folder, i, objectTableHashFileName, entry);
                            reporterDataTextBox.AppendText(textData);
                            // And add them to Excel sheet
                            addExcelDataForEntry(folder, i, objectTableHashFileName, entry, characterDlcWorksheet, excelRow);
                            characterDlcWorksheet.Cells[characterDlcWorksheet.Dimension.Address].AutoFitColumns();
                            excelRow++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There was a problem with one or some of the files in the selected folder");
                Logger.Log(TAG, e);
                return;
            }
            // If the reporter text box has any data, then that means that there's data in the folder
            if (!reporterDataTextBox.Text.Trim().Equals(""))
            {
                reporterSaveToTextButton.Enabled = true;
                reporterSaveToExcelButton.Enabled = true;
                reporterFolderLabel.Text = folder;
                MessageBox.Show("DLC read OK!!");
            }
            else
            {
                MessageBox.Show("Couldn't find DLC in this folder");
            }
            
        }

        private ExcelWorksheet initExcelWorkbook()
        {
            // Init Excel spreadsheet data
            baseExcelPackage = new ExcelPackage();
            // Add the "DLC Files" sheet & headers
            characterDlcWorksheet = baseExcelPackage.Workbook.Worksheets.Add("DLC files");
            characterDlcWorksheet.Cells["A1"].Value = "DLC Slot";
            characterDlcWorksheet.Cells["B1"].Value = "Character";
            characterDlcWorksheet.Cells["C1"].Value = "Type";
            characterDlcWorksheet.Cells["D1"].Value = "DLC ID";
            characterDlcWorksheet.Cells["E1"].Value = "Costume Slot";
            characterDlcWorksheet.Cells["F1"].Value = "DLC Model name";
            characterDlcWorksheet.Cells["G1"].Value = "DLC .objx name";
            characterDlcWorksheet.Cells["H1"].Value = "Controller";
            characterDlcWorksheet.Cells["I1"].Value = "GMO";
            characterDlcWorksheet.Cells["J1"].Value = "GIM";
            characterDlcWorksheet.Cells["K1"].Value = "GIM Extra";
            characterDlcWorksheet.Cells["L1"].Value = "EXEX";
            characterDlcWorksheet.Cells["M1"].Value = "COSX";
            characterDlcWorksheet.Cells["N1"].Value = "OBJX";
            characterDlcWorksheet.Cells["A1:N1"].Style.Font.Bold = true;
            return characterDlcWorksheet;
        }

        private String getTextDataForEntry(String folder, int dlcObjectEntrySlot, String objectTableHashFileName, ObjectEntry entry)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("DLC Slot: " + dlcObjectEntrySlot);
            builder.AppendLine("Character: " + GlobalData.getInstance().getCharacterNameFromId(entry.characterId));
            builder.AppendLine("Type: " + entry.getFormattedObjectEntryType());
            builder.AppendLine("DLC ID: " + MiscUtils.swapEndianness(entry.id).ToString("X4"));
            builder.AppendLine("Costume slot: " + entry.getFormattedCostumeSlot());
            builder.AppendLine("DLC Model name: " + entry.modelName);
            builder.AppendLine("DLC .objx name: " + entry.objxName);
            builder.AppendLine("Files:");
            builder.AppendLine("\tController file: " + objectTableHashFileName);
            // Check if extra data exist, and print it
            addFileNameToStringBuilderIfExists("\tGMO File:", folder, Hasher.hash(("obj/" + entry.modelName + ".gmo").ToLower()) + ".edat", builder);
            addFileNameToStringBuilderIfExists("\tGIM File:", folder, Hasher.hash(("menu/JP/battle/chara_image/" + entry.modelName + ".gim").ToLower()) + ".edat", builder);
            addFileNameToStringBuilderIfExists("\tGIM Extra File:", folder, Hasher.hash(("menu/JP/battle/chara_image/" + entry.modelName + "_2.gim").ToLower()) + ".edat", builder);
            addFileNameToStringBuilderIfExists("\tEXEX File:", folder, Hasher.hash(("obj/" + entry.modelName + ".exex").ToLower()) + ".edat", builder);
            addFileNameToStringBuilderIfExists("\tCOSX File:", folder, Hasher.hash(("obj/" + entry.modelName + ".cosx").ToLower()) + ".edat", builder);
            addFileNameToStringBuilderIfExists("\tOBJX File:", folder, Hasher.hash(("obj/" + entry.modelName + ".objx").ToLower()) + ".edat", builder);
            builder.AppendLine("--------------------------------------");
            return builder.ToString();
        }

        private void addExcelDataForEntry(String folder, int dlcObjectEntrySlot, 
            String objectTableHashFileName, ObjectEntry entry, ExcelWorksheet ws, int excelRow)
        {
            ws.Cells["A"+excelRow].Value = dlcObjectEntrySlot;
            ws.Cells["B"+excelRow].Value = GlobalData.getInstance().getCharacterNameFromId(entry.characterId);
            ws.Cells["C"+excelRow].Value = entry.getFormattedObjectEntryType();
            ws.Cells["D"+excelRow].Value = MiscUtils.swapEndianness(entry.id).ToString("X4");
            ws.Cells["E"+excelRow].Value = entry.getFormattedCostumeSlot();
            ws.Cells["F"+excelRow].Value = entry.modelName;
            ws.Cells["G"+excelRow].Value = entry.objxName;
            ws.Cells["H"+excelRow].Value = objectTableHashFileName;
            // Check if extra data exist, and print it
            ws.Cells["I"+excelRow].Value = getFileNameIfExists(null, folder, Hasher.hash(("obj/" + entry.modelName + ".gmo").ToLower()) + ".edat");
            ws.Cells["J"+excelRow].Value = getFileNameIfExists(null, folder, Hasher.hash(("menu/JP/battle/chara_image/" + entry.modelName + ".gim").ToLower()) + ".edat");
            ws.Cells["K"+excelRow].Value = getFileNameIfExists(null, folder, Hasher.hash(("menu/JP/battle/chara_image/" + entry.modelName + "_2.gim").ToLower()) + ".edat");
            ws.Cells["L"+excelRow].Value = getFileNameIfExists(null, folder, Hasher.hash(("obj/" + entry.modelName + ".exex").ToLower()) + ".edat");
            ws.Cells["M" + excelRow].Value = getFileNameIfExists(null, folder, Hasher.hash(("obj/" + entry.modelName + ".cosx").ToLower()) + ".edat");
            ws.Cells["N"+excelRow].Value = getFileNameIfExists(null, folder, Hasher.hash(("obj/" + entry.modelName + ".objx").ToLower()) + ".edat");
        
        }

        private void addFileNameToStringBuilderIfExists(string description, string folder, string fileName, StringBuilder builder)
        {
            String s = getFileNameIfExists(description, folder, fileName);
            if (s != null)
            {
                builder.AppendLine(s);
            }
        }

        private String getFileNameIfExists(string description, string folder, string fileName)
        {
            if (File.Exists(System.IO.Path.Combine(folder, fileName)))
            {
                if (description != null)
                    return description + " " + fileName;
                else
                    return fileName;
            }
            return null;
        }

        private void reporterSaveToTextButton_Click(object sender, EventArgs e)
        {
            String fileToSave = FormUtils.openTxtSaveDialog();
            if (fileToSave != null)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(
                        fileToSave, FileMode.Create)))
                    {
                        writer.Write(reporterDataTextBox.Text);
                    }
                    reporterSaveToTextButton.Enabled = false;
                    MessageBox.Show("Text file exported OK!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The text file could not be exported.");
                    Logger.Log(TAG, ex);
                }
            }
        }

        private void reporterSaveToExcelButton_Click(object sender, EventArgs e)
        {
            String fileToSave = FormUtils.openExcelSaveDialog();
            if (fileToSave != null)
            {
                try
                {
                    using (ExcelPackage packageToSave = new ExcelPackage())
                    {
                        packageToSave.File = new FileInfo(@fileToSave);
                        packageToSave.Workbook.Worksheets.Add("DLC Files", characterDlcWorksheet);
                        packageToSave.Save();
                        MessageBox.Show("Excel spreadsheet exported OK!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The Excel file could not be exported.");
                    Logger.Log(TAG, ex);
                }
            }
        }   
    }
}
