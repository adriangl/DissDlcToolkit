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
        public UInt16 normalPlayerID { get; set; }
        public UInt16 normalAssistID { get; set; }
        public UInt16 alt1PlayerID { get; set; }
        public UInt16 alt1AssistID { get; set; }
        public UInt16 alt2PlayerID { get; set; }
        public UInt16 alt2AssistID { get; set; }
        public UInt16 manikinPlayerID { get; set; }
        public UInt16 manikinAssistID { get; set; }

        public CharacterData(String characterName, String internalName, 
            UInt16 normalPlayerId, UInt16 normalAssistId, UInt16 alt1PlayerId, 
            UInt16 alt1AssistId, UInt16 alt2PlayerId, UInt16 alt2AssistId, 
            UInt16 manikinPlayerId, UInt16 manikinAssistId)
        {
            this.characterName = characterName;
            this.internalName = internalName;
            this.normalPlayerID = normalPlayerId;
            this.normalAssistID = normalAssistId;
            this.alt1PlayerID = alt1PlayerId;
            this.alt1AssistID = alt1AssistId;
            this.alt2PlayerID = alt2PlayerId;
            this.alt2AssistID = alt2AssistId;
            this.manikinPlayerID = manikinPlayerId;
            this.manikinAssistID = manikinAssistId;

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
