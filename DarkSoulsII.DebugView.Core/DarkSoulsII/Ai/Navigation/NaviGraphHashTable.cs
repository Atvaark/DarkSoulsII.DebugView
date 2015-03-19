namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Ai.Navigation
{
    public class NaviGraphHashTable<T> : IReadable<NaviGraphHashTable<T>>
    {
        public NaviGraphHashTable<T> Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int bucketCount = reader.ReadInt32(address + 0x0008, relative);
            // 0000C pBuckets
            return this;
        }
    }
}