using DissDlcToolkit.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DissDlcToolkit
{
    /**
     * Main class that loads all data that the program needs in order to work
     */
    class GlobalData
    {
        // Object instance; it makes sense to use the singleton pattern to hold
        // global program data
        private static GlobalData instance;

        public ArrayList characterDataList { get; set; }
        public Dictionary<byte, String> characterIdNameMap { get; set; }

        public ArrayList attachmentDataList { get; set; }

        private GlobalData()
        {
            characterDataList = new ArrayList();
            characterIdNameMap = new Dictionary<byte, string>();
            attachmentDataList = new ArrayList();
            loadCharacterData();
            loadAttachmentData();
        }     

        public static GlobalData getInstance()
        {
            if (instance == null)
            {
                instance = new GlobalData();
            }
            return instance;
        }
        
        // Loads character controllers into memory
        private void loadCharacterData()
        {
            characterDataList.Add(new CharacterData("Warrior of Light", "p_one100", 0x001D, 0x029F, 0x001F, 0x03D9, 0x0222, 0x03DA, 0x00DA, 0x048D));
            characterDataList.Add(new CharacterData("Garland", "p_one200", 0x0003, 0x03EF, 0x0037, 0x03F0, 0x022D, 0x03F1, 0x0070, 0x0496));
            characterDataList.Add(new CharacterData("Firion", "p_two100", 0x0021, 0x03D1, 0x0022, 0x03DB, 0x0223, 0x03DC, 0x00DB, 0x048E));
            characterDataList.Add(new CharacterData("The Emperor", "p_two200", 0x0038, 0x03F2, 0x0039, 0x03F3, 0x022E, 0x03F4, 0x0071, 0x0497));
            characterDataList.Add(new CharacterData("Onion Knight", "p_thr100", 0x0013, 0x03DD, 0x0025, 0x03DE, 0x0224, 0x03DF, 0x00DC, 0x048F));
            characterDataList.Add(new CharacterData("Cloud of Darkness", "p_thr200", 0x003A, 0x03F5, 0x003B, 0x03F6, 0x022F, 0x03F7, 0x0072, 0x0498));
            characterDataList.Add(new CharacterData("Cecil", "p_for100", 0x001B, 0x03E0, 0x0029, 0x03E1, 0x0225, 0x03E2, 0x00DD, 0x0490));
            characterDataList.Add(new CharacterData("Kain", "p_for110", 0x0238, 0x054F, 0x0239, 0x0550, 0x023A, 0x0551, 0x023B, 0x0552));
            characterDataList.Add(new CharacterData("Golbez", "p_for200", 0x003C, 0x0474, 0x003D, 0x0475, 0x0230, 0x0476, 0x0073, 0x0499));
            characterDataList.Add(new CharacterData("Bartz", "p_fiv100", 0x002B, 0x0585, 0x002C, 0x0586, 0x0226, 0x0587, 0x00DE, 0x04B4));
            characterDataList.Add(new CharacterData("Exdeath", "p_fiv200", 0x003E, 0x03F8, 0x003F, 0x03F9, 0x0231, 0x03FA, 0x0074, 0x049A));
            characterDataList.Add(new CharacterData("Gilgamesh", "p_fiv210", 0x023C, 0x056E, 0x023D, 0x056F, 0x023E, 0x0570, 0x023F, 0x0571));
            characterDataList.Add(new CharacterData("Terra", "p_six100", 0x002D, 0x04A7, 0x002F, 0x04A8, 0x0227, 0x04A9, 0x00DF, 0x04AA));
            characterDataList.Add(new CharacterData("Kefka", "p_six200", 0x0040, 0x03FB, 0x0041, 0x03FC, 0x0232, 0x03FD, 0x0075, 0x049B));
            characterDataList.Add(new CharacterData("Cloud", "p_sev100", 0x0000, 0x03E3, 0x0031, 0x03E4, 0x0228, 0x03E5, 0x00E0, 0x0491));
            characterDataList.Add(new CharacterData("Tifa", "p_sev110", 0x0240, 0x0553, 0x0241, 0x0554, 0x0242, 0x0555, 0x0243, 0x0557));
            characterDataList.Add(new CharacterData("Aerith", "p_sev120", 0x04A3, 0x049F, 0x059C, 0x04A0, 0x059D, 0x04EB, 0xFFFF, 0xFFFF));
            characterDataList.Add(new CharacterData("Sephiroth", "p_sev200", 0x0001, 0x0409, 0x0042, 0x040A, 0x0233, 0x040B, 0x0076, 0x049C));
            characterDataList.Add(new CharacterData("Squall", "p_eht100", 0x0002, 0x03E6, 0x0032, 0x03E7, 0x0229, 0x03E8, 0x00E1, 0x0492));
            characterDataList.Add(new CharacterData("Laguna", "p_eht110", 0x0244, 0x0558, 0x0245, 0x0559, 0x0246, 0x055A, 0x0247, 0x055B));
            characterDataList.Add(new CharacterData("Ultimecia", "p_eht200", 0x0043, 0x04FC, 0x0044, 0x04FD, 0x0234, 0x04FE, 0x0077, 0x049F));
            characterDataList.Add(new CharacterData("Zidane", "p_nin100", 0x0014, 0x03E9, 0x0034, 0x03EA, 0x022A, 0x03EB, 0x00E2, 0x0493));
            characterDataList.Add(new CharacterData("Kuja", "p_nin200", 0x0045, 0x0500, 0x0046, 0x0501, 0x0235, 0x0502, 0x0078, 0x0503));
            characterDataList.Add(new CharacterData("Tidus", "p_ten100", 0x001C, 0x03EC, 0x0036, 0x03ED, 0x022B, 0x03EE, 0x00E3, 0x0494));
            characterDataList.Add(new CharacterData("Yuna", "p_ten110", 0x0248, 0x055C, 0x0249, 0x055D, 0x024A, 0x055E, 0x024B, 0x055F));
            characterDataList.Add(new CharacterData("Jecht", "p_ten200", 0x0047, 0x03FE, 0x0048, 0x03FF, 0x0236, 0x0400, 0x0079, 0x049D));
            characterDataList.Add(new CharacterData("Shantotto", "p_gst100", 0x004D, 0x0470, 0x004F, 0x0471, 0x022C, 0x0472, 0x0159, 0x0495));
            characterDataList.Add(new CharacterData("Prishe", "p_gst110", 0x024C, 0x0560, 0x024D, 0x0561, 0x024E, 0x0562, 0x024F, 0x0563));
            characterDataList.Add(new CharacterData("Vaan", "p_gst120", 0x0250, 0x0564, 0x0251, 0x0565, 0x0252, 0x0566, 0x0253, 0x0568));
            characterDataList.Add(new CharacterData("Lightning", "p_gst130", 0x0254, 0x0569, 0x0255, 0x056A, 0x0256, 0x056B, 0x0257, 0x056D));
            characterDataList.Add(new CharacterData("Gabranth", "p_gst200", 0x0104, 0x0450, 0x0105, 0x0451, 0x0237, 0x0452, 0x0174, 0x049E));
            characterDataList.Add(new CharacterData("Feral Chaos", "p_org210", 0x028E, 0xFFFF, 0x0572, 0xFFFF, 0xFFFF, 0xFFFF, 0xFFFF, 0xFFFF));

            characterDataList.Sort();

            foreach (CharacterData data in characterDataList)
            {
                characterIdNameMap.Add(((ObjectEntry)data.characterObjectTable.entries[0]).characterId, 
                    data.characterName);
            }
        }

        public String getCharacterNameFromId(byte id)
        {
            return characterIdNameMap.ContainsKey(id) ? characterIdNameMap[id] : "Unknown";
        }

        // Loads character controllers into memory
        private void loadAttachmentData()
        {
            attachmentDataList.Add(new AttachmentData("DLC Cloud's Cape", "g_sev101"));
            attachmentDataList.Add(new AttachmentData("DLC Cloud's Wing", "g_sev102"));
            attachmentDataList.Add(new AttachmentData("DLC Cloud's Sword Band", "g_sev103"));
            attachmentDataList.Add(new AttachmentData("DLC Sephiroth Coat", "g_sev201"));
            attachmentDataList.Add(new AttachmentData("DLC Zidane's Cape", "g_nin101"));
            attachmentDataList.Add(new AttachmentData("DLC Yuna's Parts", "g_ten111"));
            attachmentDataList.Add(new AttachmentData("DLC Emperor Parts", "g_two201"));

            attachmentDataList.Sort();
        }        
    }
}
