namespace DarkSoulsII.DebugView.Core.DarkSoulsII.EnemyGenerator
{
    public class MapDeadCounter : IReadable<MapDeadCounter>, IFixedSize
    {
        public int MapId { get; set; }
        public int Size
        {
            get { return 2832; }
        }

        public MapDeadCounter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            MapId = reader.ReadInt32(address + 0x0000, relative);
            int deadCounterCount = reader.ReadInt32(address + 0x0004, relative);
            return this;
        }

    }
}