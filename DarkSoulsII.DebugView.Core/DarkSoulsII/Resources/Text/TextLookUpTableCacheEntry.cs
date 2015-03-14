namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Text
{
    public class TextLookUpTableCacheEntry : IReadable<TextLookUpTableCacheEntry>
    {
        public const int Size = 16;
        public TextLookUpTable LookupTable { get; set; }

        public TextLookUpTableCacheEntry Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // 0000 MemoryResourceObject
            // 0008 Memory

            LookupTable = pointerFactory.Create<TextLookUpTable>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
