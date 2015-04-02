using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DissDlcToolkit.Utils
{
    class FormUtils
    {
        /**
         * Generic file dialog procedure
         */
        public static string openFileDialog(string fileFilter)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = fileFilter;
            openFileDialog1.FilterIndex = 1;

            // Set multiselect as disabled
            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult result = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (result.Equals(DialogResult.OK))
            {
                return openFileDialog1.FileName;
            }

            return null;
        }

        public static string openGmoFileDialog()
        {
            string filter = "GMO files (*.gmo)|*.gmo|All Files (*.*)|*.*";
            return openFileDialog(filter);
        }

        public static string openGimFileDialog()
        {
            string filter = "GIM files (*.gim)|*.gim|All Files (*.*)|*.*";
            return openFileDialog(filter);
        }

        public static string openExexFileDialog()
        {
            string filter = "EXEX files (*.exex)|*.exex|All Files (*.*)|*.*";
            return openFileDialog(filter);
        }

        public static string openAt3FileDialog()
        {
            string filter = "AT3 files (*.at3)|*.at3|All Files (*.*)|*.*";
            return openFileDialog(filter);
        }

        public static string openTxtSaveDialog()
        {
            string filter = "TXT files (*.txt)|*.txt";
            string title = "Save report to text file...";
            return openFileSaveDialog(filter, title);
        }

        public static string openExcelSaveDialog()
        {
            string filter = "XLSX files (*.xlsx)|*.xlsx";
            string title = "Save report to Excel spreadsheet...";
            return openFileSaveDialog(filter, title);
        }

        private static string openFileSaveDialog(string filter, string title)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;
            saveFileDialog.Title = title;
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                return saveFileDialog.FileName;
            }
            else 
            {
                return null;
            }
        }

        internal static string openGenericFileDialog()
        {
            string filter = "All Files (*.*)|*.*";
            return openFileDialog(filter);
        }
    }
}
