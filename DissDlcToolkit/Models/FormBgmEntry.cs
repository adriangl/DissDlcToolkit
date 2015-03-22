using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DissDlcToolkit.Models
{
    class FormBgmEntry
    {
        private BgmEntry entry { get; set; }
        public String filePath { get; set; }
        public String bgmTitle { get; set; }

        public FormBgmEntry(BgmEntry entry)
        {
            this.entry = entry;
        }
        
    }
}
