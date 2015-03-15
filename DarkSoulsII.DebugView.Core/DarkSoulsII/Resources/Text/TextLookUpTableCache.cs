using System.Collections.Generic;
using System.Linq;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Text
{
    public class TextLookUpTableCache : IReadable<TextLookUpTableCache>
    {
        public TextLookUpTableCache()
        {
            Entries = new Dictionary<TextLookupTableType, TextLookUpTableCacheEntry>();
        }

        public Dictionary<TextLookupTableType, TextLookUpTableCacheEntry> Entries { get; set; }

        public TextLookUpTableCache Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Entries = pointerFactory
                .CreateArrayDereferenced<TextLookUpTableCacheEntry>(address + 0x00D8, relative, 26)
                .Select((p, i) => new
                {
                    Type = (TextLookupTableType) i,
                    Entry = p.Unbox(pointerFactory, reader)
                })
                .ToDictionary(pair => pair.Type, pair => pair.Entry);
            return this;
        }
    }
}
