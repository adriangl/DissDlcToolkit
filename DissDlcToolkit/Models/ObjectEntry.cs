using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissDlcToolkit.Models
{
    class ObjectEntry
    {
        public static int MODEL_DATA_BYTES = 18;
        public static int ATTACHMENT_IDS_ARRAY_SIZE = 4;

        public UInt16 id { get; set; } // 0x00
        public UInt16 data1 { get; set; } // 0x02 
        public UInt16 data2 { get; set; } // 0x04
        public Byte characterId { get; set; } // 0x06
        public Byte costumeId { get; set; } // 0x07
        public Byte objectEntryType { get; set; } // 0x08; 08 if assist, 00 if player
        public Byte objectEntrySlot { get; set; } // 0x09
        public Byte[] modelData { get; set; } // 0x0A
        public UInt16[] attachmentIds { get; set; } // 0x18
        public String modelName { get; set; } // 0x24, 16 bytes (15 + \0)
        public String objxName { get; set; } // 0x34, 16 bytes (15 + \0)

        // Constants
        public const byte DLC_TYPE_PLAYER_OR_ATTACHMENT = 0x00;
        public const byte DLC_TYPE_ASSIST = 0x08;
        public const byte DLC_TYPE_MANIKIN_PLAYER = 0x05;
        public const byte DLC_TYPE_MANIKIN_ASSIST = 0x0D;

        public const byte COSTUME_SLOT_NORMAL = 0x01;
        public const byte COSTUME_SLOT_ALT1 = 0x02;
        public const byte COSTUME_SLOT_ALT2 = 0x03;

        public ObjectEntry()
        {
            modelData = new Byte[MODEL_DATA_BYTES];
            attachmentIds = new UInt16[ATTACHMENT_IDS_ARRAY_SIZE];
        }

        public ObjectEntry(BinaryReader reader) : this()
        {
            id = reader.ReadUInt16();
            data1 = reader.ReadUInt16();
            data2 = reader.ReadUInt16();
            characterId = reader.ReadByte();
            costumeId = reader.ReadByte();
            objectEntryType = reader.ReadByte();
            objectEntrySlot = reader.ReadByte();
            
            for (int i = 0; i < MODEL_DATA_BYTES; i++)
            {
                modelData[i] = reader.ReadByte();
            }
            
            for (int i = 0; i < ATTACHMENT_IDS_ARRAY_SIZE; i++)
            {
                attachmentIds[i] = reader.ReadUInt16();
            }
            byte[] buffer = new byte[16];
            reader.Read(buffer, 0, 16);
            modelName = Encoding.ASCII.GetString(buffer).TrimEnd('\0');

            buffer = new byte[16];
            reader.Read(buffer, 0, 16);
            objxName = Encoding.ASCII.GetString(buffer).TrimEnd('\0');           
        }

        public void write(BinaryWriter writer)
        {
            writer.Write(id);
            writer.Write(data1);
            writer.Write(data2);
            writer.Write(characterId);
            writer.Write(costumeId);
            writer.Write(objectEntryType);
            writer.Write(objectEntrySlot);

            for (int i = 0; i < MODEL_DATA_BYTES; i++)
            {
                writer.Write(modelData[i]);
            }

            for (int i = 0; i < ATTACHMENT_IDS_ARRAY_SIZE; i++)
            {
                writer.Write(attachmentIds[i]);
            }

            byte[] buffer = new byte[16];
            Encoding.ASCII.GetBytes(modelName, 0, modelName.Length, buffer, 0);
            writer.Write(buffer);

            buffer = new byte[16];
            Encoding.ASCII.GetBytes(objxName, 0, objxName.Length, buffer, 0);
            writer.Write(buffer);
        }

        public String getFormattedObjectEntryType()
        {
            switch (this.objectEntryType)
            {
                case DLC_TYPE_PLAYER_OR_ATTACHMENT:
                    return "Player/Attachment";
                case DLC_TYPE_ASSIST:
                    return "Assist";
                case DLC_TYPE_MANIKIN_PLAYER:
                    return "Manikin Player";
                case DLC_TYPE_MANIKIN_ASSIST:
                    return "Manikin Assist";
                default:
                    return "Unknown";
            }
        }

        public String getFormattedCostumeSlot()
        {
            switch (this.costumeId)
            {
                case COSTUME_SLOT_NORMAL:
                    return "Normal";
                case COSTUME_SLOT_ALT1:
                    return "Alt. 1";
                case COSTUME_SLOT_ALT2:
                    return "Alt. 2";
                default:
                    return "DLC "+(costumeId-3);
            }
        }
    }
}
