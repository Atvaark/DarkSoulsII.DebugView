namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Area
{
    public class MapAreaCtrlOwner : IReadable<MapAreaCtrlOwner>
    {
        public int MapId { get; set; }

        public MapAreaCtrlOwner Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            MapId = reader.ReadInt32(address + 0x0004, relative);
            return this;
        }
    }
}
