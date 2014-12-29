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
    class CharacterData : IComparable
    {
        public String characterName { get; set; }
        public String internalName { get; set; }
        public ObjectTable characterObjectTable { get; set; }
        public ObjectTable assistObjectTable { get; set; }

        public CharacterData(String characterName, String internalName)
        {
            this.characterName = characterName;
            this.internalName = internalName;

            // Read from resources           
            ResourceManager rm = new ResourceManager("DissDlcToolkit.Properties.Resources", Assembly.GetExecutingAssembly());
            characterObjectTable = getObjectTableFromResources(internalName.ToUpper() + "_1P", rm);
            assistObjectTable = getObjectTableFromResources(internalName.ToUpper() + "_1P_A", rm);           
        }

        private ObjectTable getObjectTableFromResources(String name, ResourceManager rm)
        {
            Byte[] tempByteArray = (Byte[])rm.GetObject(name);
            if (tempByteArray != null) return new ObjectTable(tempByteArray); else return null;
        }

        public override String ToString()
        {
            return characterName;
        }


        public int CompareTo(object obj)
        {
            return characterName.CompareTo(((CharacterData)obj).characterName);
        }
    }
}
