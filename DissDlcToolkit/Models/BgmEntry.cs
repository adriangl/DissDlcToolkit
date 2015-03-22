using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DissDlcToolkit.Models
{
    class BgmEntry
    {
        public const int PADDING_1_SIZE = 10;
        public const int GAME_VALUE_ARRAY_ENTRIES = 2;

        public UInt32 id { get; set; }
        public byte[] padding1 { get; set; } // 10 0xFF bytes
        public UInt64[] gameValue { get; set; } // 16 bytes
        public String internalFileName { get; set; }

        public BgmEntry()
        {
            padding1 = new byte[PADDING_1_SIZE];
            for (int i = 0; i < padding1.Length; i++) { padding1[i] = 0xFF; }

            gameValue = new UInt64[GAME_VALUE_ARRAY_ENTRIES];
        }

        public BgmEntry(BinaryReader reader) : this()
        {
            id = reader.ReadUInt16();

            for (int i = 0; i < PADDING_1_SIZE; i++)
            {
                padding1[i] = reader.ReadByte();
            }
            
            for (int i = 0; i < GAME_VALUE_ARRAY_ENTRIES; i++)
            {
                gameValue[i] = reader.ReadUInt64();
            }

            byte[] buffer = new byte[16];
            reader.Read(buffer, 0, 16);
            internalFileName = Encoding.ASCII.GetString(buffer).TrimEnd('\0');  
        }

        public void write(BinaryWriter writer)
        {
            writer.Write(id);

            for (int i = 0; i < PADDING_1_SIZE; i++)
            {
                writer.Write(padding1[i]);
            }

            for (int i = 0; i < GAME_VALUE_ARRAY_ENTRIES; i++)
            {
                writer.Write(gameValue[i]);
            }

            byte[] buffer = new byte[16];
            Encoding.ASCII.GetBytes(internalFileName, 0, internalFileName.Length, buffer, 0);
            writer.Write(buffer);
        }
    }
}
