using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DissDlcToolkit.Widgets
{
    class RefreshableListBox : ListBox
    {
        public void RefreshItemAtPosition(int index)
        {
            this.RefreshItem(index);
        }

        public void RefreshListItems()
        {
            this.RefreshItems();
        }
    }
}
