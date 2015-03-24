using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.GameData.Items;

namespace DarkSoulsII.DebugView.Model.Character.Equipment
{
    public class ChrAsmCtrlEquipmentWeapon : IReadable<ChrAsmCtrlEquipmentWeapon>
    {
        public int ItemId { get; set; }
        public byte Upgrade { get; set; }
        public Infusion Infusion { get; set; }
        public float Durability { get; set; }

        public ChrAsmCtrlEquipmentWeapon Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ItemId = reader.ReadInt32(address + 0x0000);
            Upgrade = reader.ReadByte(address + 0x0010);
            Infusion = (Infusion)reader.ReadByte(address + 0x0011);
            Durability = reader.ReadSingle(address + 0x0028);
            return this;
        }
    }
}
