﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Character.Equipment
{
    public class ChrAsmCtrlEquipmentRing : IReadable<ChrAsmCtrlEquipmentRing>
    {
        public int ItemId { get; set; }
        public float Durability { get; set; }

        public ChrAsmCtrlEquipmentRing Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ItemId = reader.ReadInt32(address + 0x0000);
            Durability = reader.ReadSingle(address + 0x0008);
            return this;
        }
    }
}
