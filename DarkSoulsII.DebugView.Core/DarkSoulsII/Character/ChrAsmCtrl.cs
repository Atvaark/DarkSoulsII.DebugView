namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character
{
    public class ChrAsmCtrl : IReadable<ChrAsmCtrl>
    {
        public ChrAsmCtrlEquipment Equipment { get; set; }

        public ChrAsmCtrl Read(IReader reader, int address, bool relative = false)
        {
            Equipment = Pointer<ChrAsmCtrlEquipment>.CreateAndUnbox(reader, address + 0x0014);
            return this;
        }
    }
}
