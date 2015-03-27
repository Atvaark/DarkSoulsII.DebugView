using System.Collections.Generic;
using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Text
{
    public class TextLookUpTable : IReadable<TextLookUpTable>
    {
        private const int ItemEntrySize = 0x000C;
        public readonly Dictionary<int, string> IdToTextMap;

        public TextLookUpTable()
        {
            IdToTextMap = new Dictionary<int, string>();
        }

        public TextLookUpTable Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ////int size = reader.ReadInt32(address + 0x0004, relative);
            int count = reader.ReadInt32(address + 0x000C, relative);
            int stringCount = reader.ReadInt32(address + 0x0010, relative);

            // 0x0014 points to itemAddress + ItemEntrySize * count
            int offsetsAddress = reader.ReadInt32(address + 0x0014, relative);
            int[] offsets = reader.ReadInt32(stringCount, offsetsAddress);

            string[] strings = new string[stringCount];
            for (int i = 0; i < stringCount; i++)
            {
                var stringAddress = address + offsets[i];
                strings[i] = reader.ReadNullTerminatedUnicodeStringChunked(16, stringAddress, relative);
            }

            int itemAddress = address + 0x001C;
            for (int i = 0; i < count; i++, itemAddress += ItemEntrySize)
            {
                int index = reader.ReadInt32(itemAddress + 0x0000, relative);
                int lowId = reader.ReadInt32(itemAddress + 0x0004, relative);
                int highId = reader.ReadInt32(itemAddress + 0x0008, relative);
                int idCount = highId - lowId + 1;

                for (int j = 0; j < idCount; j++)
                {
                    IdToTextMap.Add(lowId + j, strings[index + j]);
                }
            }
            return this;
        }
    }
}
