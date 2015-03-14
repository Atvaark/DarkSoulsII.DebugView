using System.Collections.Generic;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Text
{
    public class TextLookUpTableCache : IReadable<TextLookUpTableCache>
    {
        public TextLookUpTableCache()
        {
            Entries = new Dictionary<TextLookupTableType, TextLookUpTableCacheEntry>();
        }

        public Dictionary<TextLookupTableType, TextLookUpTableCacheEntry> Entries { get; set; }

        public TextLookUpTableCache Read(IReader reader, int address, bool relative = false)
        {
            int offset = 0x00D8;
            for (int i = 0; i < 26; i++, offset += TextLookUpTableCacheEntry.Size)
            {
                var entry = Pointer<TextLookUpTableCacheEntry>.Create(address + offset, relative).Unbox(reader);
                Entries.Add((TextLookupTableType) i, entry);
            }
            return this;
        }
    }
}
