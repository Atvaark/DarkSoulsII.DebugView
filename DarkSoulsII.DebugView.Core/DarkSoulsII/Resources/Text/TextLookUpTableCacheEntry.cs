namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Text
{
    public class TextLookUpTableCacheEntry : IReadable<TextLookUpTableCacheEntry>, IFixedSize
    {
        public TextLookUpTable LookupTable { get; set; }

        public int Size
        {
            get { return 16; }
        }

        public TextLookUpTableCacheEntry Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // 0000 MemoryResourceObject
            // 0008 Memory

            LookupTable = pointerFactory.Create<TextLookUpTable>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}
