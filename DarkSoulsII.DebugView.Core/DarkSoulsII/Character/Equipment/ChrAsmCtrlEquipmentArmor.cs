namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character.Equipment
{
    public class ChrAsmCtrlEquipmentArmor : IReadable<ChrAsmCtrlEquipmentArmor>
    {
        public float Durability { get; set; }

        public ChrAsmCtrlEquipmentArmor Read(IReader reader, int address, bool relative = false)
        {
            Durability = reader.ReadSingle(address + 0x0018);

            return this;
        }
    }
}
