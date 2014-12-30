using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DissDlcToolkit.Models
{
    class ExexEntry
    {
        public static readonly byte COLOR_NOT_INVERTED = 1;
        public static readonly byte COLOR_INVERTED = 2;

        public UInt16 auraId { get; set; }
        public UInt16 auraSlot { get; set; }
        public Color particleColor { get; set; }
        public byte[] data1;
        public Color outerGlowColor { get; set; }
        public Color innerGlowColor { get; set; }
        public byte[] data2;
        public Color smoke1Color { get; set; }
        public Boolean smoke1Invert { get; set; }
        public byte[] data3;
        public Color smoke2Color { get; set; }
        public Boolean smoke2Invert { get; set; }
        public byte[] data4;
        public Color boltsColor { get; set; }
        public Boolean boltsInvert { get; set; }
        public byte[] data5;
        

        public ExexEntry()
        {
            data1 = new byte[24];
            data2 = new byte[12];
            data3 = new byte[3];
            data4 = new byte[7];
            data5 = new byte[3];
        }

        public ExexEntry(BinaryReader reader) : this()
        {
            auraId = reader.ReadUInt16();
            auraSlot = reader.ReadUInt16();

            particleColor = readColor(reader);
            reader.Read(data1, 0, data1.Length);

            outerGlowColor = readColor(reader);
            innerGlowColor = readColor(reader);
            reader.Read(data2, 0, data2.Length);

            smoke1Color = readColor(reader);
            smoke1Invert = reader.ReadByte() != COLOR_NOT_INVERTED;
            reader.Read(data3, 0, data3.Length);

            smoke2Color = readColor(reader);
            smoke2Invert = reader.ReadByte() != COLOR_NOT_INVERTED;
            reader.Read(data4, 0, data4.Length);

            boltsColor = readColor(reader);
            boltsInvert = reader.ReadByte() != COLOR_NOT_INVERTED;
            reader.Read(data5, 0, data5.Length);
        }

        public void write(BinaryWriter writer)
        {
            writer.Write(auraId);
            writer.Write(auraSlot);
            writeColor(particleColor, writer, true);
            writer.Write(data1);
            writeColor(outerGlowColor, writer, true);
            writeColor(innerGlowColor, writer, true);
            writer.Write(data2);
            writeColor(smoke1Color, writer, false);
            writer.Write(smoke1Invert ? COLOR_INVERTED : COLOR_NOT_INVERTED);
            writer.Write(data3);
            writeColor(smoke2Color, writer, false);
            writer.Write(smoke2Invert ? COLOR_INVERTED : COLOR_NOT_INVERTED);
            writer.Write(data4);
            writeColor(boltsColor, writer, false);
            writer.Write(boltsInvert ? COLOR_INVERTED : COLOR_NOT_INVERTED);
            writer.Write(data5);
        }

        private Color readColor(BinaryReader reader)
        {
            byte red = reader.ReadByte();
            byte green = reader.ReadByte();
            byte blue = reader.ReadByte();
            byte alpha = reader.ReadByte();

            return Color.FromArgb(alpha, red, green, blue);
        }

        private void writeColor(Color color, BinaryWriter writer, Boolean writeAlpha)
        {
            writer.Write(color.R);
            writer.Write(color.G);
            writer.Write(color.B);
            writer.Write(writeAlpha ? color.A : (byte)0);
        }

    }
}
