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

        private GlobalData()
        {
            characterDataList = new ArrayList();
            characterIdNameMap = new Dictionary<byte, string>();
            loadCharacterData();
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
            characterDataList.Add(new CharacterData("Warrior of Light", "p_one100"));
            characterDataList.Add(new CharacterData("Garland", "p_one200"));
            characterDataList.Add(new CharacterData("Firion", "p_two100"));
            characterDataList.Add(new CharacterData("The Emperor", "p_two200"));
            characterDataList.Add(new CharacterData("Onion Knight", "p_thr100"));
            characterDataList.Add(new CharacterData("Cloud of Darkness", "p_thr200"));
            characterDataList.Add(new CharacterData("Cecil", "p_for100"));
            characterDataList.Add(new CharacterData("Kain", "p_for110"));
            characterDataList.Add(new CharacterData("Golbez", "p_for200"));
            characterDataList.Add(new CharacterData("Bartz", "p_fiv100"));
            characterDataList.Add(new CharacterData("Exdeath", "p_fiv200"));
            characterDataList.Add(new CharacterData("Gilgamesh", "p_fiv210"));
            characterDataList.Add(new CharacterData("Terra", "p_six100"));
            characterDataList.Add(new CharacterData("Kefka", "p_six200"));
            characterDataList.Add(new CharacterData("Cloud", "p_sev100"));
            characterDataList.Add(new CharacterData("Tifa", "p_sev110"));
            characterDataList.Add(new CharacterData("Aerith", "p_sev120"));
            characterDataList.Add(new CharacterData("Sephiroth", "p_sev200"));
            characterDataList.Add(new CharacterData("Squall", "p_eht100"));
            characterDataList.Add(new CharacterData("Laguna", "p_eht110"));
            characterDataList.Add(new CharacterData("Ultimecia", "p_eht200"));
            characterDataList.Add(new CharacterData("Zidane", "p_nin100"));
            characterDataList.Add(new CharacterData("Kuja", "p_nin200"));
            characterDataList.Add(new CharacterData("Tidus", "p_ten100"));
            characterDataList.Add(new CharacterData("Yuna", "p_ten110"));
            characterDataList.Add(new CharacterData("Jecht", "p_ten200"));
            characterDataList.Add(new CharacterData("Shantotto", "p_gst100"));
            characterDataList.Add(new CharacterData("Prishe", "p_gst110"));
            characterDataList.Add(new CharacterData("Vaan", "p_gst120"));
            characterDataList.Add(new CharacterData("Lightning", "p_gst130"));
            characterDataList.Add(new CharacterData("Gabranth", "p_gst200"));
            characterDataList.Add(new CharacterData("Feral Chaos", "p_org210"));

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
    }
}
