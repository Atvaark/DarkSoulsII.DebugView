using DarkSoulsII.DebugView.Core.DarkSoulsII.Character.Gestures;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character
{
    public class ChrAsmCtrl : IReadable<ChrAsmCtrl>
    {
        public ChrAsmCtrlGestures Gestures { get; set; }
        public ChrAsmCtrlEquipment Equipment { get; set; }

        public ChrAsmCtrl Read(IReader reader, int address, bool relative = false)
        {
            Gestures = Pointer<ChrAsmCtrlGestures>.CreateAndUnbox(reader, address + 0x0010);
            Equipment = Pointer<ChrAsmCtrlEquipment>.CreateAndUnbox(reader, address + 0x0014);
            return this;
        }
    }
}
