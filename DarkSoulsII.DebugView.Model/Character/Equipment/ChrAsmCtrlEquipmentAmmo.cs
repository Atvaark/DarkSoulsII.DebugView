using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Character.Equipment
{
    public class ChrAsmCtrlEquipmentAmmo : IReadable<ChrAsmCtrlEquipmentAmmo>
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }

        public ChrAsmCtrlEquipmentAmmo Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ItemId = reader.ReadInt32(address + 0x0000);
            Quantity = reader.ReadInt32(address + 0x0008);
            return this;
        }
    }
}
