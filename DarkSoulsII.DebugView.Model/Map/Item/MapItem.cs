﻿using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.Map.Item
{
    public class MapItem : IReadable<MapItem>
    {
        public short Unknown1 { get; set; }
        public short Unknown2 { get; set; }
        public short ContainerId { get; set; }
        public short DropId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public Vector3 Position { get; set; }

        public MapItem Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            short containerIdLow = reader.ReadInt16(address + 0x0008, relative);
            Unknown1 = containerIdLow;
            Unknown2 = reader.ReadInt16(address + 0x0010, relative);
            ContainerId = reader.ReadInt16(address + 0x000C, relative);
            DropId = reader.ReadInt16(address + 0x000E, relative);
            ItemId = reader.ReadInt32(address + 0x0044, relative);
            Amount = reader.ReadInt32(address + 0x004C, relative);
            // TODO: Check if this works with multiple items
            // or Matrix4 at 0x00D0-0x010C

            Position = pointerFactory.Create<Vector3>(address + 0x0100, relative, true).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
