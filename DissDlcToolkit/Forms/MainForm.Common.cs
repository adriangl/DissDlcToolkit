using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DissDlcToolkit
{
    public partial class MainForm
    {   
        /**
         * Generic file dialog procedure
         */
        private string openFileDialog(string fileFilter)
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

        private string openGmoFileDialog()
        {
            string filter = "GMO files (.gmo)|*.gmo|All Files (*.*)|*.*";
            return openFileDialog(filter);
        }

        private string openGimFileDialog()
        {
            string filter = "GIM files (.gim)|*.gim|All Files (*.*)|*.*";
            return openFileDialog(filter);
        }

        private string openExexFileDialog()
        {
            string filter = "EXEX files (.exex)|*.exex|All Files (*.*)|*.*";
            return openFileDialog(filter);
        }
    }
}
