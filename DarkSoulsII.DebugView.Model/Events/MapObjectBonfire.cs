using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Events
{
    public class MapObjectBonfire : IReadable<MapObjectBonfire>, IFixedSize
    {
        public const byte KindledMask = 1;
        public const byte AscentionLevelMask = 254;

        public ushort Id { get; set; }
        public bool Kindled { get; set; }
        public byte AscentionLevel { get; set; }

        public int Size
        {
            get { return 16; }
        }

        public MapObjectBonfire Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Id = reader.ReadUInt16(address + 0x0000, relative);

            var bonfireStatus = reader.ReadByte(address + 0x0002, relative);
            Kindled = (bonfireStatus & KindledMask) > 0;
            AscentionLevel = (byte) ((bonfireStatus & AscentionLevelMask) >> 1);

            // 0004 ParamEntry
            return this;
        }

    }
}
