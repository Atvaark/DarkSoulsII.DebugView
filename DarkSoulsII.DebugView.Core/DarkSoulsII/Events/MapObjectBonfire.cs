﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Events
{
    public class MapObjectBonfire : IReadable<MapObjectBonfire>
    {
        public const int Size = 16;

        public const byte KindledMask = 1;
        public const byte AscentionLevelMask = 254;

        public short Id { get; set; }
        public bool Kindled { get; set; }
        public byte AscentionLevel { get; set; }

        public MapObjectBonfire Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Id = reader.ReadInt16(address + 0x0000, relative);

            var bonfireStatus = reader.ReadByte(address + 0x0002, relative);
            Kindled = (bonfireStatus & KindledMask) > 0;
            AscentionLevel = (byte) ((bonfireStatus & AscentionLevelMask) >> 1);

            // 0004 ParamEntry

            return this;
        }

    }
}
