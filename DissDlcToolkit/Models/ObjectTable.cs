using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissDlcToolkit.Models
{
    class ObjectTable
    {
        public static UInt32 MAGIC_NUMBER = 0x0C;

        public UInt32 magic {get; set;}
        public ArrayList entries { get; set; }

        public ObjectTable()
        {
            entries = new ArrayList();
        }

        public ObjectTable(byte[] file) : this()
        {
            using (MemoryStream stream = new MemoryStream(file))
            {
                createFromStream(stream);
            }
        }

        public ObjectTable(String path) : this()
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                createFromStream(stream);
            }
        }

        private void createFromStream(Stream stream)
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                magic = reader.ReadUInt32();
                if (magic != MAGIC_NUMBER)
                {
                    // Throw exception if needed
                    throw new Exception("Not a valid Object table file");
                }
                UInt32 entryNumber = reader.ReadUInt32();
                for (int i = 0; i < entryNumber; i++)
                {
                    ObjectEntry entry = new ObjectEntry(reader);
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
                    writer.Write(MAGIC_NUMBER);
                    writer.Write(entries.Count);
                    foreach (ObjectEntry entry in entries){
                        entry.write(writer);
                    }
                }
            }
        }

    }
}
