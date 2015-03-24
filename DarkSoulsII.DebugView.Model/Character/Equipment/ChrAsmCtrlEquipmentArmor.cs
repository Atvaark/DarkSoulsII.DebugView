using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Character.Equipment
{
    public class ChrAsmCtrlEquipmentArmor : IReadable<ChrAsmCtrlEquipmentArmor>
    {
        public float Durability { get; set; }

        public ChrAsmCtrlEquipmentArmor Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Durability = reader.ReadSingle(address + 0x0018);
            return this;
        }
    }
}
