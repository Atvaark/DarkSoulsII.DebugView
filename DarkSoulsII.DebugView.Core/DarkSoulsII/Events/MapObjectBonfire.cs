namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Events
{
    public class MapObjectBonfire : IReadable<MapObjectBonfire>
    {
        public const int Size = 16;
        public short Id { get; set; }

        /// <summary>
        ///     (AscLevel-1)*2)+1 (&1 = Kindled, &254 = Ascetic Level)
        /// </summary>
        public byte AscentionLevel { get; set; }

        public MapObjectBonfire Read(IReader reader, int address, bool relative = false)
        {
            Id = reader.ReadInt16(address + 0x0000, relative);
            AscentionLevel = reader.ReadByte(address + 0x0002, relative);
            // 0004 ParamEntry

            return this;
        }
    }
}
