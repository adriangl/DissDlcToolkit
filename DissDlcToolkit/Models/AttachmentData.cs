using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DissDlcToolkit.Models
{
    class AttachmentData : IComparable
    {
        public String attachmentName { get; set; }
        public String internalName { get; set; }
        public ObjectTable attachmentObjectTable { get; set; }

        public AttachmentData(String characterName, String internalName)
        {
            this.attachmentName = characterName;
            this.internalName = internalName;

            // Read from resources           
            ResourceManager rm = new ResourceManager("DissDlcToolkit.Properties.Resources", Assembly.GetExecutingAssembly());
            attachmentObjectTable = getObjectTableFromResources(internalName.ToUpper(), rm);           
        }

        private ObjectTable getObjectTableFromResources(String name, ResourceManager rm)
        {
            Byte[] tempByteArray = (Byte[])rm.GetObject(name);
            if (tempByteArray != null) return new ObjectTable(tempByteArray); else return null;
        }

        public override String ToString()
        {
            return attachmentName;
        }


        public int CompareTo(object obj)
        {
            return attachmentName.CompareTo(((AttachmentData)obj).attachmentName);
        }
    }
}
