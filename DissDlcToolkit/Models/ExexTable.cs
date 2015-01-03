using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissDlcToolkit.Models
{
    class ExexTable
    {
        public static UInt32 EXEX_TABLE_HEADER_VALUE = 0x02;

        public UInt32 header {get; set;}
        public ArrayList entries { get; set; }

        public ExexTable()
        {
            entries = new ArrayList();
        }

        public ExexTable(String file): this()
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
                header = reader.ReadUInt32();
                if (header != EXEX_TABLE_HEADER_VALUE)
                {
                    // Throw exception if needed
                    throw new Exception("Not a valid exex table file");
                }
                UInt32 entryNumber = reader.ReadUInt32();
                for (int i = 0; i < entryNumber; i++)
                {
                    ExexEntry entry = new ExexEntry(reader);
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
                    writer.Write(EXEX_TABLE_HEADER_VALUE);
                    writer.Write(entries.Count);
                    foreach (ExexEntry entry in entries)
                    {
                        entry.write(writer);
                    }
                }
            }
        }
    }
}
