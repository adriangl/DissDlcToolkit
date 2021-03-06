﻿using System;
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
        public static UInt32 OBJECT_TABLE_HEADER_VALUE = 0x0C;

        public UInt32 header {get; set;}
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
                header = reader.ReadUInt32();
                if (header != OBJECT_TABLE_HEADER_VALUE)
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
                    writer.Write(OBJECT_TABLE_HEADER_VALUE);
                    writer.Write(entries.Count);
                    foreach (ObjectEntry entry in entries){
                        entry.write(writer);
                    }
                }
            }
        }

    }
}
