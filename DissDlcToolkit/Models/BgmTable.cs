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
        public ArrayList entries { get; set; }

        public BgmTable()
        {
            entries = new ArrayList();
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
    }
}
