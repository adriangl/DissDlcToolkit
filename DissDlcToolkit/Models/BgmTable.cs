using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DissDlcToolkit.Models
{
    class BgmTable
    {
        public static UInt64 BGM_TABLE_HEADER_VALUE = 0x20100831544E4542;

        public UInt64 header {get; set;}
        public List<BgmEntry> entries { get; set; }

        private Hashtable entryIds;

        public BgmTable()
        {
            entries = new List<BgmEntry>();
            entryIds = new Hashtable();
        }

        public BgmTable(String file): this()
        {
            using (FileStream stream = new FileStream(file, FileMode.Open))
            {
                createFromStream(stream);
            }
        }

        private void createFromStream(Stream stream)
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                header = reader.ReadUInt64();
                if (header != BGM_TABLE_HEADER_VALUE)
                {
                    // Throw exception if needed
                    throw new Exception("Not a valid BGM table file");
                }
                UInt32 entryNumber = reader.ReadUInt32();
                reader.ReadUInt32();
                for (int i = 0; i < entryNumber; i++)
                {
                    BgmEntry entry = new BgmEntry(reader);
                    entries.Add(entry);
                    // Save id & internal name
                    entryIds.Add(entry.id, entry.internalFileName);
                }
            }
        }

        public void writeToFile(String path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(BGM_TABLE_HEADER_VALUE);
                    writer.Write(Convert.ToUInt64(entries.Count));
                    foreach (BgmEntry entry in entries)
                    {
                        entry.write(writer);
                    }
                }
            }
        }

        public void addEntry(BgmEntry entry)
        {
            addEntry(entry, entries.Count);
        }

        public void addEntry(BgmEntry entry, int position)
        {
            // Add it to the array
            if (position > entries.Count)
            {
                return;
            }
            else if (position == entries.Count)
            {
                entries.Add(entry);
            }
            else {
                entries.Insert(position, entry);
            }            
            // Add to the entryIds hash if it has an ID set != Int16.MaxValue
            if (entry.id != UInt16.MaxValue)
            {
                entryIds.Add(entry.id, entry.internalFileName);
            }
        }

        public void removeEntry(BgmEntry entry)
        {
            if (entries.Remove(entry))
            {
                if (entryIds.ContainsKey(entry.id))
                {
                    entryIds.Remove(entry.id);
                }
            }
        }

        public void removeEntry(int position)
        {
            BgmEntry entry = entries[position];
            removeEntry(entry);
        }

        public void moveEntry(BgmEntry entry, int position)
        {
            removeEntry(entry);
            addEntry(entry, position);
        }

        public void generateRandomEntryNamesAndIds(int dlcSlot, bool forceReloadIds, bool forceReloadNames)
        {
            if (forceReloadIds)
            {
                entryIds.Clear();
            }
            foreach (BgmEntry entry in entries)
            {
                // Generate an ID; start from zero
                String hexString = dlcSlot.ToString(("X2")) + "00";
                UInt16 newId = UInt16.Parse(hexString, System.Globalization.NumberStyles.HexNumber);

                // If the id is the max uint32 max value, assume that it won't have
                // an ID set, and thus, no internal name
                if (entry.id == UInt16.MaxValue || forceReloadIds)
                {
                    bool validIdFound = false;               

                    // Find a valid ID
                    while (!validIdFound)
                    {                        
                        // Check if the ID is available; if it is, then save the value
                        if (!entryIds.ContainsKey(newId))
                        {
                            // Save ID & generate new name
                            entry.id = newId;
                            if (forceReloadNames)
                            {
                                entry.internalFileName = String.Format("ud_{0}{1}.at3",
                                    dlcSlot.ToString("D2"), newId.ToString("x4"));
                            }
                            // Save in hashtable
                            entryIds.Add(entry.id, entry.internalFileName);
                            // Mark as found for the given entry
                            validIdFound = true;
                        }
                        else
                        {
                            // Go to the next ID
                            newId++;
                        }
                    }                    
                }
                entry.bgmType = BgmEntry.BGM_TYPE_IS_DLC;
            }
        }

        internal void generateRandomEntryNamesAndIds(int dlcSlotNumber)
        {            
            generateRandomEntryNamesAndIds(dlcSlotNumber, false, true);
        }
    }
}
