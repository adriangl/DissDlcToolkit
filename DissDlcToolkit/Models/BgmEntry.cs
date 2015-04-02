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

        // Constants for byte 0x0C of entry, can be 00 01 02 03 04
        public const byte BGM_TYPE_IS_DLC = 4;

        // Constants for byte 0x0E, bgm visibility
        public const byte BGM_VISIBILITY_NONE = 0; // Only selectable in Jukebox
        public const byte BGM_VISIBILITY_NEEDS_UNLOCK = 1; // Selectable in battle & jukebox when unlocked
        public const byte BGM_VISIBILITY_DEFAULT = 2; // Selectable in battle & jukebox by default

        // BGM ID (0x00-0x01)
        public UInt16 id { get; set; }
        // TODO check what these bytes do (0x02-0x0B)
        public byte[] padding1 { get; set; } // 9 0xFF bytes        

        // BGM type (0x0C)
        public byte bgmType = BGM_TYPE_IS_DLC;

        // BGM Volume, from 0% to 100% (0x0D)
        public byte bgmVolume = 100;

        // BGM Visibility (0x0E-0x0F)
        public UInt16 bgmVisibility = BGM_VISIBILITY_DEFAULT;

        // Characters for which the BGM will play (0x10-0x17)
        public UInt64 bgmCharactersToPlay = 0;

        // Stages for which the BGM will play (0x18-1B)
        public UInt32 bgmStagesToPlay = 0;

        public String internalFileName { get; set; }

        public BgmEntry()
        {
            id = UInt16.MaxValue;
            padding1 = new byte[PADDING_1_SIZE];
            for (int i = 0; i < padding1.Length; i++) { padding1[i] = 0xFF; }
        }

        public BgmEntry(BinaryReader reader) : this()
        {
            id = reader.ReadUInt16();
            
            for (int i = 0; i < PADDING_1_SIZE; i++)
            {
                padding1[i] = reader.ReadByte();
            }

            bgmType = reader.ReadByte();

            bgmVolume = reader.ReadByte();

            bgmVisibility = reader.ReadUInt16();

            bgmCharactersToPlay = reader.ReadUInt64();

            bgmStagesToPlay = reader.ReadUInt32();

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

            writer.Write(bgmType);

            writer.Write(bgmVolume);

            writer.Write(bgmVisibility);

            writer.Write(bgmCharactersToPlay);

            writer.Write(bgmStagesToPlay);

            byte[] buffer = new byte[16];
            Encoding.ASCII.GetBytes(internalFileName, 0, internalFileName.Length, buffer, 0);
            writer.Write(buffer);
        }
    }
}
