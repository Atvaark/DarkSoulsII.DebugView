namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapStateActEntry : IReadable<MapStateActEntry>, IFixedSize
    {
        public int Id { get; set; }
        public int State { get; set; }

        public int Size
        {
            get { return 8; }
        }

        public MapStateActEntry Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Id = reader.ReadInt32(address + 0x0000, relative);
            State = reader.ReadInt32(address + 0x0004, relative);
            return this;
        }

    }
}